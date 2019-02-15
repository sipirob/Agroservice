using Agroservice.repository;
using MysSqlDataGridViewHalak;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.model
{
    class LoadUsername
    {
        private static List<Worker> Workers;

        public LoadUsername()
        {
            Workers = new List<Worker>();
        }

        public static void workerDataLoad()
        {
            try
            {

                loadUsername();
            }
            catch (Exception e)
            {

            }
        }

        private static void loadUsername()
        {
            ConnectToDatabase a = new ConnectToDatabase();
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            mdi = a.connect();
            mdi.open();
            string query = "SELECT workerdata.id,`name`,`szulido`,`lakhely`,`telefonszam` FROM `workerdata`, worker where worker.id=workerdata.id and worker.username = '" + FormSignIn.username + "'";
            DataTable workerdt = new DataTable();
            workerdt = mdi.getToDataTable(query);
            loadWorkerList(workerdt);
            mdi.close();
        }
        /// <summary>
        /// A belépet felhasználó nevének lekérése
        /// </summary>
        /// <returns>Belépett felhasználó neve</returns>
        internal static string getUsername()
        {
            string username = "";
            foreach (Worker w in Workers)
            {
                username = w.getName();
            }
            Workers.Clear();
            return username;
        }

        private static void loadWorkerList(DataTable workerdt)
        {
            foreach (DataRow row in workerdt.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                string name = row[1].ToString();
                DateTime bday = Convert.ToDateTime(row[2]);
                string place = row[3].ToString();
                int tel = Convert.ToInt32(row[4]);
                Worker w = new Worker(id, name, bday, place, tel);
                Workers.Add(w);
            }

        }
    }
}
