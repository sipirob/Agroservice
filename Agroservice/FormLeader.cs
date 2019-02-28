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
       AgroserviceController controller;
        private LogIn logIn;

        public FormLeader()
        {
            controller = new AgroserviceController();
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
            userControlLeaderClientsData1.Hide();
            userControlLeaderWorks1.Hide();
           

            //controller.loadWorkerData();
            //dataGridViewWorkers.DataSource = controller.getWorkerData();

            controller.loadNewWorkData();
            userControlLeaderWorks1.dataGridViewAllNewWorks.DataSource = controller.getNewWorkData();

            controller.usernameLoad();
            labelUsername.Text = controller.getloadUsername();

            controller.loadCompleteData();
           userControlLeaderWorks1.dataGridViewAllCompleteWorks.DataSource = controller.getCompleteWorksData();


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


                userControlLeaderClientsData1.listViewClientsData.Items.Add(lvi); 
            }
           
            
        }

        private void buttonClientData_Click(object sender, EventArgs e)
        {
            panelSign.Height = buttonClientData.Height;
            panelSign.Top = buttonClientData.Top;
            userControlLeaderClientsData1.Show();
            userControlLeaderWorks1.Hide();
            
        }

        private void buttonNewWork_Click(object sender, EventArgs e)
        {
            panelSign.Height = buttonNewWork.Height;
            panelSign.Top = buttonNewWork.Top;
            userControlLeaderClientsData1.Hide();
            userControlLeaderWorks1.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            userControlLeaderWorks1.Hide();
            userControlLeaderClientsData1.Hide();
        }

        private void buttonDoneWork_Click(object sender, EventArgs e)
        {
            panelSign.Height = buttonDoneWork.Height;
            panelSign.Top = buttonDoneWork.Top;
            userControlLeaderWorks1.Hide();
            userControlLeaderClientsData1.Hide();
           
            
            

        }
    }
}
