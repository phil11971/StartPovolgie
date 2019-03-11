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
    public class TypeServiceDAO
    {
        public bool Insert(TypeService typeService)
        {
            try
            {
                if (!HasSameType(typeService, false))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Insert into TypeService (name_ts) values (UPPER(LEFT(@typeService_name, 1))+ SUBSTRING (@typeService_name,2,len (@typeService_name))) ";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@typeService_name";
                        param.Value = typeService.Name;
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

        public bool Update(TypeService typeService)
        {
            try
            {
                if (!HasSameType(typeService, true))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Update TypeService Set name_ts=(UPPER(LEFT(@typeService_name, 1))+ SUBSTRING (@typeService_name,2,len (@typeService_name))) Where id_ts=(@typeService_id);";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param = new SqlParameter();
                        param.ParameterName = "@typeService_id";
                        param.Value = typeService.Id;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@typeService_name";
                        param.Value = typeService.Name;
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

        private bool HasSameType(TypeService typeService, bool isUpdate)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionDB.Connect();
                string sql = string.Format("Select count(id_ts) From TypeService Where UPPER(REPLACE(name_ts,' ',''))=UPPER(REPLACE('{0}',' ',''))", typeService.Name);
                if (isUpdate)
                    sql = string.Format("Select count(id_ts) From TypeService Where UPPER(REPLACE(name_ts,' ',''))=UPPER(REPLACE('{0}',' ','')) AND id_ts!='{1}'", typeService.Name, typeService.Id);
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
                string sql = string.Format("Delete From TypeService Where id_ts= '{0}'", id);
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
