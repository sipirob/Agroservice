using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.controller
{
   public class Connection:FormSignIn
    {
       
       public static string connectionString()
        {
            
                string connectionstring = "";
            try
            {
                if (server == 0)
                {
                    connectionstring =
                     "SERVER=\"127.0.0.1\";"
                     + "DATABASE=\"agroservice\";"
                     + "UID=\"root\";"
                     + "PASSWORD=\"\";"
                     + "PORT=\"3306\";"
                     + "SslMode=none";
                }
                if (server == 1)
                {
                    connectionstring =
                     "SERVER=\"10.0.128.111\";"
                     + "DATABASE=\"zarodolgozat_2018siprob\";"
                     + "UID=\"zarodolgozat\";"
                     + "PASSWORD=\"zarodolgozat\";"
                     + "PORT=\"3306\";"
                     + "SslMode=none";
                }
                
            }
           
            catch (Exception e)
            {
                throw new Exception("A kapcsolat sikertelen");
            }
            return connectionstring;
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
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(369, 578);
            this.Name = "Connection";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.ResumeLayout(false);

        }

        private void Connection_Load(object sender, EventArgs e)
        {

        }

        //public static string connectionString =
        //          "SERVER=\"127.0.0.1\";"
        //          + "DATABASE=\"agroservice\";"
        //          + "UID=\"root\";"
        //          + "PASSWORD=\"\";"
        //          + "PORT=\"3306\";"
        //          + "SslMode=none";


    }
}
