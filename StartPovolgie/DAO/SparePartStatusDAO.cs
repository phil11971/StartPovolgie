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
    public class SparePartStatusDAO
    {
        public bool Insert(SparePartStatus sparePartStatus)
        {
            try
            {
                if (!HasSameType(sparePartStatus, false))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Insert into SparePartStatus (name_sps) values (UPPER(LEFT(@sparePartStatus_name, 1))+ SUBSTRING (@sparePartStatus_name,2,len (@sparePartStatus_name))) ";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@sparePartStatus_name";
                        param.Value = sparePartStatus.Name;
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

        public bool Update(SparePartStatus sparePartStatus)
        {
            try
            {
                if (!HasSameType(sparePartStatus, true))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Update SparePartStatus Set name_sps=(UPPER(LEFT(@sparePartStatus_name, 1))+ SUBSTRING (@sparePartStatus_name,2,len (@sparePartStatus_name))) Where id_sps=(@sparePartStatus_id);";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param = new SqlParameter();
                        param.ParameterName = "@sparePartStatus_id";
                        param.Value = sparePartStatus.Id;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@sparePartStatus_name";
                        param.Value = sparePartStatus.Name;
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

        private bool HasSameType(SparePartStatus sparePartStatus, bool isUpdate)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionDB.Connect();
                string sql = string.Format("Select count(id_sps) From SparePartStatus Where UPPER(REPLACE(name_sps,' ',''))=UPPER(REPLACE('{0}',' ',''))", sparePartStatus.Name);
                if (isUpdate)
                    sql = string.Format("Select count(id_sps) From SparePartStatus Where UPPER(REPLACE(name_sps,' ',''))=UPPER(REPLACE('{0}',' ','')) AND id_sps!='{1}'", sparePartStatus.Name, sparePartStatus.Id);
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
                string sql = string.Format("Delete From SparePartStatus Where id_sps= '{0}'", id);
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
