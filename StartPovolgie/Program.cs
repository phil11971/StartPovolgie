using StartPovolgie.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartPovolgie
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AuthorizationForm());

            try
            {
                var authForm = new AuthorizationForm();
                if (authForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm(authForm.Emp));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка в работе системы!", "Ошибка в работе", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
