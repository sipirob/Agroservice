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
        public FormSignIn si = new FormSignIn();
        public  void Login()
        {
            MySqlConnection connection = new MySqlConnection(model.Connection.connectionString);
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
                connection.Close();
            }
            else if (i == 1)
            {
                //jogosultság kiválasztása
                switch (dt.Rows[0]["category"] as string)
                {
                    case "worker":
                        {
                            FormSignIn siin = new FormSignIn();
                            FormWorker fw = new FormWorker();
                            siin.Hide();
                            fw.Show();
                           
                            connection.Close();
                            break;
                        }
                    case "leader":
                        {
                            FormLeader fl = new FormLeader();
                            fl.Show();
                            connection.Close();
                            break;
                        }

                }
            }
      }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TextboxUsername
            // 
            // 
            // 
            // 
            this.TextboxUsername.CustomButton.FlatAppearance.BorderSize = 0;
            this.TextboxUsername.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextboxUsername.CustomButton.Image = null;
            this.TextboxUsername.CustomButton.Location = new System.Drawing.Point(208, 2);
            this.TextboxUsername.CustomButton.Name = "";
            this.TextboxUsername.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TextboxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextboxUsername.CustomButton.TabIndex = 1;
            this.TextboxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextboxUsername.CustomButton.UseSelectable = true;
            this.TextboxUsername.CustomButton.Visible = false;
            this.TextboxUsername.Lines = new string[0];
            // 
            // TextboxPassword
            // 
            // 
            // 
            // 
            this.TextboxPassword.CustomButton.Image = null;
            this.TextboxPassword.CustomButton.Location = new System.Drawing.Point(208, 2);
            this.TextboxPassword.CustomButton.Name = "";
            this.TextboxPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TextboxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextboxPassword.CustomButton.TabIndex = 1;
            this.TextboxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextboxPassword.CustomButton.UseSelectable = true;
            this.TextboxPassword.CustomButton.Visible = false;
            this.TextboxPassword.Lines = new string[0];
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(369, 481);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}