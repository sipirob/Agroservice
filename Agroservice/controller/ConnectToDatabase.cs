using MysSqlDataGridViewHalak;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.controller
{
    class ConnectToDatabase:FormSignIn
    {
        FormSignIn signIn = new FormSignIn();
        public MySQLDatabaseInterface connect()
        {
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            if (server == 0)
            {
                
                mdi.setErrorToUserInterface(true);
                mdi.setErrorToGraphicalUserInterface(true);
                mdi.setConnectionServerData("localhost", "agroservice", "3306");
                mdi.setConnectionUserData("root", "");
                mdi.makeConnectionToDatabase();
                
            }
            if (server == 1)
            {

                mdi.setErrorToUserInterface(true);
                mdi.setErrorToGraphicalUserInterface(true);
                mdi.setConnectionServerData("10.0.128.111", "zarodolgozat_2018siprob", "3306");
                mdi.setConnectionUserData("zarodolgozat", "zarodolgozat");
                mdi.makeConnectionToDatabase();

            }
            return mdi;
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
            // ConnectToDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(369, 578);
            this.Name = "ConnectToDatabase";
            this.Load += new System.EventHandler(this.ConnectToDatabase_Load);
            this.ResumeLayout(false);

        }

        private void ConnectToDatabase_Load(object sender, EventArgs e)
        {

        }
    }
}
