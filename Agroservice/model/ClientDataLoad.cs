using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Agroservice.model
{
     class ClientDataLoad
    {
        public FormLeader fl = new FormLeader();
        internal void clientDataLoad()
        {
            fl.ListViewClientData.Items.Clear();
           
            MySqlConnection connection = new MySqlConnection(model.Connection.connectionString);
            repository.Client cl = new repository.Client();

            string query = "SELECT `id`, `vezeteknev`, `kersztnev`, `lakhely`, `telefonszam` FROM `clientdata`";
            MySqlCommand cmd = new MySqlCommand(query, connection);

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
                //ListViewItem lv = new ListViewItem(Convert.ToString(cl.getClientid()));
                //lv.SubItems.Add(cl.getFirstname());
                //lv.SubItems.Add(cl.getLastname());
                //lv.SubItems.Add(cl.getPlace());
                //lv.SubItems.Add(Convert.ToString(cl.getTel()));
                //fl.ListViewClientData.Items.Add(lv);
                //MessageBox.Show(cl.getFirstname());
               

            }
            dr.Close();
            connection.Close();
        }
    }
}
