using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agroservice.controller;
using Agroservice.repository;
using MySql.Data.MySqlClient;

namespace Agroservice
{   
    public partial class FormLeader : MetroFramework.Forms.MetroForm
    {
        public Client cl;
      // AgroserviceController controller;
        private LogIn logIn;

        public FormLeader()
        {
            //controller = new AgroserviceController();
            InitializeComponent();
        }

        public FormLeader(LogIn logIn)
        {
            this.logIn = logIn;
        }

        private void TextBoxWorkerName_Click(object sender, EventArgs e)
        {

        }

        private void buttonAllClient_Click(object sender, EventArgs e)
        {
            Client cl = new Client();
            AgroserviceController controller = new AgroserviceController();
            controller.loadClientData();
            dataGridViewClient.DataSource = controller.loadClientData();
            controller.loadClientList();
            ListViewClientData.Items.Add( controller.loadClientList());
           

        }
    }
}
