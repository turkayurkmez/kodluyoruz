using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    //DB'ye bağlanıp komut çalıştırmak senin sorumluluğun:
  public  class DBHelper
    {

        SqlConnection sqlConnection = null;
        public DBHelper(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int Execute(string commandText, Dictionary<string, object> parameters)
        {
            var command = CreateSqlCommand(commandText, parameters);
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }

        private SqlCommand CreateSqlCommand(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = commandText;
            AddParametersToCommand(command, parameters);
            return command;
        }

        private void AddParametersToCommand(SqlCommand command, Dictionary<string, object> parameters)
        {
            foreach (var item in parameters)
            {
                command.Parameters.AddWithValue(item.Key, item.Value);
            }
        }

    }
}
