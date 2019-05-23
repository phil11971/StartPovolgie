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
    public class FaultDAO
    {
        //todo
        public bool Insert(Fault fault)
        {
            return true;
        }

        public bool Update(List<Fault> faults)
        {
            try
            {
                using (SqlConnection connection = ConnectionDB.Connect())
                {
                    DataTable table = new DataTable();

                    table.Columns.Add("id_fault", typeof(int));
                    table.Columns.Add("cost_elimination", typeof(float));

                    foreach (var fault in faults)
                    {
                        table.Rows.Add(fault.Id, fault.CostElim);
                    }

                    string sqlExpression = "sp_UpdateFault";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter tmpTableParam = new SqlParameter
                    {
                        ParameterName = "@tmpTable",
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "FaultUpdateTableType",
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

        public void DeleteById(int id)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionDB.Connect();
                string sql = string.Format("Delete From Fault Where id_fault='{0}'", id);
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
