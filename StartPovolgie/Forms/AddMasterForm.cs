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
    public partial class AddMasterForm : Form
    {

        MasterController masterController;

        public AddMasterForm()
        {
            InitializeComponent();
            masterController = new MasterController();
            cbStatus.SelectedItem = "Работает";
            specializationTableAdapter.Fill(spDataSet.Specialization);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbLastName.Text.Trim().Equals("") || tbFirstName.Text.Trim().Equals("") || tbPhone.Text.Trim().Equals("") || tbAddress.Text.Trim().Equals("") ||
                tbLogin.Text.Trim().Equals("") || tbPass.Text.Trim().Equals(""))
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка добваления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Dictionary<int, string> masterSpecDict = new Dictionary<int, string>();
                    try
                    {
                        for (int i = 0; i < dgvMasterSpecialization.RowCount - 1; i++)
                        {
                            masterSpecDict.Add((int)dgvMasterSpecialization.Rows[i].Cells[0].Value, dgvMasterSpecialization.Rows[i].Cells[1].Value.ToString());
                        }
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("Добавление в словарь одинаковых понятий невозможно");
                        return;
                    }
                    Master master = new Master(tbLogin.Text.Trim(), tbPass.Text.Trim(),
                        tbLastName.Text.Trim(), tbFirstName.Text.Trim(), tbPatronymic.Text.Trim(), tbPhone.Text.Trim(), tbAddress.Text.Trim(), cbStatus.Text.Trim(),
                        masterSpecDict);
                    if (!masterController.Insert(master))
                    {
                        MessageBox.Show("Невозможно добавить новый вид устройства!\nВид с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        this.Close();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно добавить новый вид устройства!\nВид с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Ошибка работы с базой данных!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
