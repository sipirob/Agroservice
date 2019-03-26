﻿using MySql.Data.MySqlClient;
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
      
        public  void Login()
        {
            MySqlConnection connection = new MySqlConnection(controller.Connection.connectionString);
            int i = 0;
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from worker, category where categoryId = category.id and username = '" + username + "' and password='" + password + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("Helytelen felhasználóinév vagy jelszó!");
                connection.Close();
            }
            else if (i == 1)
            {
                //jogosultság kiválasztása
                switch (dt.Rows[0]["category"] as string)
                {
                    case "worker":
                        {
                            worker = true;
                            leader = false;
                           
                            FormWorker fw = new FormWorker();
                           
                            fw.Show();
                            connection.Close();
                           
                            break;
                        }
                    case "leader":
                        {
                            leader = true;
                            worker = false;
                            FormSignIn siin = new FormSignIn();
                            FormLeader fl = new FormLeader();
                            fl.Show();
                            connection.Close();
                            break;
                            
                        }

                }
            }
      }
    }
}
