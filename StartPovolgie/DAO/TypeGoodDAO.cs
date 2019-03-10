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
    public class TypeGoodDAO
    {
        public bool Insert(TypeGood type)
        {
            try
            {
                if (!HasSameType(type, false))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Insert into TypeGood (name_tg) values (UPPER(LEFT(@typeGood_name, 1))+ SUBSTRING (@typeGood_name,2,len (@typeGood_name))) ";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@typeGood_name";
                        param.Value = type.Name;
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

        public bool Update(TypeGood type)
        {
            try
            {
                if (!HasSameType(type, true))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Update TypeGood Set name_tg=(UPPER(LEFT(@typeGood_name, 1))+ SUBSTRING (@typeGood_name,2,len (@typeGood_name))) Where id_tg=(@typeGood_id);";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param = new SqlParameter();
                        param.ParameterName = "@typeGood_id";
                        param.Value = type.Id;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@typeGood_name";
                        param.Value = type.Name;
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

        private bool HasSameType(TypeGood typeGood, bool isUpdate)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionDB.Connect();
                string sql = string.Format("Select count(id_tg) From TypeGood Where UPPER(REPLACE(name_tg,' ',''))=UPPER(REPLACE('{0}',' ',''))", typeGood.Name);
                if (isUpdate)
                    sql = string.Format("Select count(id_tg) From TypeGood Where UPPER(REPLACE(name_tg,' ',''))=UPPER(REPLACE('{0}',' ','')) AND id_tg!='{1}'", typeGood.Name, typeGood.Id);
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
                string sql = string.Format("Delete From TypeGood Where id_tg= '{0}'", id);
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
