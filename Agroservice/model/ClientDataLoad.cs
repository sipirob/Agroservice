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
    class ClientDataLoad
    {
        private static List<repository.Client> clients;

        public static List<Client> Clients { get => clients; set => clients = value; }

        public  ClientDataLoad()
        {
            Clients = new List<repository.Client>();
        } 

        public static void clientDataLoad()
        {
            try
            {
                loadClients();
            }
            catch(Exception e)
            {
                
            }
        }

        private static void loadClients()
        {
            ConnectToDatabase a = new ConnectToDatabase();
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            mdi = a.connect();
            mdi.open();
            string query = "SELECT `id`, `vezeteknev`, `kersztnev`, `lakhely`, `telefonszam` FROM `clientdata`";
            DataTable clientdt = new DataTable();
           clientdt = mdi.getToDataTable(query);
            loadClientList(clientdt);
            mdi.close();
        }

      

        private static void loadClientList(DataTable clientdt)
        {
            foreach (DataRow row in clientdt.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                string fname = row[1].ToString();
                string lname = row[2].ToString();
                string place = row[3].ToString();
                int tel = Convert.ToInt32(row[4]);
                repository.Client c = new repository.Client(id, fname, lname, place, tel);
                Clients.Add(c);
            }
        }
        public static DataTable getClientDataFromList()
        {
            DataTable clientDT = new DataTable();
            clientDT.Columns.Add("id", typeof(int));
            clientDT.Columns.Add("vezetéknév", typeof(string));
            clientDT.Columns.Add("keresztnev", typeof(string));
            clientDT.Columns.Add("lakhely", typeof(string));
            clientDT.Columns.Add("tel", typeof(int));
            foreach (repository.Client c in Clients)
            {
                clientDT.Rows.Add(c.getClientid(), c.getFirstname(), c.getLastname(), c.getPlace(), c.getTel());
            }
            return clientDT;

        }
    }
}
