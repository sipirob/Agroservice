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
        public void numberOfWorks()
        {
            model.getClearNewWorkList();
            model.loadNewWorkData();
            int newWorksNumb = model.getNumberOfNewWorks();

            if (newWorksNumb > 0)
            {
                labelIsWorks.Show();
                labelIsWorks.Text = "Önnek " + newWorksNumb + " újonnan beérkezett munkálat foglalása van";
            }
            else if (newWorksNumb == 0)
            {
                labelNoworks.Show();
                labelNoworks.Text = "Nincs új szolgáltatás igénylés";
            }
        }
        private void TextBoxWorkerName_Click(object sender, EventArgs e)
        {

        }

        private void buttonAllClient_Click(object sender, EventArgs e)
        {
           
            model.AgroserviceModel model = new model.AgroserviceModel();
            model.loadClientData();
          
        }

        private void FormLeader_Load(object sender, EventArgs e)
        {
           
            labelIsWorks.Hide();
            labelNoworks.Hide();
            model.AgroserviceModel model = new model.AgroserviceModel();
            model.loadNewWorkData();
            userControlLeaderClientsData1.Hide();
            userControlLeaderWorks1.Hide();
            userControlLeaderSettings1.Hide();
            numberOfWorks();
            
            model.loadWorkerData();
           
            userControlLeaderWorks1.metroComboBoxWorkers.DataSource = model.getWorkersName().DefaultView;
            userControlLeaderWorks1.metroComboBoxWorkers.DisplayMember = "név";
            userControlLeaderWorks1.metroComboBoxWorkers.ValueMember = "id";

            userControlLeaderWorks1.metroComboBoxWorker.DataSource = model.getWorkersName().DefaultView;
            userControlLeaderWorks1.metroComboBoxWorker.DisplayMember = "név";
            userControlLeaderWorks1.metroComboBoxWorker.ValueMember = "név";
           
            model.usernameLoad();
            labelUsername.Text = model.getloadUsername();

        }

        private void buttonUsersData_Click(object sender, EventArgs e)
        {
            panelSign.Height = buttonUsersData.Height;
            panelSign.Top = buttonUsersData.Top;
            userControlLeaderClientsData1.Show();
            userControlLeaderSettings1.Hide();
            userControlLeaderWorks1.Hide();

            model.getClearClientsDataList();
            userControlLeaderClientsData1.listViewClientsData.Items.Clear();
            model.loadClientData();
           
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

        private void buttonNewWork_Click(object sender, EventArgs e)
        {
            panelSign.Height = buttonNewWork.Height;
            panelSign.Top = buttonNewWork.Top;
            userControlLeaderClientsData1.Hide();
            userControlLeaderWorks1.Show();
            userControlLeaderSettings1.Hide();

            model.loadWorkerData();
            model.getClearCompleteWorksList();
            model.loadCompleteData();
            userControlLeaderWorks1.dataGridViewAllCompleteWorks.DataSource = model.getCompleteWorksData();
            userControlLeaderWorks1.dataGridViewAllCompleteWorks.Columns[0].Width = 120;
            userControlLeaderWorks1.dataGridViewAllCompleteWorks.Columns[1].Width = 120;
            userControlLeaderWorks1.dataGridViewAllCompleteWorks.Columns[2].Width = 150;
            userControlLeaderWorks1.dataGridViewAllCompleteWorks.Columns[3].Width = 150;
            userControlLeaderWorks1.dataGridViewAllCompleteWorks.Columns[4].Width = 150;
            userControlLeaderWorks1.dataGridViewAllCompleteWorks.Columns[5].Width = 150;

            model.getClearNewWorkList();
            model.loadNewWorkData();
            
            userControlLeaderWorks1.dataGridViewAllNewWorks.DataSource = model.getNewWorkData();
            userControlLeaderWorks1.dataGridViewAllNewWorks.Columns[0].Width = 70;
            userControlLeaderWorks1.dataGridViewAllNewWorks.Columns[1].Width = 150;
            userControlLeaderWorks1.dataGridViewAllNewWorks.Columns[2].Width = 150;
            userControlLeaderWorks1.dataGridViewAllNewWorks.Columns[3].Width = 150;
            userControlLeaderWorks1.dataGridViewAllNewWorks.Columns[4].Width = 150;
            userControlLeaderWorks1.dataGridViewAllNewWorks.Columns[5].Width = 150;
            userControlLeaderWorks1.dataGridViewAllNewWorks.Columns[6].Width = 150;

            
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelSign.Height = buttonNewWork.Height;
            panelSign.Top = buttonHome.Top;
            userControlLeaderWorks1.Hide();
            userControlLeaderClientsData1.Hide();
            userControlLeaderSettings1.Hide();
            numberOfWorks();
        }

        private void userControlLeaderWorks1_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            panelSign.Height = buttonNewWork.Height;
            panelSign.Top = buttonSettings.Top;
            userControlLeaderClientsData1.Hide();
            userControlLeaderWorks1.Hide();
            userControlLeaderSettings1.Show();
            userControlLeaderAllNewWorks1.Hide();
            model.getClearServiceList();
            model.getloadServiceData();
            userControlLeaderSettings1.listBoxServices.DataSource = model.getLoadServiceName().DefaultView;
            userControlLeaderSettings1.listBoxServices.DisplayMember = "name";
            userControlLeaderSettings1.listBoxServices.ValueMember = "id";
        }

        private void userControlLeaderSettings1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelSign.Height = buttonNewWork.Height;
            panelSign.Top = button5.Top;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
