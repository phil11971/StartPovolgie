using StartPovolgie.Controller;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartPovolgie.Forms
{
    public partial class AddSparePartForm : Form
    {

        private int id;
        SparePartController sparePartController;

        public AddSparePartForm()
        {
            InitializeComponent();
            this.ActiveControl = tbName;
            sparePartController = new SparePartController();
        }

        public AddSparePartForm(int id, string name, string desc, string cnt, string price)
        {
            InitializeComponent();
            lblAdd.Text = "Изменение информации о запчасти";
            tbName.Text = name;
            tbDesc.Text = desc;
            nudCnt.Text = cnt;
            nudPrice.Text = price;
            btnAdd.Text = "Изменить";
            this.id = id;
            this.ActiveControl = tbName;
            sparePartController = new SparePartController();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim().Equals("") || nudPrice.Text.Trim().Equals("") )
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка добваления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (id == 0)
                    {
                        SparePart sparePart = new SparePart(tbName.Text.Trim(), tbDesc.Text.Trim(), Convert.ToInt32(nudCnt.Text.Trim()), Convert.ToSingle(nudPrice.Text.Trim()));
                        if (!sparePartController.Insert(sparePart))
                        {
                            MessageBox.Show("Невозможно добавить новую запчасть!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            this.Close();
                    }
                    else
                    {
                        try
                        {
                            SparePart sparePart = new SparePart(id, tbName.Text.Trim(), tbDesc.Text.Trim(), Convert.ToInt32(nudCnt.Text.Trim()), Convert.ToSingle(nudPrice.Text.Trim()));
                            if (!sparePartController.Update(sparePart))
                            {
                                MessageBox.Show("Невозможно изменить информацию о запчасти!", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                this.Close();

                        }
                        catch (System.Data.SqlClient.SqlException)
                        {
                            MessageBox.Show("Невозможно изменить информацию о запчасти", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно добавить запчасть!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
