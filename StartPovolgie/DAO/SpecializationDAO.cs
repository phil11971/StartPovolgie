﻿using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.DAO
{
    public class SpecializationDAO
    {
        public bool Insert(Specialization specialization)
        {
            try
            {
                if (!HasSameType(specialization, false))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Insert into Specialization (name_spec) values (UPPER(LEFT(@specialization_name, 1))+ SUBSTRING (@specialization_name,2,len (@specialization_name))) ";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@specialization_name";
                        param.Value = specialization.Name;
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

        public bool Update(Specialization specialization)
        {
            try
            {
                if (!HasSameType(specialization, true))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Update Specialization Set name_spec=(UPPER(LEFT(@specialization_name, 1))+ SUBSTRING (@specialization_name,2,len (@specialization_name))) Where id_spec=(@specialization_id);";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param = new SqlParameter();
                        param.ParameterName = "@specialization_id";
                        param.Value = specialization.Id;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@specialization_name";
                        param.Value = specialization.Name;
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

        private bool HasSameType(Specialization specialization, bool isUpdate)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionDB.Connect();
                string sql = string.Format("Select count(id_spec) From Specialization Where UPPER(REPLACE(name_spec,' ',''))=UPPER(REPLACE('{0}',' ',''))", specialization.Name);
                if (isUpdate)
                    sql = string.Format("Select count(id_spec) From Specialization Where UPPER(REPLACE(name_spec,' ',''))=UPPER(REPLACE('{0}',' ','')) AND id_spec!='{1}'", specialization.Name, specialization.Id);
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
                string sql = string.Format("Delete From Specialization Where id_spec= '{0}'", id);
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
