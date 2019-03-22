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
    public class SparePartDAO
    {
        public bool Insert(SparePart sparePart)
        {
            try
            {
                if (!HasSameType(sparePart, false))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Insert into SparePart (name_sp, desc_sp, quantity, price, id_sps) values (UPPER(LEFT(@sparePart_name, 1))+ SUBSTRING (@sparePart_name,2,len (@sparePart_name)), @sparePart_desc, @sparePart_quantity, @sparePart_price, @sparePart_id_sps) ";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@sparePart_name";
                        param.Value = sparePart.Name;
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Size = 100;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@sparePart_desc";
                        param.Value = sparePart.Desc;
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Size = 100;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@sparePart_quantity";
                        param.Value = sparePart.Price;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@sparePart_price";
                        param.Value = sparePart.Price;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@sparePart_id_sps";
                        param.Value = sparePart.SparePartStatus.Id;
                        param.SqlDbType = SqlDbType.Int;
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

        public bool Update(SparePart sparePart)
        {
            try
            {
                if (!HasSameType(sparePart, true))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Update SparePart Set name_sp=(UPPER(LEFT(@sparePart_name, 1))+ SUBSTRING (@sparePart_name,2,len (@sparePart_name))), desc_sp=@sparePart_desc, quantity=@sparePart_quantity, price=@sparePart_price, id_sps=@sparePart_id_sps Where id_sp=(@sparePart_id_sp);";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param = new SqlParameter();
                        param.ParameterName = "@sparePart_id_sp";
                        param.Value = sparePart.IdSparePart;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@sparePart_name";
                        param.Value = sparePart.Name;
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Size = 100;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@sparePart_desc";
                        param.Value = sparePart.Desc;
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Size = 100;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@sparePart_quantity";
                        param.Value = sparePart.Price;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@service_price";
                        param.Value = sparePart.Price;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@sparePart_id_sps";
                        param.Value = sparePart.SparePartStatus.Id;
                        param.SqlDbType = SqlDbType.Int;
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

        private bool HasSameType(SparePart sparePart, bool isUpdate)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionDB.Connect();
                string sql = string.Format("Select count(id_sp) From SparePart Where UPPER(REPLACE(name_sp,' ',''))=UPPER(REPLACE('{0}',' ','')) AND desc_sp='{1}' AND quantity='{2}' AND price='{3}' AND id_sps='{4}'", sparePart.Name, sparePart.Desc, sparePart.Cnt, sparePart.Price, sparePart.SparePartStatus.Id);
                if (isUpdate)
                    sql = string.Format("Select count(id_sp) From SparePart Where UPPER(REPLACE(name_sp,' ',''))=UPPER(REPLACE('{0}',' ','')) AND desc_sp='{1}' AND quantity='{2}' AND price='{3}' AND id_sps='{4}' AND id_sp!='{5}'", sparePart.Name, sparePart.Desc, sparePart.Cnt, sparePart.Price, sparePart.SparePartStatus.Id, sparePart.IdSparePart);
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
                string sql = string.Format("Delete From SparePart Where id_sp= '{0}'", id);
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
