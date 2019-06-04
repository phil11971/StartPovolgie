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
                SqlConnection sqlConnection = ConnectionDB.Connect();
                string sql = string.Format("Select id_emp, lname, fname, patronymic, phone, address, job From Employee Where login= Lower('{0}') AND pass='{1}' AND status='Работает'", login.ToLower(), pass);

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = sql;
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    if (dataReader[6].ToString().Equals("Администратор"))
                        emp = new Administrator(Convert.ToInt32(dataReader[0]), login, pass, dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString(), dataReader[6].ToString());
                    else if (dataReader[6].ToString().Equals("Мастер")) {
                        int id_emp = Convert.ToInt32(dataReader[0]);
                        string lname = dataReader[1].ToString();
                        string fname = dataReader[2].ToString();
                        string patronymic = dataReader[3].ToString();
                        string phone = dataReader[4].ToString();
                        string address = dataReader[5].ToString();
                        string status = dataReader[6].ToString();

                        dataReader.Close();

                        sql = string.Format("Select id_spec, char_spec From MasterSpecialization Where id_master = Lower('{0}')", id_emp);

                        cmd = sqlConnection.CreateCommand();
                        cmd.CommandText = sql;
                        dataReader = cmd.ExecuteReader();
                        Dictionary<int, string> spec = new Dictionary<int, string>();
                        while (dataReader.Read())
                            spec.Add(Convert.ToInt32(dataReader[0]), dataReader[1].ToString());

                        emp = new Master(id_emp, login, pass, lname, fname, patronymic, phone, address, status, spec);
                    }
                }
                dataReader.Close();
                ConnectionDB.Disconnect(sqlConnection);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return emp;
        }

        public bool Insert(Employee employee)
        {
            try
            {
                if (!HasSameType(employee, false))
                {
                    if (employee.Job.Equals("Администратор")) {
                        string sqlExpression = "sp_InsertAdmin";

                        using (SqlConnection connection = ConnectionDB.Connect())
                        {
                            SqlCommand command = new SqlCommand(sqlExpression, connection);
                            command.CommandType = System.Data.CommandType.StoredProcedure;

                            SqlParameter loginParam = new SqlParameter
                            {
                                ParameterName = "@login",
                                Value = employee.Login
                            };
                            command.Parameters.Add(loginParam);

                            SqlParameter passParam = new SqlParameter
                            {
                                ParameterName = "@pass",
                                Value = employee.Password
                            };
                            command.Parameters.Add(passParam);

                            SqlParameter lnameParam = new SqlParameter
                            {
                                ParameterName = "@lname",
                                Value = employee.LastName
                            };
                            command.Parameters.Add(lnameParam);

                            SqlParameter fnameParam = new SqlParameter
                            {
                                ParameterName = "@fname",
                                Value = employee.FirstName
                            };
                            command.Parameters.Add(fnameParam);

                            SqlParameter patrParam = new SqlParameter
                            {
                                ParameterName = "@patronymic",
                                Value = employee.Patronymic
                            };
                            command.Parameters.Add(patrParam);

                            SqlParameter phoneParam = new SqlParameter
                            {
                                ParameterName = "@phone",
                                Value = employee.Phone
                            };
                            command.Parameters.Add(phoneParam);

                            SqlParameter addressParam = new SqlParameter
                            {
                                ParameterName = "@address",
                                Value = employee.Address
                            };
                            command.Parameters.Add(addressParam);

                            command.ExecuteNonQuery();
                        }
                        return true;
                    }
                    return false;

                }
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool Update(Employee employee)
        {
            try
            {
                if (HasSameType(employee, true))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Update Employee Set login=@login, pass=@pass, lname=@lname, fname=@fname, patronymic=@patronymic, phone=@phone, address=@address, status=@status Where id_emp=(@id_emp);";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param = new SqlParameter();
                        param.ParameterName = "@id_emp";
                        param.Value = employee.Id;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@login";
                        param.Value = employee.Login;
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Size = 100;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@pass";
                        param.Value = employee.Password;
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Size = 100;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@lname";
                        param.Value = employee.LastName;
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Size = 100;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@fname";
                        param.Value = employee.FirstName;
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Size = 100;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@patronymic";
                        param.Value = employee.Patronymic;
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Size = 100;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@phone";
                        param.Value = employee.Phone;
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Size = 100;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@address";
                        param.Value = employee.Address;
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Size = 100;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@status";
                        param.Value = employee.Status;
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Size = 100;
                        cmd.Parameters.Add(param);

                        cmd.ExecuteNonQuery();
                    }
                    ConnectionDB.Disconnect(sqlConnection);
                    return true;
                }
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool SetLoginAndPasswordById(int id, string login, string password)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionDB.Connect();
                string sql = string.Format("Update Employee Set login='{0}', pass='{1}' From Employee Where id_emp={2}", login.ToLower(), password, id);

                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                ConnectionDB.Disconnect(sqlConnection);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return true;
        }

        private bool HasSameType(Employee employee, bool isUpdate)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionDB.Connect();
                string sql = string.Format("Select count(id_emp) From Employee Where login='{0}' and pass='{1}'", employee.Login, employee.Password);
                if (isUpdate)
                    sql = string.Format("Select count(id_emp) From Employee Where id_emp='{2}'", employee.Login, employee.Password, employee.Id);
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = sql;
                SqlDataReader dataReader = cmd.ExecuteReader();
                int count = -1;
                while (dataReader.Read())
                {
                    count = Convert.ToInt32(dataReader[0]);
                }
                dataReader.Close();
                ConnectionDB.Disconnect(sqlConnection);
                if (count > 0) return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void DeleteById(int id)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionDB.Connect();
                string sql = string.Format("Delete From Employee Where id_emp= '{0}'", id);
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.ExecuteNonQuery();
                ConnectionDB.Disconnect(sqlConnection);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}
