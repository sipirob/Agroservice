using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.controller
{
    class LastWorkerId
    {
        /// <summary>
        /// az utolsó regisztrált dolgozó azonosítójának meghatározása
        /// </summary>
        /// <returns>dolgozó azonosítója</returns>
        public int searchLastWorkerId()
        {
            int id = 0;
            MySqlConnection connection = new MySqlConnection(controller.Connection.connectionString);
            string query;
            query = "SELECT `id` FROM `workerdata` order BY id desc limit 1";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader dr;

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id =Convert.ToInt32(dr[0]);
            }

            dr.Close();
            connection.Close();
            return id;
        }
    }
}
