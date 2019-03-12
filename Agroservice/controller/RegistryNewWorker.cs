using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.controller
{
    class RegistryNewWorker
    {
        internal void setNewWorkerData(string workerName, DateTime workerBirthday, string workerPlace, int workerTelnumb)
        {
            MySqlConnection connection = new MySqlConnection(controller.Connection.connectionString);
            connection.Open();
            MySqlCommand cmdUpdate = new MySqlCommand();
            cmdUpdate.Connection = connection;
            cmdUpdate.CommandText = "INSERT INTO `workerdata`( `name`, `lakhely`, `telefonszam`, `szulido`) VALUES (@name,@place,@telnumb,@bday)";
           
            cmdUpdate.Parameters.AddWithValue("@name", workerName);
            cmdUpdate.Parameters.AddWithValue("@place", workerPlace);
            cmdUpdate.Parameters.AddWithValue("@telnumb", workerTelnumb);
            cmdUpdate.Parameters.AddWithValue("@bday", workerBirthday);
            cmdUpdate.ExecuteNonQuery();
            connection.Close();
        }

        internal void insertNewWorker(int newWorkerId, string username, string password, int category)
        {
            MySqlConnection connection = new MySqlConnection(controller.Connection.connectionString);
            connection.Open();
            MySqlCommand cmdUpdate = new MySqlCommand();
            cmdUpdate.Connection = connection;
            cmdUpdate.CommandText = "INSERT INTO `worker`(`id`, `username`, `password`, `categoryId`) VALUES (@id, @username,@password,@category)";

            cmdUpdate.Parameters.AddWithValue("@id", newWorkerId);
            cmdUpdate.Parameters.AddWithValue("@username", username);
            cmdUpdate.Parameters.AddWithValue("@password", password);
            cmdUpdate.Parameters.AddWithValue("@category", category);
            cmdUpdate.ExecuteNonQuery();
            connection.Close();
        }
    }
}
