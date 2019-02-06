using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Agroservice
{
    public partial class FormSignIn : MetroFramework.Forms.MetroForm
    {
       public static string username;
       public static string password;
       
       
        public FormSignIn()
        {
           
            InitializeComponent();
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            username = TextboxUsername.Text;
            password = TextboxPassword.Text;
            // model.Connection connect = new model.Connection();
            //connect.connectionToDatabase();
           repository.LogIn log = new repository.LogIn();
            log.Login();
            //labelUsername.Text = TextboxUsername.Text;
            
           
        }
    }
}
