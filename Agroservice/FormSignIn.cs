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
        public  bool leader = false;
        public static bool worker = false;
           
        public FormSignIn()
        {
           
            InitializeComponent();
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            username = TextboxUsername.Text;
            password = TextboxPassword.Text;
            repository.LogIn log = new repository.LogIn();
            log.Login();
           
         
        }
    }
}
