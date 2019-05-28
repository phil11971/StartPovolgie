using iTextSharp.text;
using iTextSharp.text.pdf;
using StartPovolgie.Controller;
using StartPovolgie.Model;
using StartPovolgie.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace StartPovolgie.Forms
{
    public partial class AcceptForRepairForm : Form
    {
        Employee employee;
        AcceptForRepair acceptForRepair;
        AcceptForRepairController acceptForRepairController;

        public AcceptForRepairForm(Employee employee)
        {
            InitializeComponent();
            acceptForRepairController = new AcceptForRepairController();
            this.employee = employee;
        }

        private void AcceptForRepairForm_Load(object sender, EventArgs e)
        {
            typeGoodTableAdapter.Fill(spDataSet.TypeGood);
            clientTableAdapter.Fill(spDataSet.Client);
            goodTableAdapter.Fill(spDataSet.Good);
            faultStatusTableAdapter.Fill(spDataSet.FaultStatus);
            idclientDataGridViewTextBoxColumn.Visible = false;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            var addClientForm = new AddClientForm();
            addClientForm.Closing += AddClientForm_Closing;
            addClientForm.ShowDialog();
        }

        private void AddClientForm_Closing(object sender, CancelEventArgs e)
        {
            clientTableAdapter.Fill(spDataSet.Client);
        }

        private void btnAddGood_Click(object sender, EventArgs e)
        {
            var addGoodForm = new AddGoodForm();
            addGoodForm.Closing += AddGoodForm_Closing;
            addGoodForm.ShowDialog();
        }

        private void AddGoodForm_Closing(object sender, CancelEventArgs e)
        {
            goodTableAdapter.Fill(spDataSet.Good);
        }

        private void btnFindGood_Click(object sender, EventArgs e)
        {
            if (!tbName.Text.Equals("") && !cbType.Text.Equals(""))
            {
                string sql = "Select g.id_g, g.name_g, g.id_tg From Good g Join TypeGood t On g.id_tg = t.id_tg Where t.name_tg = @cbType and g.name_g = @tbName";

                using (SqlCommand cmd = new SqlCommand(sql, ConnectionDB.Connect()))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@cbType";
                    param.Value = cbType.Text;
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 100;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@tbName";
                    param.Value = tbName.Text;
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 100;
                    cmd.Parameters.Add(param);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    spDataSet.Good.Clear();
                    dataAdapter.Fill(spDataSet.Good);

                }

                dgvGood.DataSource = spDataSet.Good;
            }
            else if (!tbName.Text.Equals(""))
            {
                string sql = "Select * From Good Where name_g=@tbName";

                using (SqlCommand cmd = new SqlCommand(sql, ConnectionDB.Connect()))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@tbName";
                    param.Value = tbName.Text;
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 100;
                    cmd.Parameters.Add(param);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    spDataSet.Good.Clear();
                    dataAdapter.Fill(spDataSet.Good);

                }

                dgvGood.DataSource = spDataSet.Good;
            }
            else if (!cbType.Text.Equals(""))
            {
                string sql = "Select g.id_g, g.name_g, g.id_tg From Good g Join TypeGood t On g.id_tg = t.id_tg Where t.name_tg = @cbType";

                using (SqlCommand cmd = new SqlCommand(sql, ConnectionDB.Connect()))
                {
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@cbType";
                    param.Value = cbType.Text;
                    param.SqlDbType = SqlDbType.VarChar;
                    param.Size = 100;
                    cmd.Parameters.Add(param);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    spDataSet.Good.Clear();
                    dataAdapter.Fill(spDataSet.Good);

                }

                dgvGood.DataSource = spDataSet.Good;
            }
        }

        private void btnCancelGood_Click(object sender, EventArgs e)
        {
            spDataSet.Service.Clear();
            goodTableAdapter.Fill(spDataSet.Good);
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            //todo maskedtb
            if (rbLastName.Checked)
                clientBindingSource.Filter = String.Format("lname=\'{0}\'", mtbFind.Text.Trim());
            else
                clientBindingSource.Filter = String.Format("phone=\'{0}\'", mtbFind.Text.Trim());
        }

        private void btnCancelClient_Click(object sender, EventArgs e)
        {
            clientBindingSource.Filter = "";
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (dgvFault.Rows[0].Cells[0].Value == null || dgvFault.Rows[0].Cells[1].Value == null || dgvFault.Rows[0].Cells[2].Value == null) 
            {
                MessageBox.Show("Заполните неисправности!", "Ошибка добваления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    LinkedList<Fault> faults = new LinkedList<Fault>();
                    for (int i = 0; i < dgvFault.RowCount - 1; i++)
                    {
                        faults.AddLast( new Fault(dgvFault.Rows[i].Cells[0].Value.ToString(), dgvFault.Rows[i].Cells[1].Value.ToString(), (int)dgvFault.Rows[i].Cells[2].Value) );
                    }
                    if (dgvClient.CurrentRow == null)
                    {
                        MessageBox.Show("Введите данные о клиенте", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        acceptForRepair = new AcceptForRepair(
                            rtbEquipment.Text.Trim(), rtbMechanicalDamage.Text.Trim(),
                            dtpReceiptDate.Value.Date, rtbComment.Text.Trim(),
                            (int)dgvGood.CurrentRow.Cells[0].Value, employee.Id, (int)dgvClient.CurrentRow.Cells[0].Value,
                            faults);
                        int idAccept;
                        if (!acceptForRepairController.Insert(acceptForRepair, out idAccept))
                        {
                            MessageBox.Show("Невозможно добавить новый вид устройства!\nВид с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        acceptForRepair.Id = idAccept;
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно добавить новый вид устройства!\nВид с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //todo print
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintAcceptForRepair();
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
                actNumP = new Paragraph("о приемке техники на диагностику", font14Bold);
                actNumP.Alignment = Element.ALIGN_CENTER;
                doc.Add(actNumP);
                doc.Add(new Paragraph("\n", font12));
                actNumP = new Paragraph("Дата приёма: " + acceptForRepair.ReceiptDate.Date.ToLongDateString() + "   ", font12);
                actNumP.Alignment = Element.ALIGN_RIGHT;
                doc.Add(actNumP);

                PdfPTable clientInformationTable = new PdfPTable(2);

                clientInformationTable.TotalWidth = 500f;
                clientInformationTable.LockedWidth = true;
                float[] widths = new float[] { 70f, 430f };
                clientInformationTable.SetWidths(widths);

                //ФИО клиента
                string clientName = dgvClient.CurrentRow.Cells[1].Value.ToString().Trim() +
                    dgvClient.CurrentRow.Cells[2].Value.ToString().Trim() +
                    dgvClient.CurrentRow.Cells[3].Value.ToString().Trim();
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
                cell = new PdfPCell(new Paragraph(dgvClient.CurrentRow.Cells[6].Value.ToString().Trim(), font12));
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
                cell = new PdfPCell(new Paragraph(dgvClient.CurrentRow.Cells[4].Value.ToString().Trim(), font12));
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
                
                pdfTable.AddCell(new Paragraph(dgvGood.CurrentRow.Cells[1].Value.ToString(), font12));
                pdfTable.AddCell(new Paragraph(Convert.ToString((dgvGood.CurrentRow.Cells[2] as DataGridViewComboBoxCell).FormattedValue.ToString()), font12));

                doc.Add(pdfTable);

                doc.Add(new Paragraph("\n", font12));
                p = new Paragraph("Заявленная неисправность:", font14Bold);
                p.IndentationLeft = 15f;
                p.Alignment = Element.ALIGN_LEFT;
                doc.Add(p);

                p = new Paragraph(rtbComment.Text.Trim(), font12);
                p.IndentationLeft = 15f;
                p.Alignment = Element.ALIGN_LEFT;
                doc.Add(p);
                doc.Add(new Paragraph("\n", font12));
                pdfTable = new PdfPTable(4);

                pdfTable.TotalWidth = 500f;
                pdfTable.LockedWidth = true;
                widths = new float[] { 20f, 200f, 140f, 140f };
                pdfTable.SetWidths(widths);

                cell = new PdfPCell(new Paragraph("№", font12Bold));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pdfTable.AddCell(cell);
                cell = new PdfPCell(new Paragraph("Наименование", font12Bold));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pdfTable.AddCell(cell);
                cell = new PdfPCell(new Paragraph("Единица измерения", font12Bold));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pdfTable.AddCell(cell);
                cell = new PdfPCell(new Paragraph("Количество", font12Bold));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                pdfTable.AddCell(cell);

                cell = new PdfPCell(new Paragraph("1", font12));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                pdfTable.AddCell(cell);
                cell = new PdfPCell(new Paragraph("Диагностика", font12));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                pdfTable.AddCell(cell);
                cell = new PdfPCell(new Paragraph("шт.", font12));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                pdfTable.AddCell(cell);
                cell = new PdfPCell(new Paragraph("1", font12));
                cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                cell.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
                pdfTable.AddCell(cell);

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

                p = new Paragraph("Исполнитель: СЦ Старт-Поволжье ______________       Заказчик: ______________________", font12);
                p.IndentationLeft = 12f;
                p.Alignment = Element.ALIGN_LEFT;
                doc.Add(p);

                doc.Add(new Paragraph("\n", font12));

                p = new Paragraph("М.П.                                                                          М.П.", font12);
                p.IndentationLeft = 120f;
                p.Alignment = Element.ALIGN_LEFT;
                doc.Add(p);


                doc.Add(new Paragraph("\n\n\n", font12));


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
    }
}
