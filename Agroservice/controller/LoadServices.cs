using Agroservice.repository;
using MysSqlDataGridViewHalak;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.controller
{
    class LoadServices
    {
      
        private static List<repository.Service> Services;

        public LoadServices()
        {
            Services = new List<repository.Service>();
        }

        public static void serviceDataLoad()
        {
            try
            {

                loadServicedata();
            }
            catch (Exception e)
            {

            }
        }

        private static void loadServicedata()
        {
            ConnectToDatabase a = new ConnectToDatabase();
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            mdi = a.connect();
            mdi.open();
            string query = "SELECT * from service ";
            DataTable servicedt = new DataTable();
            servicedt = mdi.getToDataTable(query);
            loadServiceList(servicedt);
            mdi.close();
        }

        private static void loadServiceList(DataTable servicedt)
        {
            foreach (DataRow row in servicedt.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                string servicename =(row[1]).ToString();
                int price = Convert.ToInt32(row[2]);
                
                repository.Service s = new repository.Service(id, servicename, price);

                Services.Add(s);
            }

        }
        public static DataTable getServiceData()
        {
            DataTable sname = new DataTable();
            sname.Columns.Add("id", typeof(int));
            sname.Columns.Add("name", typeof(string));
            sname.Columns.Add("price", typeof(int));
            foreach (Service s in Services)
            {
                sname.Rows.Add(s.getId(), s.getName(), s.getPrice());
            }
            return sname;
        }
        /// <summary>
        /// kiválasztott szolgáltatás adatainak eltárolása adattáblába
        /// </summary>
        /// <param name="serviceid">kiválasztott szolgáltatás azonosítója</param>
        /// <returns>kiválasztott szolgáltatás adatainak adattáblája</returns>
        internal static DataTable selectedServicenameData(int serviceid)
        {
            DataTable sname = new DataTable();
            sname.Columns.Add("id", typeof(int));
            sname.Columns.Add("name", typeof(string));
            sname.Columns.Add("price", typeof(int));
            foreach (Service s in Services)
            { if(s.getId()==serviceid)
                sname.Rows.Add(s.getId(), s.getName(), s.getPrice());
            }
            return sname;
        }
        /// <summary>
        /// Service lista kiürítése
        /// </summary>
        internal static void clearServiceList()
        {
            Services.Clear();
        }
    }
}
