using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MysSqlDataGridViewHalak;

namespace Agroservice.model
{
    public  class ClientDataLoad 
    {
        public FormLeader fl = new FormLeader();
        private MySQLDatabaseInterface mdi;
        private DataTable clientData;
        public ClientDataLoad()
        {
        }

       

        public DataTable clientDataLoad()
        {
            //fl.ListViewClientData.Items.Clear();

            //MySqlConnection connection = new MySqlConnection(model.Connection.connectionString);
            //repository.Client cl = new repository.Client();

            //string query = "SELECT `id`, `vezeteknev`, `kersztnev`, `lakhely`, `telefonszam` FROM `clientdata`";
            //MySqlCommand cmd = new MySqlCommand(query, connection);
            //ListViewItem li = new ListViewItem();
            //connection.Open();
            //MySqlDataReader dr;
            //dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    cl.setClientid(Convert.ToInt32(dr[0]));
            //    cl.setFirstname(dr[1].ToString());
            //    cl.setLastname(dr[2].ToString());
            //    cl.setPlace(dr[3].ToString());
            //    cl.setTel(Convert.ToInt32(dr[4]));


            //    ListViewItem lv = new ListViewItem(Convert.ToString(cl.getClientid()));
            //    lv.SubItems.Add("hahó");
            //    lv.SubItems.Add(cl.getLastname());
            //    lv.SubItems.Add(cl.getPlace());
            //    lv.SubItems.Add(Convert.ToString(cl.getTel()));
            //    // fl.ListViewClientData.Items.Add(lv);
            //    lv = li;
            // MessageBox.Show(Convert.ToString(lv.SubItems[3]));


            //}
            //dr.Close();
            //connection.Close();
            //return li;


           
            model.ConnectToDatabase a = new ConnectToDatabase();
            mdi = a.connect();
            mdi.open();
            clientData = mdi.getToDataTable("SELECT `id`, `vezeteknev`, `kersztnev`, `lakhely`, `telefonszam` FROM `clientdata`");
            //fl.dataGridViewClient.DataSource = clientData;
            repository.Client cl = new repository.Client();
            List<repository.Client> clients = new List<repository.Client>();
            foreach (DataRow row in clientData.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                string fname = row[1].ToString();
                string lname = row[2].ToString();
                string place = row[3].ToString();
                int tel = Convert.ToInt32(row[4]);
                repository.Client c = new repository.Client(id, fname, lname, place, tel);
                clients.Add(c);

            }
           
          

            DataTable cdt = new DataTable();
            cdt.Columns.Add("id", typeof(int));
            cdt.Columns.Add("vezetéknév", typeof(string));
            cdt.Columns.Add("keresztnev", typeof(string));
            cdt.Columns.Add("lakhely", typeof(string));
            cdt.Columns.Add("tel", typeof(int));

            //DataRow getdr = clientData.NewRow();
            //getdr[0] = cl.getClientid();
            //getdr[1] = cl.getFirstname();
            //getdr[2] = cl.getLastname();
            //getdr[3] = cl.getPlace();
            //getdr[4] = cl.getTel();
            foreach(repository.Client c in clients)
            {
                cdt.Rows.Add(cl.getClientid(), cl.getFirstname(), cl.getLastname(), cl.getPlace(), cl.getTel());
            }

            MessageBox.Show(clients[1].ToString());
           
            return cdt;

            // repository.Client cl = new repository.Client();
            //DataRow dr = clientData.NewRow();
            //cl.setClientid(Convert.ToInt32(dr[0]));
            //cl.setFirstname(dr[1].ToString());
            //cl.setLastname(dr[2].ToString());
            //cl.setPlace(dr[3].ToString());
            //cl.setTel(Convert.ToInt32(dr[4]));

            //DataRow getdr = clientData.NewRow();
            //cl.setClientid(Convert.ToInt32(getdr[0]));
            //cl.setFirstname(getdr[1].ToString());
            //cl.setLastname(getdr[2].ToString());
            //cl.setPlace(getdr[3].ToString());
            //cl.setTel(Convert.ToInt32(getdr[4]));
            //DataTable clientDt = new DataTable();
            //clientDt.Rows.Add(getdr);

            //return clientDt;

        }

        public static ListViewItem getClientDataList()
        {
            //List<string> client = new List<string>();
            //FormLeader fl = new FormLeader();
            //DataTable dt = new DataTable();
            //MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            //model.ConnectToDatabase a = new ConnectToDatabase();
            //repository.Client cl = new repository.Client();
            //ListViewItem lv = new ListViewItem();
            //mdi = a.connect();
            //mdi.open();
            //dt = mdi.getToDataTable("SELECT `id`, `vezeteknev`, `kersztnev`, `lakhely`, `telefonszam` FROM `clientdata`");

            //dt.Rows.Add(client);


            //return lv;

            FormLeader fl = new FormLeader();
            // fl.ListViewClientData.Items.Clear();

            MySqlConnection connection = new MySqlConnection(model.Connection.connectionString);
            repository.Client cl = new repository.Client();

            string query = "SELECT `id`, `vezeteknev`, `kersztnev`, `lakhely`, `telefonszam` FROM `clientdata`";
            MySqlCommand cmd = new MySqlCommand(query, connection);
           List< ListViewItem> li = new List<ListViewItem>();
            connection.Open();
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cl.setClientid(Convert.ToInt32(dr[0]));
                cl.setFirstname(dr[1].ToString());
                cl.setLastname(dr[2].ToString());
                cl.setPlace(dr[3].ToString());
                cl.setTel(Convert.ToInt32(dr[4]));


                ListViewItem lv = new ListViewItem(Convert.ToString(cl.getClientid()));
                lv.SubItems.Add("hahó");
                lv.SubItems.Add(cl.getLastname());
                lv.SubItems.Add(cl.getPlace());
                lv.SubItems.Add(Convert.ToString(cl.getTel()));
                // fl.ListViewClientData.Items.Add(lv);
                li.Add(lv);
                
                // MessageBox.Show(Convert.ToString(lv.SubItems[3]));


            }
            ListViewItem list = new ListViewItem();
            li.Add(list);
            dr.Close();
            connection.Close();
            return list;

        }
    }
}
