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

        public ClientDataLoad(FormLeader fl)
        {
            this.fl = fl;
        }

        public DataTable clientDataLoad()
        {
            // fl.ListViewClientData.Items.Clear();

            //MySqlConnection connection = new MySqlConnection(model.Connection.connectionString);
            //repository.Client cl = new repository.Client();

            //string query = "SELECT `id`, `vezeteknev`, `kersztnev`, `lakhely`, `telefonszam` FROM `clientdata`";
            //MySqlCommand cmd = new MySqlCommand(query, connection);

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
            //    fl.listViewClient.Items.Add(lv);

            //    MessageBox.Show(Convert.ToString(lv.SubItems[3]));


            //}
            //dr.Close();
            //connection.Close();



            model.ConnectToDatabase a = new ConnectToDatabase();
            mdi = a.connect();
            mdi.open();
            clientData = mdi.getToDataTable("SELECT `id`, `vezeteknev`, `kersztnev`, `lakhely`, `telefonszam` FROM `clientdata`");
            fl.dataGridViewClient.DataSource = clientData;
            return clientData;
            
        }

        public static ListViewItem getClientDataList()
        {
            FormLeader fl = new FormLeader();
            DataTable dt = new DataTable();
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            model.ConnectToDatabase a = new ConnectToDatabase();
            repository.Client cl = new repository.Client();
            ListViewItem lv = new ListViewItem();
            mdi = a.connect();
            mdi.open();
            dt = mdi.getToDataTable("SELECT `id`, `vezeteknev`, `kersztnev`, `lakhely`, `telefonszam` FROM `clientdata`");

            
            dt.Rows. Add(lv).ToString();
            return lv;
        }
    }
}
