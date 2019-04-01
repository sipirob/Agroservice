using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.controller
{
    class DeleteUser
    {
        /// <summary>
        /// ügyfél törlése
        /// </summary>
        /// <param name="clientid">ügyfél azonosítója</param>
        internal static void deleteUser(int clientid)
        {
            MySqlConnection connection = new MySqlConnection(controller.Connection.connectionString);
            connection.Open();
            MySqlCommand cmdUpdate = new MySqlCommand();
            cmdUpdate.Connection = connection;
            cmdUpdate.CommandText = "DELETE FROM `client` WHERE `client`.`id` = @id";
            cmdUpdate.Parameters.AddWithValue("@Id", clientid);
            cmdUpdate.ExecuteNonQuery();
            connection.Close();
        }
    }
}
