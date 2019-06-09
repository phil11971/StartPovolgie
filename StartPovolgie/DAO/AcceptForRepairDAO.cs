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
    public class AcceptForRepairDAO
    {
        public bool Insert(AcceptForRepair acceptForRepair, out int idAccept)
        {
            try
            {

                using (SqlConnection connection = ConnectionDB.Connect())
                {
                    SqlTransaction transaction = connection.BeginTransaction();
                    string sqlExpression = "sp_InsertClientGoodAndAcceptForRepair";

                    SqlCommand command = new SqlCommand(sqlExpression, connection, transaction);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter idClientParam = new SqlParameter
                    {
                        ParameterName = "@id_client",
                        Value = acceptForRepair.IdClient
                    };
                    command.Parameters.Add(idClientParam);

                    SqlParameter idGoodParam = new SqlParameter
                    {
                        ParameterName = "@id_g",
                        Value = acceptForRepair.IdGood
                    };
                    command.Parameters.Add(idGoodParam);

                    SqlParameter idAdminParam = new SqlParameter
                    {
                        ParameterName = "@id_admin",
                        Value = acceptForRepair.IdAdmin
                    };
                    command.Parameters.Add(idAdminParam);

                    SqlParameter equipmentParam = new SqlParameter
                    {
                        ParameterName = "@equipment",
                        Value = acceptForRepair.Equipment
                    };
                    command.Parameters.Add(equipmentParam);

                    SqlParameter mechanicalDamageParam = new SqlParameter
                    {
                        ParameterName = "@mechanical_damage",
                        Value = acceptForRepair.MechanicalDamage
                    };
                    command.Parameters.Add(mechanicalDamageParam);

                    SqlParameter receiptDateParam = new SqlParameter
                    {
                        ParameterName = "@receipt_date",
                        Value = acceptForRepair.ReceiptDate
                    };
                    command.Parameters.Add(receiptDateParam);

                    SqlParameter commentParam = new SqlParameter
                    {
                        ParameterName = "@additionally",
                        Value = acceptForRepair.Сomment
                    };
                    command.Parameters.Add(commentParam);

                    SqlParameter idAcceptParam = new SqlParameter
                    {
                        ParameterName = "@idAccept",
                        SqlDbType = SqlDbType.Int
                    };
                    idAcceptParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(idAcceptParam);

                    idAccept = (int)command.ExecuteScalar();

                    DataTable table = new DataTable();

                    table.Columns.Add("desc_fault", typeof(string));
                    table.Columns.Add("id_accept", typeof(int));


                    foreach (var fault in acceptForRepair.Faults)
                    {
                        table.Rows.Add(fault.Desc, idAccept);
                    }

                    sqlExpression = "sp_InsertFaults";
                    command = new SqlCommand(sqlExpression, connection, transaction);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter tmpTableParam = new SqlParameter
                    {
                        ParameterName = "@tmpTable",
                        SqlDbType = SqlDbType.Structured,
                        TypeName = "FaultTableType",
                        Value = table,
                    };
                    command.Parameters.Add(tmpTableParam);

                    command.ExecuteNonQuery();

                    transaction.Commit();
                }
                return true;
            }
            catch (SqlException ex)
            {
                idAccept = 0;
                return false;
            }
        }

        //todo
        public bool Update(AcceptForRepair acceptForRepair)
        {
            try
            {
                if (!HasSameType(acceptForRepair))
                {
                    SqlConnection sqlConnection = ConnectionDB.Connect();
                    string sql = "Update Employee Set name_fs=(UPPER(LEFT(@faultStatus_name, 1))+ SUBSTRING (@faultStatus_name,2,len (@faultStatus_name))) Where id_fs=(@faultStatus_id);";

                    using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                    {
                        SqlParameter param = new SqlParameter();
                        param = new SqlParameter();
                        param.ParameterName = "@faultStatus_id";
                        param.Value = acceptForRepair.Id;
                        param.SqlDbType = SqlDbType.Int;
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@faultStatus_name";
                        //param.Value = employee.Name;
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

        private bool HasSameType(AcceptForRepair acceptForRepair)
        {
            try
            {
                SqlConnection sqlConnection = ConnectionDB.Connect();
                //TODO
                string sql = string.Format("Select count(id_accept) From AcceptForRepair Where Where equipment='{0}' and mechanical_damage='{1}' and receipt_date='{2}' and additionally='{3}' and id_client='{4}' and id_g='{5}' and id_admin='{6}' AND id_accept!='{7}'", acceptForRepair.Equipment, acceptForRepair.MechanicalDamage, acceptForRepair.ReceiptDate, acceptForRepair.Сomment, acceptForRepair.IdClient, acceptForRepair.IdGood, acceptForRepair.IdAdmin, acceptForRepair.Id);
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
                string sql = string.Format("Delete From AcceptForRepair Where id_accept='{0}'", id);
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
