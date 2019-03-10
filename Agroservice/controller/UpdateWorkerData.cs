using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.controller
{
    class UpdateWorkerData
    {
        internal static void updateWorkerData(int workerid, string workerName, DateTime workerBirthday, string workerPlace, int workerTelnumb)
        {
            MySqlConnection connection = new MySqlConnection(controller.Connection.connectionString);
            connection.Open();
            MySqlCommand cmdUpdate = new MySqlCommand();
            cmdUpdate.Connection = connection;
            cmdUpdate.CommandText = "UPDATE `workerdata` SET `name`=@name,`lakhely`=@place,`telefonszam`=@telnumb,`szulido`=@bday WHERE workerdata.id=@Id";
            cmdUpdate.Parameters.AddWithValue("@Id", workerid);
            cmdUpdate.Parameters.AddWithValue("@name", workerName);
            cmdUpdate.Parameters.AddWithValue("@place", workerPlace);
            cmdUpdate.Parameters.AddWithValue("@telnumb", workerTelnumb);
            cmdUpdate.Parameters.AddWithValue("@bday", workerBirthday);
            cmdUpdate.ExecuteNonQuery();
            connection.Close();
        }
    }
}
