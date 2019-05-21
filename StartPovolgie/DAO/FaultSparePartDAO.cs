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
    public class FaultSparePartDAO
    {
        public bool Insert(FaultSparePart faultSparePart)
        {
            try
            {
                using (SqlConnection connection = ConnectionDB.Connect())
                {
                    DataTable table = new DataTable();

                    table.Columns.Add("id_fault", typeof(int));
                    table.Columns.Add("id_sp", typeof(int));
                    table.Columns.Add("quantity", typeof(int));
                    table.Columns.Add("price", typeof(float));

                    foreach (var fault in faultSparePart.SpareParts)
                    {
                        table.Rows.Add(faultSparePart.IdFault, fault.IdSparePart, fault.Cnt, fault.Price);
                    }

                    string sqlExpression = "sp_InsertFaultSparePart";
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter tmpTableParam = new SqlParameter
                    {
                        ParameterName = "@tmpTable",
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "FaultSparePartTableType",
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

        public void DeleteById(int idFault, int idSparePart)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionDB.Connect();
                string sql = string.Format("Delete From FaultSparePart Where id_fault='{0}' and id_sp='{1}'", idFault, idSparePart);
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
