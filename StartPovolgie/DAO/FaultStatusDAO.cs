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
    public class FaultStatusDAO
    {
        public bool Insert(FaultStatus faultStatus)
        {
            try
            {
                if (!HasSameType(faultStatus, false))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Insert into FaultStatus (name_fs) values (UPPER(LEFT(@faultStatus_name, 1))+ SUBSTRING (@faultStatus_name,2,len (@faultStatus_name))) ";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@faultStatus_name";
                        param.Value = faultStatus.Name;
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

        public bool Update(FaultStatus faultStatus)
        {
            try
            {
                if (!HasSameType(faultStatus, true))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Update FaultStatus Set name_fs=(UPPER(LEFT(@faultStatus_name, 1))+ SUBSTRING (@faultStatus_name,2,len (@faultStatus_name))) Where id_fs=(@faultStatus_id);";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param = new SqlParameter();
                        param.ParameterName = "@faultStatus_id";
                        param.Value = faultStatus.Id;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@faultStatus_name";
                        param.Value = faultStatus.Name;
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

        private bool HasSameType(FaultStatus faultStatus, bool isUpdate)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionDB.Connect();
                string sql = string.Format("Select count(id_fs) From FaultStatus Where UPPER(REPLACE(name_fs,' ',''))=UPPER(REPLACE('{0}',' ',''))", faultStatus.Name);
                if (isUpdate)
                    sql = string.Format("Select count(id_fs) From FaultStatus Where UPPER(REPLACE(name_fs,' ',''))=UPPER(REPLACE('{0}',' ','')) AND id_fs!='{1}'", faultStatus.Name, faultStatus.Id);
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
                string sql = string.Format("Delete From FaultStatus Where id_fs= '{0}'", id);
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
