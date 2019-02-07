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
           // repository.Client cl = new Client();
            controller.AgroserviceController controller = new AgroserviceController();
            controller.loadClientData();
            ListViewItem lv = new ListViewItem(Convert.ToString(cl.getClientid()));
            lv.SubItems.Add("hello");
            lv.SubItems.Add(cl.getLastname());
            lv.SubItems.Add(cl.getPlace());
            lv.SubItems.Add(Convert.ToString(cl.getTel()));
            listView1.Items.Add(lv);
            //MessageBox.Show(cl.getFirstname());
        }
    }
}
