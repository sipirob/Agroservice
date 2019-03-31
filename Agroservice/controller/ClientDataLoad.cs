using Agroservice.repository;
using MysSqlDataGridViewHalak;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agroservice.controller
{
    class ClientDataLoad
    {
        private static List<repository.Client> Clients;

       // public static List<Client> Clients { get => clients; set => clients = value; }

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
            string query = "SELECT `id`, `name`, `lakhely`, `telefonszam` FROM `clientdata`";
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
                string name = row[1].ToString();
                string place = row[2].ToString();
                int tel = Convert.ToInt32(row[3]);
                repository.Client c = new repository.Client(id, name, place, tel);
                Clients.Add(c);
            }
        }
        public static DataTable getClientDataFromList()
        {
            
            DataTable clientDT = new DataTable();
            clientDT.Columns.Add("id", typeof(int));
            clientDT.Columns.Add("név", typeof(string));
            clientDT.Columns.Add("lakhely", typeof(string));
            clientDT.Columns.Add("telefonszám", typeof(int));
            foreach (repository.Client c in Clients)
            {
                clientDT.Rows.Add(c.getClientid(), c.getName(), c.getPlace(), c.getTel());
                
            }
            
            return clientDT;
            
        }

        internal static DataTable returnSearchedClient(string clientname)
        {
            DataTable clientDT = new DataTable();
            clientDT.Columns.Add("id", typeof(int));
            clientDT.Columns.Add("név", typeof(string));
            clientDT.Columns.Add("lakhely", typeof(string));
            clientDT.Columns.Add("telefonszám", typeof(int));
            foreach (Client c in Clients)
            {
                if (c.getName() == clientname)
                    clientDT.Rows.Add(c.getClientid(), c.getName(), c.getPlace(), c.getTel());
               
            }
            return clientDT;
        }

        internal static void clearClientsDataList()
        {
            Clients.Clear();
        }
    }
}
