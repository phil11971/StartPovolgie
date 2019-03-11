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
    public class WorkStatusDAO
    {
        public bool Insert(WorkStatus workStatus)
        {
            try
            {
                if (!HasSameType(workStatus, false))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Insert into WorkStatus (name_ws) values (UPPER(LEFT(@workStatus_name, 1))+ SUBSTRING (@workStatus_name,2,len (@workStatus_name))) ";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@workStatus_name";
                        param.Value = workStatus.Name;
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

        public bool Update(WorkStatus workStatus)
        {
            try
            {
                if (!HasSameType(workStatus, true))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Update WorkStatus Set name_ws=(UPPER(LEFT(@workStatus_name, 1))+ SUBSTRING (@workStatus_name,2,len (@workStatus_name))) Where id_ws=(@workStatus_id);";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param = new SqlParameter();
                        param.ParameterName = "@workStatus_id";
                        param.Value = workStatus.Id;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@workStatus_name";
                        param.Value = workStatus.Name;
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

        private bool HasSameType(WorkStatus workStatus, bool isUpdate)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionDB.Connect();
                string sql = string.Format("Select count(id_ws) From WorkStatus Where UPPER(REPLACE(name_ws,' ',''))=UPPER(REPLACE('{0}',' ',''))", workStatus.Name);
                if (isUpdate)
                    sql = string.Format("Select count(id_ws) From WorkStatus Where UPPER(REPLACE(name_ws,' ',''))=UPPER(REPLACE('{0}',' ','')) AND id_ws!='{1}'", workStatus.Name, workStatus.Id);
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
                string sql = string.Format("Delete From WorkStatus Where id_ws= '{0}'", id);
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
