using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.DAO
{
    public class MasterDAO
    {
        public bool Insert(Master master)
        {
            try
            {
                if (!HasSameType(master, false))
                {
                    if (master.Job.Equals("Мастер"))
                    {
                        using (SqlConnection connection = ConnectionDB.Connect())
                        {
                            SqlTransaction transaction = connection.BeginTransaction();
                            string sqlExpression = "sp_InsertMaster";

                            SqlCommand command = new SqlCommand(sqlExpression, connection, transaction);
                            command.CommandType = CommandType.StoredProcedure;

                            SqlParameter loginParam = new SqlParameter
                            {
                                ParameterName = "@login",
                                Value = master.Login
                            };
                            command.Parameters.Add(loginParam);

                            SqlParameter passParam = new SqlParameter
                            {
                                ParameterName = "@pass",
                                Value = master.Password
                            };
                            command.Parameters.Add(passParam);

                            SqlParameter lnameParam = new SqlParameter
                            {
                                ParameterName = "@lname",
                                Value = master.LastName
                            };
                            command.Parameters.Add(lnameParam);

                            SqlParameter fnameParam = new SqlParameter
                            {
                                ParameterName = "@fname",
                                Value = master.FirstName
                            };
                            command.Parameters.Add(fnameParam);

                            SqlParameter patrParam = new SqlParameter
                            {
                                ParameterName = "@patronymic",
                                Value = master.Patronymic
                            };
                            command.Parameters.Add(patrParam);

                            SqlParameter phoneParam = new SqlParameter
                            {
                                ParameterName = "@phone",
                                Value = master.Phone
                            };
                            command.Parameters.Add(phoneParam);

                            SqlParameter addressParam = new SqlParameter
                            {
                                ParameterName = "@address",
                                Value = master.Address
                            };
                            command.Parameters.Add(addressParam);

                            SqlParameter idMasterParam = new SqlParameter
                            {
                                ParameterName = "@idMaster",
                                SqlDbType = SqlDbType.Int
                            };
                            idMasterParam.Direction = ParameterDirection.Output;
                            command.Parameters.Add(idMasterParam);

                            int idMaster = (int)command.ExecuteScalar();

                            DataTable table = new DataTable();

                            table.Columns.Add("id_master", typeof(int));
                            table.Columns.Add("id_spec", typeof(int));
                            table.Columns.Add("char_spec", typeof(string));

                            foreach (var spec in master.Spec)
                            {
                                table.Rows.Add(idMaster, spec.Key, spec.Value);
                            }

                            sqlExpression = "sp_InsertMasterSpecialization";
                            command = new SqlCommand(sqlExpression, connection, transaction);
                            command.CommandType = CommandType.StoredProcedure;
                            
                            SqlParameter tmpTableParam = new SqlParameter
                            {
                                ParameterName = "@tmpTable",
                                SqlDbType = SqlDbType.Structured,
                                TypeName = "MasterSpecializationTableType",
                                Value = table,
                            };
                            command.Parameters.Add(tmpTableParam);

                            command.ExecuteNonQuery();

                            transaction.Commit();
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

        //todo
        public bool Update(Employee employee)
        {
            try
            {
                if (!HasSameType(employee, true))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Update Employee Set name_fs=(UPPER(LEFT(@faultStatus_name, 1))+ SUBSTRING (@faultStatus_name,2,len (@faultStatus_name))) Where id_fs=(@faultStatus_id);";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param = new SqlParameter();
                        param.ParameterName = "@faultStatus_id";
                        param.Value = employee.Id;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@faultStatus_name";
                        //param.Value = employee.Name;
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

        private bool HasSameType(Employee employee, bool isUpdate)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionDB.Connect();
                string sql = string.Format("Select count(id_emp) From Employee Where login='{0}' and pass='{1}'", employee.Login, employee.Password);
                if (isUpdate)
                    sql = string.Format("Select count(id_emp) From Employee Where Where login='{0}' and pass='{1}' AND id_emp!='{2}'", employee.Login, employee.Password, employee.Id);
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
