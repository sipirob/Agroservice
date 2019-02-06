using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Agroservice.repository
{
   public class LogIn :FormSignIn
    {
       //public FormSignIn fsign;
       public FormSignIn si = new FormSignIn();
        public  void Login()
        {

          //  this.fsign = si;

            //FormSignIn si = new FormSignIn();
            MySqlConnection connection = new MySqlConnection(model.Connection.connectionString);
            string passwordlog = password;
            string usernamelog = username;
            int i = 0;
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
           
            cmd.CommandText = "select * from user, category where categoryId = category.id and username = '" + username + "' and password='" + password + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("Helytelen felhasználóinév vagy jelszó!");
                labelUsername.Text = username;
                connection.Close();
            }

            else if (i == 1)
            {
                //jogosultság kiválasztása
                switch (dt.Rows[0]["category"] as string)
                {
                    case "worker":
                        {
                           
                            FormWorker fw = new FormWorker();
                            fw.Show();
                            break;
                        }
                    case "leader":
                        {
                            FormLeader fl = new FormLeader();
                            fl.Show();
                            break;
                        }

                }
            }
    }
    }
}
