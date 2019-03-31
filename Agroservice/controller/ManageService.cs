using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.controller
{
    class ManageService
    {
        /// <summary>
        /// Új szolgáltatás létrehozása adatbázisba
        /// </summary>
        /// <param name="servicename">szolgáltatás neve</param>
        /// <param name="servicePrice">szolgáltatás ára</param>
        internal static void getAddNewService(string servicename, int servicePrice)
        {

            MySqlConnection connection = new MySqlConnection(controller.Connection.connectionString);
            connection.Open();
            MySqlCommand cmdUpdate = new MySqlCommand();
            cmdUpdate.Connection = connection;
            cmdUpdate.CommandText = "INSERT INTO `service`( `name`, `price`) VALUES (@name,@price)";

            cmdUpdate.Parameters.AddWithValue("@name", servicename);
            cmdUpdate.Parameters.AddWithValue("@price", servicePrice);
            
            cmdUpdate.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// szolgáltatás törlése adatbázisból
        /// </summary>
        /// <param name="serviceid">szolgáltatás azonosítója</param>
        internal static void getDeleteService(int serviceid)
        {

            MySqlConnection connection = new MySqlConnection(controller.Connection.connectionString);
            connection.Open();
            MySqlCommand cmdUpdate = new MySqlCommand();
            cmdUpdate.Connection = connection;
            cmdUpdate.CommandText = "DELETE FROM `service` WHERE `service`.`id` = @id";

            cmdUpdate.Parameters.AddWithValue("@id", serviceid);
           

            cmdUpdate.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// szolgáltatás adatainak módosítása
        /// </summary>
        /// <param name="serviceid">kiválasztott szolgáltatás azonosítója</param>
        /// <param name="servicename">kiválasztott szolgáltatás neve</param>
        /// <param name="servicePrice">kiválasztott szolgáltatás ára</param>
        internal static void getUpdateService(int serviceid, string servicename, int servicePrice)
        {
            MySqlConnection connection = new MySqlConnection(controller.Connection.connectionString);
            connection.Open();
            MySqlCommand cmdUpdate = new MySqlCommand();
            cmdUpdate.Connection = connection;
            cmdUpdate.CommandText = "UPDATE `service` SET `name`=@name,`price`=@price WHERE id=@id ";

            cmdUpdate.Parameters.AddWithValue("@id", serviceid);
            cmdUpdate.Parameters.AddWithValue("@name", servicename);
            cmdUpdate.Parameters.AddWithValue("@price", servicePrice);
            cmdUpdate.ExecuteNonQuery();
            connection.Close();
        }

        
    }
}
