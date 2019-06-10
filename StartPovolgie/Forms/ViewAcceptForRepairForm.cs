using iTextSharp.text;
using iTextSharp.text.pdf;
using StartPovolgie.Controller;
using StartPovolgie.Model;
using StartPovolgie.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace StartPovolgie.Forms
{
    public partial class ViewAcceptForRepairForm : Form
    {
        public Employee employee { get; private set; }
        AcceptForRepair acceptForRepair;

        public ViewAcceptForRepairForm(AcceptForRepair acceptForRepair, Employee employee)
        {
            InitializeComponent();
            this.acceptForRepair = acceptForRepair;
            this.employee = employee;
            if (employee.Job.Equals("Администратор"))
            {
                btnAddFault.Enabled = false;
                btnDelFault.Enabled = false;
            }
            else
            {
                btnAddFault.Enabled = true;
                btnDelFault.Enabled = true;
            }
        }

        private void ViewAcceptForRepairForm_Load(object sender, EventArgs e)
        {
            acceptForRepairTableAdapter.Fill(spDataSet.AcceptForRepair);
            employeeTableAdapter.Fill(spDataSet.Employee);
            clientTableAdapter.Fill(spDataSet.Client);
            typeGoodTableAdapter.Fill(spDataSet.TypeGood);
            goodTableAdapter.Fill(spDataSet.Good);
            faultTableAdapter.Fill(spDataSet.Fault);
            faultSparePartTableAdapter.Fill(spDataSet.FaultSparePart);
            returnFromRepairTableAdapter.Fill(spDataSet.ReturnFromRepair);

            acceptForRepairBindingSource.Filter = String.Format("id_accept=\'{0}\'", acceptForRepair.Id);
            returnFromRepairBindingSource.Filter = String.Format("id_return=\'{0}\'", acceptForRepair.Id);
            employeeBindingSource.Filter = String.Format("id_emp=\'{0}\'", acceptForRepair.IdAdmin);
            clientBindingSource.Filter = String.Format("id_client=\'{0}\'", acceptForRepair.IdClient);

            goodBindingSource.Filter = String.Format("id_g=\'{0}\'", acceptForRepair.IdGood);

            DataRowView dataRowView = (DataRowView)goodBindingSource.Current;
            typeGoodBindingSource.Filter = String.Format("id_tg=\'{0}\'", (int)dataRowView.Row.ItemArray[2]);

            faultBindingSource.Filter = String.Format("id_accept=\'{0}\'", acceptForRepair.Id);
            faultSparePartBindingSource.Filter = String.Format("id_fault=\'{0}\'", Int32.Parse(dgvFault.Rows[0].Cells[0].Value.ToString()));

            idfaultDataGridViewTextBoxColumn.Visible = false;
            idfaultDataGridViewTextBoxColumn1.Visible = false;

            if (!tbTotal.Text.Equals(""))
            {
                tbAmountSpareParts.Text = (Convert.ToSingle(tbTotal.Text.ToString()) - Convert.ToSingle(tbAmountRepair.Text.ToString())).ToString();
            }

            

            var table = returnFromRepairTableAdapter.GetData();
            string filter = "";
            filter += String.Format("id_return={0}", Int32.Parse(tbIdAccept.Text.ToString()));
            DataRow[] dataRows = table.Select(filter);
            if (dataRows.Length == 1)
            {
                btnCalc.Enabled = false;
                dtpIssueDate.Enabled = false;
                rtbDescJob.Enabled = false;
                btnAddFault.Enabled = false;
                btnDelFault.Enabled = false;
                btnAddSparePartForCurrFault.Enabled = false;
                btnDelSparePartForCurrFault.Enabled = false;
            }
            else
            {
                if (employee.Job.Equals("Администратор"))
                {
                    btnAddFault.Enabled = false;
                    btnDelFault.Enabled = false;
                    btnAddSparePartForCurrFault.Enabled = false;
                    btnDelSparePartForCurrFault.Enabled = false;
                }
                else
                {
                    btnAddFault.Enabled = true;
                    btnDelFault.Enabled = true;
                    btnAddSparePartForCurrFault.Enabled = true;
                    btnDelSparePartForCurrFault.Enabled = true;
                }
            }

        }

        private void dgvFault_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFault.SelectedRows.Count == 1)
            {
                faultSparePartBindingSource.Filter = String.Format("id_fault=\'{0}\'", dgvFault.CurrentRow.Cells[0].Value);
            }
        }

        private void btnAddSparePartForCurrFault_Click(object sender, EventArgs e)
        {
            var sparePartsForFaultForm = new SparePartsForFaultForm((int)dgvFault.CurrentRow.Cells[0].Value);
            sparePartsForFaultForm.Closed += Apda_RecFormed;
            sparePartsForFaultForm.ShowDialog();
        }

        private void Apda_RecFormed(object sender, EventArgs e)
        {
            faultTableAdapter.Fill(spDataSet.Fault);
            faultSparePartTableAdapter.Fill(spDataSet.FaultSparePart);
            faultSparePartBindingSource.Filter = String.Format("id_fault=\'{0}\'", dgvFault.CurrentRow.Cells[0].Value); ;
        }

        private void btnDelSparePartForCurrFault_Click(object sender, EventArgs e)
        {
            new FaultSparePartController().DeleteById( Int32.Parse(dgvFault.CurrentRow.Cells[0].Value.ToString()), Int32.Parse(dgvSparePart.CurrentRow.Cells[1].Value.ToString()));
            faultSparePartTableAdapter.Fill(spDataSet.FaultSparePart);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvFault.Rows.Count; i++)
            {
                if (dgvFault.Rows[i].Cells[2].Value.ToString().Equals(""))
                {
                    MessageBox.Show("Введите ст-ть устранения неисправности");
                    return;
                }
            }
            float priceFaults = 0;//ст-ть ремонта
            List<Fault> faults = new List<Fault>();
            for (int i = 0; i < dgvFault.Rows.Count; i++)
            {
                priceFaults += Convert.ToSingle(dgvFault.Rows[i].Cells[2].Value.ToString());
                faults.Add(new Fault(Int32.Parse(dgvFault.Rows[i].Cells[0].Value.ToString()), Convert.ToSingle(dgvFault.Rows[i].Cells[2].Value.ToString())));
            }
            tbAmountRepair.Text = priceFaults.ToString();

            string filter = "";
            filter += String.Format("id_fault={0}", Int32.Parse(dgvFault.Rows[0].Cells[0].Value.ToString()));
            for (int i = 1; i < dgvFault.Rows.Count; i++)
            {
                filter += String.Format(" OR id_fault={0}", Int32.Parse(dgvFault.Rows[i].Cells[0].Value.ToString()));
            }
            var table = faultSparePartTableAdapter.GetData();
            DataRow[] dataRows = table.Select(filter);
            float priceSpareParts = 0;//ст-ть ЗП
            for (int i = 0; i < dataRows.Length; i++)
            {
                priceSpareParts += Convert.ToSingle(dataRows[i].ItemArray[3].ToString());
            }
            tbAmountSpareParts.Text = priceSpareParts.ToString();

            float total = priceFaults + priceSpareParts;
            tbTotal.Text = total.ToString();

            new FaultController().Update(faults);

            if(employee.Job.Equals("Мастер"))
                btnExec.Enabled = true;
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите завершить приём в ремонт?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { 
                if (!tbAmountRepair.Text.Equals("") && !tbTotal.Text.Equals("") && !rtbDescJob.Text.Equals(""))
                {
                    ReturnFromRepair returnFromRepair = new ReturnFromRepair(Int32.Parse(tbIdAccept.Text), rtbDescJob.Text.Trim(), dtpIssueDate.Value.Date, float.Parse(tbAmountRepair.Text), float.Parse(tbTotal.Text));
                    new ReturnFromRepairController().Insert(returnFromRepair);
                    btnCalc.Enabled = false;
                    btnExec.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Рассчитайте стоимость ремонта и укажите описание работ!");
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rbAccept.Checked) {
                PrintAcceptForRepair();
            }
            else {
                var table = returnFromRepairTableAdapter.GetData();
                string filter = "";
                filter += String.Format("id_return={0}", Int32.Parse(tbIdAccept.Text.ToString()));
                DataRow[] dataRows = table.Select(filter);
                if (dataRows.Length == 1)
                    PrintReturnFromRepair();
                else
                    MessageBox.Show("Сначала нажмите кнопку 'Провести'");
            }
        }

        private void PrintAcceptForRepair()
        {
            try
            {
                var doc = new Document();
                PdfWriter pdfWr = PdfWriter.GetInstance(doc, new FileStream(Application.StartupPath + @"\AcceptForRepair.pdf", FileMode.Create));
                doc.Open();
                iTextSharp.text.Font fontTable = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
                var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                var font12 = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL);
                var font14Bold = new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD);
                var font12Bold = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD);
                var font9italic = new iTextSharp.text.Font(baseFont, 9, iTextSharp.text.Font.ITALIC);

                Paragraph actNumP = new Paragraph("Акт №  " + acceptForRepair.Id, font14Bold);
                actNumP.Alignment = Element.ALIGN_CENTER;
                doc.Add(actNumP);
                actNumP = new Paragraph("о приёме техники на диагностику", font14Bold);
                actNumP.Alignment = Element.ALIGN_CENTER;
                doc.Add(actNumP);
                doc.Add(new Paragraph("\n", font12));
                actNumP = new Paragraph("Дата приёма: " + dtpReceiptDate.Value.Date.ToLongDateString() + "   ", font12);
                actNumP.Alignment = Element.ALIGN_RIGHT;
                doc.Add(actNumP);

                PdfPTable clientInformationTable = new PdfPTable(2);

                clientInformationTable.TotalWidth = 500f;
                clientInformationTable.LockedWidth = true;
                float[] widths = new float[] { 70f, 430f };
                clientInformationTable.SetWidths(widths);

                //ФИО клиента
                string clientName = tbClientLastName.Text.Trim() + " " +
                    tbClientFirstName.Text.Trim() + " " +
                    tbClientPatr.Text.Trim();
                PdfPCell cell = new PdfPCell(new Paragraph("Клиент: ", font14Bold));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                cell.Border = 0;
                clientInformationTable.AddCell(cell);
                cell = new PdfPCell(new Paragraph(clientName, font12));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                cell.Border = 0;
                clientInformationTable.AddCell(cell);

                //Адрес
                cell = new PdfPCell(new Paragraph("Адрес: ", font14Bold));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                cell.Border = 0;
                clientInformationTable.AddCell(cell);
                cell = new PdfPCell(new Paragraph(tbAddress.Text.Trim(), font12));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                cell.Border = 0;
                clientInformationTable.AddCell(cell);

                //Телефон
                cell = new PdfPCell(new Paragraph("Телефон: ", font14Bold));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                cell.Border = 0;
                clientInformationTable.AddCell(cell);
                cell = new PdfPCell(new Paragraph(mtbPhone.Text.Trim(), font12));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                cell.Border = 0;
                clientInformationTable.AddCell(cell);

                doc.Add(clientInformationTable);

                Paragraph p = new Paragraph("сдал в сервисный центр следующее оборудование:", font12);
                p.IndentationLeft = 15f;
                p.Alignment = Element.ALIGN_LEFT;
                doc.Add(p);
                doc.Add(new Paragraph("\n", font12));

                PdfPTable pdfTable = new PdfPTable(2);

                pdfTable.TotalWidth = 500f;
                pdfTable.LockedWidth = true;
                widths = new float[] { 200f, 140f };
                pdfTable.SetWidths(widths);

                cell = new PdfPCell(new Paragraph("Наименование", font12Bold));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pdfTable.AddCell(cell);
                cell = new PdfPCell(new Paragraph("Вид устройства", font12Bold));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pdfTable.AddCell(cell);

                pdfTable.AddCell(new Paragraph(tbGood.Text.Trim().ToString(), font12));
                pdfTable.AddCell(new Paragraph(tbTypeGood.Text.Trim().ToString(), font12));
                doc.Add(pdfTable);

                doc.Add(new Paragraph("\n", font12));
                p = new Paragraph("Заявленные неисправности:", font14Bold);
                p.IndentationLeft = 15f;
                p.Alignment = Element.ALIGN_LEFT;
                doc.Add(p);

                doc.Add(new Paragraph("\n", font12));
                pdfTable = new PdfPTable(2);

                pdfTable.TotalWidth = 500f;
                pdfTable.LockedWidth = true;
                widths = new float[] { 20f, 200f};
                pdfTable.SetWidths(widths);

                cell = new PdfPCell(new Paragraph("№", font12Bold));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pdfTable.AddCell(cell);
                cell = new PdfPCell(new Paragraph("Наименование", font12Bold));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pdfTable.AddCell(cell);

                int k = 1;
                for (int i = 0; i < dgvFault.RowCount; i++)
                {
                    cell = new PdfPCell(new Paragraph(k++.ToString(), font12));
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                    pdfTable.AddCell(cell);
                    cell = new PdfPCell(new Paragraph(dgvFault.Rows[i].Cells[1].Value.ToString(), font12));
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                    pdfTable.AddCell(cell);
                }
                doc.Add(pdfTable);

                p = new Paragraph("Диагностика проводится в течение трех полных рабочих дней. Диагностика является бесплатной при условии последующего ремонта в нашем СЦ. " +
                    "В случае отказа от ремонта клиент оплачивает полную стоимость диагностики изделия - 300 (триста) рублей. Внешний осмотр техники осуществляется в присутствии клиента. " +
                    "Техника с согласия клиента принимается без разборки и проверки внутренних неисправностей. Клиент согласен, что все неисправности и внутренние повреждения, " +
                    "которые могут быть обнаружены в технике при диагностике (в том числе и скрытые дефекты), возникли до приёма техники в сервисный центр. " +
                    "Клиент соглашается, что техника принимается для проведения на срок от 2 до 14 дней и возможного последующего ремонта.", font9italic);
                p.IndentationLeft = 12f;
                p.IndentationRight = 12f;
                p.Alignment = Element.ALIGN_JUSTIFIED;
                doc.Add(p);
                doc.Add(new Paragraph("\n", font12));
                doc.Add(new Paragraph("\n", font12));

                string admin = String.Format("Администратор: {0}", employee.LastName + " " + employee.FirstName);
                p = new Paragraph(admin + "   ______________________", font12);
                p.IndentationLeft = 12f;
                p.Alignment = Element.ALIGN_LEFT;
                doc.Add(p);

                doc.Add(new Paragraph("\n", font12));

                doc.Close();

                Process printDoc = new Process();
                printDoc.StartInfo.FileName = Application.StartupPath + @"\AcceptForRepair.pdf";

                printDoc.Start();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Закройте ранее сформированный талон на приемку!", "Ошибка формирования талона приемки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintReturnFromRepair()
        {
            try
            {
                var doc = new Document();
                PdfWriter pdfWr = PdfWriter.GetInstance(doc, new FileStream(Application.StartupPath + @"\ReturnFromRepair.pdf", FileMode.Create));
                doc.Open();
                iTextSharp.text.Font fontTable = FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
                var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                var font12 = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.NORMAL);
                var font14Bold = new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD);
                var font12Bold = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.BOLD);
                var font9italic = new iTextSharp.text.Font(baseFont, 9, iTextSharp.text.Font.ITALIC);

                Paragraph actNumP = new Paragraph("Возврат из ремонта №  " + acceptForRepair.Id, font14Bold);
                actNumP.Alignment = Element.ALIGN_CENTER;
                doc.Add(actNumP);

                doc.Add(new Paragraph("\n", font12));

                actNumP = new Paragraph("Дата приёма: " + dtpReceiptDate.Value.Date.ToLongDateString() + "   ", font12);
                actNumP.Alignment = Element.ALIGN_RIGHT;
                doc.Add(actNumP);

                PdfPTable clientInformationTable = new PdfPTable(2);

                clientInformationTable.TotalWidth = 500f;
                clientInformationTable.LockedWidth = true;
                float[] widths = new float[] { 70f, 430f };
                clientInformationTable.SetWidths(widths);

                //ФИО клиента
                string clientName = tbClientLastName.Text.Trim() + " " +
                    tbClientFirstName.Text.Trim() + " " +
                    tbClientPatr.Text.Trim();
                PdfPCell cell = new PdfPCell(new Paragraph("Клиент: ", font14Bold));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                cell.Border = 0;
                clientInformationTable.AddCell(cell);
                cell = new PdfPCell(new Paragraph(clientName, font12));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                cell.Border = 0;
                clientInformationTable.AddCell(cell);

                //Адрес
                cell = new PdfPCell(new Paragraph("Адрес: ", font14Bold));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                cell.Border = 0;
                clientInformationTable.AddCell(cell);
                cell = new PdfPCell(new Paragraph(tbAddress.Text.Trim(), font12));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                cell.Border = 0;
                clientInformationTable.AddCell(cell);

                //Телефон
                cell = new PdfPCell(new Paragraph("Телефон: ", font14Bold));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                cell.Border = 0;
                clientInformationTable.AddCell(cell);
                cell = new PdfPCell(new Paragraph(mtbPhone.Text, font12));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                cell.Border = 0;
                clientInformationTable.AddCell(cell);

                doc.Add(clientInformationTable);

                doc.Add(new Paragraph("\n", font12));

                Paragraph p = new Paragraph("Описание работ:", font12Bold);
                p.IndentationLeft = 15f;
                p.Alignment = Element.ALIGN_LEFT;
                doc.Add(p);

                doc.Add(new Paragraph("\n", font12));

                p = new Paragraph(rtbDescJob.Text, font12);
                p.IndentationLeft = 12f;
                p.IndentationRight = 12f;
                p.Alignment = Element.ALIGN_JUSTIFIED;
                doc.Add(p);

                doc.Add(new Paragraph("\n", font12));

                PdfPTable pdfTable = new PdfPTable(3);

                pdfTable.TotalWidth = 500f;
                pdfTable.LockedWidth = true;
                widths = new float[] { 20f, 340f, 40f };
                pdfTable.SetWidths(widths);

                cell = new PdfPCell(new Paragraph("№", font12Bold));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pdfTable.AddCell(cell);
                cell = new PdfPCell(new Paragraph("Наименование неисправности", font12Bold));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pdfTable.AddCell(cell);
                cell = new PdfPCell(new Paragraph("Стоимость устранения", font12Bold));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pdfTable.AddCell(cell);

                int numAccept = 0;
                for (int i = 0; i < dgvFault.RowCount; i++)
                {
                    numAccept++;
                    pdfTable.AddCell(new Paragraph(numAccept.ToString(), font12));
                    pdfTable.AddCell(new Paragraph(dgvFault.Rows[i].Cells[1].Value.ToString(), font12));
                    pdfTable.AddCell(new Paragraph(dgvFault.Rows[i].Cells[2].Value.ToString(), font12));
                }
                doc.Add(pdfTable);

                //doc.Add(new Paragraph("\n", font12));
                p = new Paragraph("Итого по выполненным работам: " + tbAmountRepair.Text.Trim() + " руб. 00 коп.", font12Bold);
                p.IndentationLeft = 15f;
                p.Alignment = Element.ALIGN_LEFT;
                doc.Add(p);

                if (dgvSparePart.Rows.Count != 0)
                {
                    doc.Add(new Paragraph("\n", font12));
                    pdfTable = new PdfPTable(5);

                    pdfTable.TotalWidth = 500f;
                    pdfTable.LockedWidth = true;
                    widths = new float[] { 20f, 340f, 40f, 50f, 50f };
                    pdfTable.SetWidths(widths);

                    cell = new PdfPCell(new Paragraph("№", font12Bold));
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    pdfTable.AddCell(cell);
                    cell = new PdfPCell(new Paragraph("Наименование запчасти", font12Bold));
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    pdfTable.AddCell(cell);
                    cell = new PdfPCell(new Paragraph("Цена", font12Bold));
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    pdfTable.AddCell(cell);
                    cell = new PdfPCell(new Paragraph("Кол-во", font12Bold));
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    pdfTable.AddCell(cell);
                    cell = new PdfPCell(new Paragraph("Сумма", font12Bold));
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    pdfTable.AddCell(cell);
                    numAccept = 0;
                    for (int i = 0; i < dgvSparePart.RowCount; i++)
                    {
                        numAccept++;
                        pdfTable.AddCell(new Paragraph(numAccept.ToString(), font12));
                        pdfTable.AddCell(new Paragraph(dgvSparePart.Rows[i].Cells[2].Value.ToString(), font12));
                        pdfTable.AddCell(new Paragraph(dgvSparePart.Rows[i].Cells[6].Value.ToString(), font12));
                        pdfTable.AddCell(new Paragraph(dgvSparePart.Rows[i].Cells[3].Value.ToString(), font12));
                        pdfTable.AddCell(new Paragraph(dgvSparePart.Rows[i].Cells[4].Value.ToString(), font12));
                    }
                    doc.Add(pdfTable);

                    //doc.Add(new Paragraph("\n", font12));
                    p = new Paragraph("Итого по используемым запчастям: " + tbAmountSpareParts.Text.Trim() + " руб. 00 коп.", font12Bold);
                    p.IndentationLeft = 15f;
                    p.Alignment = Element.ALIGN_LEFT;
                    doc.Add(p);
                }

                doc.Add(new Paragraph("\n", font12));
                p = new Paragraph("ИТОГО: " + tbTotal.Text.Trim() + " руб. 00 коп. ", font12Bold);
                p.IndentationLeft = 15f;
                p.Alignment = Element.ALIGN_LEFT;
                doc.Add(p);

                doc.Add(new Paragraph("\n", font12));

                p = new Paragraph("Вышеперечисленные работы (услуги) выполнены полностью и в срок. Заказчик претензий по объему, внешнему виду, качеству и срокам выполнения работ (оказания услуг) не имеет. С условиями гарантии ознакомлен (гарантия на программное обеспечение не распространяется). Настоящий акт составлен в двух экземплярах, один из которых находится у Исполнителя, второй у Заказчика.", font9italic);
                p.IndentationLeft = 12f;
                p.IndentationRight = 12f;
                p.Alignment = Element.ALIGN_JUSTIFIED;
                doc.Add(p);
                doc.Add(new Paragraph("\n", font12));

                p = new Paragraph("Дата выдачи: " + dtpIssueDate.Value.Date.ToLongDateString(), font12);
                p.IndentationLeft = 15f;
                p.Alignment = Element.ALIGN_LEFT;
                doc.Add(p);
                doc.Add(new Paragraph("\n", font12));
                doc.Add(new Paragraph("\n", font12));

                string admin = String.Format("Администратор: {0}", employee.LastName + " " + employee.FirstName);
                p = new Paragraph(admin + "   ______________________", font12);
                p.IndentationLeft = 12f;
                p.Alignment = Element.ALIGN_LEFT;
                doc.Add(p);

                doc.Add(new Paragraph("\n", font12));

                doc.Close();

                Process printDoc = new Process();
                printDoc.StartInfo.FileName = Application.StartupPath + @"\ReturnFromRepair.pdf";

                printDoc.Start();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Закройте ранее сформированный акт оказанных услуг!", "Ошибка формирования документа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddFault_Click(object sender, EventArgs e)
        {
            var addFaultForm = new AddFaultForm(Convert.ToInt32(tbIdAccept.Text.ToString()));
            addFaultForm.Closed += Apda_RecFormed;
            addFaultForm.ShowDialog();
        }

        private void btnDelFault_Click(object sender, EventArgs e)
        {
            new FaultController().DeleteById(Convert.ToInt32(dgvFault.CurrentRow.Cells[0].Value));
            faultTableAdapter.Fill(spDataSet.Fault);
        }
    }
}
