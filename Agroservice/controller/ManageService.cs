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
