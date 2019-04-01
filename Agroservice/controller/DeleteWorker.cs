using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.controller
{
    class DeleteWorker
    {

        /// <summary>
        /// dolgozó törlése
        /// </summary>
        /// <param name="workerid">dolgozó azonosítója</param>
        internal static void deleteWorker(int workerid)
        {
            MySqlConnection connection = new MySqlConnection(controller.Connection.connectionString);
            connection.Open();
            MySqlCommand cmdUpdate = new MySqlCommand();
            cmdUpdate.Connection = connection;
            cmdUpdate.CommandText = "DELETE FROM `worker` WHERE `worker`.`id` = @id";
            cmdUpdate.Parameters.AddWithValue("@Id", workerid);
            cmdUpdate.ExecuteNonQuery();
            connection.Close();
            
        }
    }
}
