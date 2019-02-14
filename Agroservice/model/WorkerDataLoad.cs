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
    class WorkerDataLoad
    {
        private static List<Worker> Workers;

        public WorkerDataLoad()
        {
            Workers = new List<Worker>();
        }
        
        public static void workerDataLoad()
        {
            try
            {
                loadWorkers();
            }
            catch (Exception e)
            {

            }
        }

        private static void loadWorkers()
        {
            ConnectToDatabase a = new ConnectToDatabase();
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            mdi = a.connect();
            mdi.open();
            string query = "SELECT `id`,`vezeteknev`,`keresztnev`,`szulido`,`lakhely`,`telefonszam` FROM `workerdata`";
            DataTable workerdt = new DataTable();
            workerdt = mdi.getToDataTable(query);
            loadWorkerList(workerdt);
            mdi.close();
        }

       

        private static void loadWorkerList(DataTable workerdt)
        {
           foreach(DataRow row in workerdt.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                string fname = row[1].ToString();
                string lname = row[2].ToString();
                DateTime bday = Convert.ToDateTime(row[3]);
                string place = row[4].ToString();
                int tel = Convert.ToInt32(row[5]);
                Worker w = new Worker(id, fname, lname, bday, place, tel);
                Workers.Add(w);
            }
        }
        internal static DataTable getWorkerDataFromList()
        {
            DataTable workerDT = new DataTable();
            workerDT.Columns.Add("id", typeof(int));
            workerDT.Columns.Add("vezetéknév", typeof(string));
            workerDT.Columns.Add("keresztnév", typeof(string));
            workerDT.Columns.Add("születési idő", typeof(DateTime));
            workerDT.Columns.Add("lakhely", typeof(string));
            workerDT.Columns.Add("telefonszám", typeof(int));
            foreach(Worker w in Workers)
            {
                workerDT.Rows.Add(w.getWorkerid(), w.getFirstname(), w.getLastname(), w.getBirtday(), w.getPlace(), w.getTel());
            }
            return workerDT;
        }
    }
}
