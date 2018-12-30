using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartPovolgie.DAO
{
    public class EmployeeDAO
    {
        public Employee GetEmployeeByAuthorization(string login, string pass)
        {
            Employee emp = null;
            try
            {
                SqlConnection sqlConnection = Connect();
                string sql = string.Format("Select id_emp, lname, fname, patronymic, phone, address, job From Employee Where login= Lower('{0}') AND pass='{1}' AND status='Работает'", login.ToLower(), pass);

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = sql;
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader[6].ToString().Equals("Админ"))
                        emp = new Admin(Convert.ToInt32(dataReader[0]), login, pass, dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString());
                    else if (dataReader[6].ToString().Equals("Мастер")) {
                        int id_emp = Convert.ToInt32(dataReader[0]);
                        string lname = dataReader[1].ToString();
                        string fname = dataReader[2].ToString();
                        string patronymic = dataReader[3].ToString();
                        string phone = dataReader[4].ToString();
                        string address = dataReader[5].ToString();

                        sql = string.Format("Select id_s, char_spec From Master_Specialization Where id_m = Lower('{0}')", id_emp);

                        cmd = sqlConnection.CreateCommand();
                        cmd.CommandText = sql;
                        dataReader = cmd.ExecuteReader();
                        Dictionary<int, string> spec = new Dictionary<int, string>();
                        while (dataReader.Read())
                            spec.Add(Convert.ToInt32(dataReader[0]), dataReader[1].ToString());

                        sql = string.Format("Select id_c From Master Where id_m = Lower('{0}')", id_emp);

                        cmd = sqlConnection.CreateCommand();
                        cmd.CommandText = sql;
                        int idChief = (int)cmd.ExecuteScalar();

                        emp = new Master(id_emp, login, pass, lname, fname, patronymic, phone, address, idChief, spec);
                    }
                    else
                        emp = new Chief(Convert.ToInt32(dataReader[0]), login, pass, dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString());


                }
                dataReader.Close();
                Disconnect(sqlConnection);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return emp;
        }

        static SqlConnection Connect()
        {
            SqlConnection sqlConnection = null;
            try
            {
                string connectionString = @"Data Source=VLAD;Initial Catalog=StartPovolgie;Integrated Security=True";
                sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sqlConnection;
        }
        static void Disconnect(SqlConnection sqlConnection)
        {
            try
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
