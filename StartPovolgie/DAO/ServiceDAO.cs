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
    public class ServiceDAO
    {
        public bool Insert(Service service)
        {
            try
            {
                if (!HasSameType(service, false))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Insert into Service (name_service, price, id_ts) values (UPPER(LEFT(@service_name, 1))+ SUBSTRING (@service_name,2,len (@service_name)), @service_price, @service_id_ts) ";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@service_name";
                        param.Value = service.Name;
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Size = 100;
                        cmd.Parameters.Add(param);

                        param.ParameterName = "@service_price";
                        param.Value = service.Price;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param.ParameterName = "@service_id_ts";
                        param.Value = service.IdTS;
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

        public bool Update(Service service)
        {
            try
            {
                if (!HasSameType(service, true))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Update Service Set name_service=(UPPER(LEFT(@service_name, 1))+ SUBSTRING (@service_name,2,len (@service_name))), price=@service_price, id_ts=@service_id_ts Where id_service=(@service_id);";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param = new SqlParameter();
                        param.ParameterName = "@service_id";
                        param.Value = service.IdService;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@service_name";
                        param.Value = service.Name;
                        param.SqlDbType = SqlDbType.VarChar;
                        param.Size = 100;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@service_price";
                        param.Value = service.Price;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@service_id_ts";
                        param.Value = service.TypeService.Id;
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

        private bool HasSameType(Service service, bool isUpdate)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionDB.Connect();
                string sql = string.Format("Select count(id_service) From Service Where UPPER(REPLACE(name_service,' ',''))=UPPER(REPLACE('{0}',' ','')) AND price='{1}' AND id_ts='{2}'", service.Name, service.Price, service.TypeService.Id);
                if (isUpdate)
                    sql = string.Format("Select count(id_service) From Service Where UPPER(REPLACE(name_service,' ',''))=UPPER(REPLACE('{0}',' ','')) AND price='{1}' AND id_ts='{2}' AND id_service!='{3}'", service.Name, service.Price, service.TypeService.Id, service.IdService);
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
                string sql = string.Format("Delete From Service Where id_service= '{0}'", id);
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
