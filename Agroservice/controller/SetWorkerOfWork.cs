using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.controller
{
    class SetWorkerOfWork
    {
      
        internal static void setWorker(int workerId, int workId)
        {
          
                MySqlConnection connection = new MySqlConnection(controller.Connection.connectionString);
                connection.Open();
                MySqlCommand cmdUpdate = new MySqlCommand();
                cmdUpdate.Connection = connection;
                cmdUpdate.CommandText = "UPDATE `work` SET `workerid`=@workerId where work.id=@workId ";
                cmdUpdate.Parameters.AddWithValue("@workerId", workerId);
                cmdUpdate.Parameters.AddWithValue("@workId", workId);
                cmdUpdate.ExecuteNonQuery();
                connection.Close();
           
        }
    }
}
