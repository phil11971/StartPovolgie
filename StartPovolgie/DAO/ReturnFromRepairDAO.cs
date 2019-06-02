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
    public class ReturnFromRepairDAO
    {
        public bool Insert(ReturnFromRepair returnFromRepair)
        {
            try
            {
                if (!HasSameType(returnFromRepair))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Insert into ReturnFromRepair (id_return, desc_job, issue_date, amount_repair, total) values (@id_return, @desc_job, @issue_date, @amount_repair, @total)";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@id_return";
                        param.Value = returnFromRepair.Id;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@desc_job";
                        param.Value = returnFromRepair.Desc;
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Size = 100;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@issue_date";
                        param.Value = returnFromRepair.IssueDate;
                        param.SqlDbType = SqlDbType.Date;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@amount_repair";
                        param.Value = returnFromRepair.AmountRepair;
                        param.SqlDbType = SqlDbType.Float;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@total";
                        param.Value = returnFromRepair.Total;
                        param.SqlDbType = SqlDbType.Float;
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

        //todo
        public bool Update(ReturnFromRepair returnFromRepair)
        {
            try
            {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Update ReturnFromRepair Set desc_job=@desc_job, issue_date=@issue_date, amount_repair=@amount_repair, total=@total Where id_return=(@id_return);";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param = new SqlParameter();
                        param.ParameterName = "@id_return";
                        param.Value = returnFromRepair.Id;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@desc_job";
                        param.Value = returnFromRepair.Desc;
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Size = 100;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@issue_date";
                        param.Value = returnFromRepair.IssueDate;
                        param.SqlDbType = SqlDbType.Date;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@amount_repair";
                        param.Value = returnFromRepair.AmountRepair;
                        param.SqlDbType = SqlDbType.Float;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@total";
                        param.Value = returnFromRepair.Total;
                        param.SqlDbType = SqlDbType.Float;
                        cmd.Parameters.Add(param);

                        cmd.ExecuteNonQuery();
                    }
                    ConnectionDB.Disconnect(sqlConnection);
                    return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private bool HasSameType(ReturnFromRepair returnFromRepair)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionDB.Connect();
                string sql = string.Format("Select count(id_return) From ReturnFromRepair Where id_return='{0}'", returnFromRepair.Id);
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
                else return false;
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
                string sql = string.Format("Delete From ReturnFromRepair Where id_return='{0}'", id);
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.ExecuteNonQuery();
                ConnectionDB.Disconnect(sqlConnection);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool HasServiceInPeriod(DateTime dateS, DateTime datePo)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionDB.Connect();
                string strDateS = dateS.Year + "-" + dateS.Month + "-" + dateS.Day;
                string strDatePo = datePo.Year + "-" + datePo.Month + "-" + datePo.Day;
                string sql = string.Format("SELECT count(id_return) From ReturnFromRepair rfr Where rfr.issue_date BETWEEN '{0}' AND '{1}'", strDateS, strDatePo);
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandText = sql;
                int count = -1;
                count = Convert.ToInt32(cmd.ExecuteScalar());
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
    }
}
