using StartPovolgie.Model;
using StartPovolgie.Controller;
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
    public partial class AddTypeGoodForm : Form
    {
        private int id;
        TypeGoodController typeGoodController;

        public AddTypeGoodForm()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
            typeGoodController = new TypeGoodController();
        }

        public AddTypeGoodForm(int id, string nameTypeGood)
        {
            InitializeComponent(nameTypeGood);
            this.id = id;
            this.ActiveControl = textBox1;
            typeGoodController = new TypeGoodController();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка добваления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (id == 0)
                    {
                        TypeGood newTypeGood = new TypeGood(textBox1.Text.Trim());
                        if (!typeGoodController.Insert(newTypeGood))
                        {
                            MessageBox.Show("Невозможно добавить новый вид устройства!\nВид с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            this.Close();
                    }
                    else
                    {
                        try
                        {
                            TypeGood newTypeGood = new TypeGood(id, textBox1.Text.Trim());
                            if (!typeGoodController.Update(newTypeGood))
                            {
                                MessageBox.Show("Невозможно изменить тип товара!\nТип товара с таким именем уже существует.", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                this.Close();
                            
                        }
                        catch (System.Data.SqlClient.SqlException)
                        {
                            MessageBox.Show("Невозможно изменить тип товара!\nТип товара с таким именем уже существует.", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Невозможно добавить новый вид устройства!\nВид с таким названием уже существует.", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка работы с базой данных!", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
