﻿using StartPovolgie.Model;
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
    public partial class AddSparePartStatusForm : Form
    {
        private int id;
        SparePartStatusController sparePartStatusController;

        public AddSparePartStatusForm()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
            sparePartStatusController = new SparePartStatusController();
        }

        public AddSparePartStatusForm(int id, string nameTypeGood)
        {
            InitializeComponent(nameTypeGood);
            this.id = id;
            this.ActiveControl = textBox1;
            sparePartStatusController = new SparePartStatusController();
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
                        SparePartStatus sparePartStatus = new SparePartStatus(textBox1.Text.Trim());
                        if (!sparePartStatusController.Insert(sparePartStatus))
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
                            SparePartStatus sparePartStatus = new SparePartStatus(id, textBox1.Text.Trim());
                            if (!sparePartStatusController.Update(sparePartStatus))
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!( Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || Char.IsSeparator(e.KeyChar) ))
            {
                e.Handled = true;
            }
            else if (!(e.KeyChar >= 1040 && e.KeyChar <= 1103 || e.KeyChar == (char)Keys.Back || Char.IsSeparator(e.KeyChar) )) // 1040...1071 А ~ Я 1072...1103 а ~ я
            {
                String myCurrentLanguage = InputLanguage.CurrentInputLanguage.LayoutName;
                ChangeKeyboardLayout(System.Globalization.CultureInfo.GetCultureInfo("ru-RU"));
                e.Handled = true;
            }
        }

        private void ChangeKeyboardLayout(System.Globalization.CultureInfo CultureInfo)
        {
            InputLanguage c = InputLanguage.FromCulture(CultureInfo);
            InputLanguage.CurrentInputLanguage = c;
        }

    }
}
