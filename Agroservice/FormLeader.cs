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
    public partial class FormLeader :Form
    {
        public Client cl;
        model.AgroserviceModel model;
        private LogIn logIn;

        public FormLeader()
        {
            model = new model.AgroserviceModel();
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
            model.AgroserviceModel model = new model.AgroserviceModel();
            model.loadClientData();
           // dataGridViewClient.DataSource = controller.getClientData();
            
           

        }

        private void FormLeader_Load(object sender, EventArgs e)
        {
            

            model.AgroserviceModel model = new model.AgroserviceModel();
            userControlLeaderClientsData1.Hide();
            userControlLeaderWorks1.Hide();

            //userControlLeaderClientsData1.listBoxWorkers.DataSource = null;
            model.loadWorkerData();
            //userControlLeaderClientsData1.listBoxWorkers.DataSource = model.getWorkersName().DefaultView;
            //userControlLeaderClientsData1.listBoxWorkers.DisplayMember = "név";
            //userControlLeaderClientsData1.listBoxWorkers.ValueMember = "id";


            userControlLeaderWorks1.metroComboBoxWorkers.DataSource = model.getWorkersName().DefaultView;
            userControlLeaderWorks1.metroComboBoxWorkers.DisplayMember = "név";
            userControlLeaderWorks1.metroComboBoxWorkers.ValueMember = "id";
            //controller.loadWorkerData();
            //dataGridViewWorkers.DataSource = controller.getWorkerData();

            model.loadNewWorkData();
            userControlLeaderWorks1.dataGridViewAllNewWorks.DataSource = model.getNewWorkData();

            model.usernameLoad();
            labelUsername.Text = model.getloadUsername();

            model.loadCompleteData();
           userControlLeaderWorks1.dataGridViewAllCompleteWorks.DataSource = model.getCompleteWorksData();


            model.loadClientData();
           // dataGridViewClient.DataSource = controller.getClientData();
            DataTable dt = new DataTable();
            dt = model.getClientData();
            
            ListViewItem lv = new ListViewItem();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem(dr["id"].ToString());
                lvi.SubItems.Add(dr["név"].ToString());
                lvi.SubItems.Add(dr["lakhely"].ToString());
                lvi.SubItems.Add(dr["telefonszám"].ToString());


                userControlLeaderClientsData1.listViewClientsData.Items.Add(lvi); 
            }
           
            
        }

        private void buttonUsersData_Click(object sender, EventArgs e)
        {
            panelSign.Height = buttonUsersData.Height;
            panelSign.Top = buttonUsersData.Top;
            userControlLeaderClientsData1.Show();
            userControlLeaderWorks1.Hide();
            
        }

        private void buttonNewWork_Click(object sender, EventArgs e)
        {
            panelSign.Height = buttonNewWork.Height;
            panelSign.Top = buttonNewWork.Top;
            userControlLeaderClientsData1.Hide();
            userControlLeaderWorks1.Show();

            model.loadWorkerData();
            
            

           


        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            userControlLeaderWorks1.Hide();
            userControlLeaderClientsData1.Hide();
        }

        private void userControlLeaderWorks1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
