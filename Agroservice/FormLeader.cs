﻿using System;
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
    public partial class FormLeader :Form
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
           // Client cl = new Client();
            AgroserviceController controller = new AgroserviceController();
            controller.loadClientData();
           // dataGridViewClient.DataSource = controller.getClientData();
            
           

        }

        private void FormLeader_Load(object sender, EventArgs e)
        {
            
            AgroserviceController controller = new AgroserviceController();

            //controller.loadWorkerData();
            //dataGridViewWorkers.DataSource = controller.getWorkerData();

            //controller.loadNewWorkData();
            //dataGridViewNewWorkData.DataSource = controller.getNewWorkData();

            //controller.usernameLoad();
            //labelUsernamae.Text = controller.getloadUsername();

            //controller.loadCompleteData();
            //dataGridViewCompleteWorks.DataSource = controller.getCompleteWorksData();


            controller.loadClientData();
           // dataGridViewClient.DataSource = controller.getClientData();
            DataTable dt = new DataTable();
            dt = controller.getClientData();
            
            ListViewItem lv = new ListViewItem();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem(dr["id"].ToString());
                lvi.SubItems.Add(dr["név"].ToString());
                lvi.SubItems.Add(dr["lakhely"].ToString());
                lvi.SubItems.Add(dr["telefonszám"].ToString());


                //ListViewClientsData.Items.Add(lvi);
            }

            
        }
    }
}
