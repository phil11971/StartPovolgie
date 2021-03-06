﻿using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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
                    string sql = "Insert into SparePart (name_sp, desc_sp, quantity, price) values (UPPER(LEFT(@sparePart_name, 1))+ SUBSTRING (@sparePart_name,2,len (@sparePart_name)), @sparePart_desc, @sparePart_quantity, @sparePart_price) ";

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
                        param.Value = sparePart.Cnt;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@sparePart_price";
                        param.Value = sparePart.Price;
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

        public bool Update(SparePart sparePart)
        {
            try
            {
                if (!HasSameType(sparePart, true))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Update SparePart Set name_sp=(UPPER(LEFT(@sparePart_name, 1))+ SUBSTRING (@sparePart_name,2,len (@sparePart_name))), desc_sp=@sparePart_desc, quantity=@sparePart_quantity, price=@sparePart_price Where id_sp=(@sparePart_id_sp);";

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
                        param.Value = sparePart.Cnt;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@sparePart_price";
                        param.Value = sparePart.Price;
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

        public bool UpdateQuantity(List<SparePart> spareParts)
        {
            try
            {
                using (SqlConnection connection = ConnectionDB.Connect())
                {
                    DataTable table = new DataTable();

                    table.Columns.Add("id_sp", typeof(int));
                    table.Columns.Add("quantity", typeof(int));

                    foreach (var sp in spareParts)
                    {
                        table.Rows.Add(sp.IdSparePart, sp.Cnt);
                    }

                    string sqlExpression = "sp_UpdateSparePart";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter tmpTableParam = new SqlParameter
                    {
                        ParameterName = "@tmpTable",
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "SparePartUpdateTableType",
                        Value = table,
                    };
                    command.Parameters.Add(tmpTableParam);

                    command.ExecuteNonQuery();

                }
                return true;
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
                string sql = string.Format("Select count(id_sp) From SparePart Where id_sp='{0}'", sparePart.IdSparePart);
                if (isUpdate)
                    sql = string.Format("Select count(id_sp) From SparePart Where UPPER(REPLACE(name_sp,' ',''))=UPPER(REPLACE('{0}',' ','')) AND desc_sp='{1}' AND quantity={2} AND price={3} AND id_sp!='{4}'", sparePart.Name, sparePart.Desc, sparePart.Cnt, sparePart.Price.ToString("F01", new CultureInfo("en-us")), sparePart.IdSparePart);
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
