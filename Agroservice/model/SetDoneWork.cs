using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.model
{
    class SetDoneWork
    {
        internal static void setDoneWorkInDatabase(int workId)
        {
            MySqlConnection connection = new MySqlConnection(model.Connection.connectionString);
            connection.Open();
            MySqlCommand cmdUpdate = new MySqlCommand();
            cmdUpdate.Connection = connection;
            cmdUpdate.CommandText = "UPDATE `work` SET `done`=1 WHERE id=@Id";
            cmdUpdate.Parameters.AddWithValue("@Id", workId);
            cmdUpdate.ExecuteNonQuery();
            connection.Close();
        }
    }
}
