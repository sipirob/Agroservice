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
           
            labelIsWorks.Hide();
            labelNoworks.Hide();
            model.AgroserviceModel model = new model.AgroserviceModel();
            model.loadNewWorkData();
            userControlLeaderClientsData1.Hide();
            userControlLeaderWorks1.Hide();
            userControlLeaderSettings1.Hide();
            int newWorksNumb=model.getNumberOfNewWorks();

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

            //userControlLeaderClientsData1.listBoxWorkers.DataSource = null;
            model.loadWorkerData();
            //userControlLeaderClientsData1.listBoxWorkers.DataSource = model.getWorkersName().DefaultView;
            //userControlLeaderClientsData1.listBoxWorkers.DisplayMember = "név";
            //userControlLeaderClientsData1.listBoxWorkers.ValueMember = "id";


            userControlLeaderWorks1.metroComboBoxWorkers.DataSource = model.getWorkersName().DefaultView;
            userControlLeaderWorks1.metroComboBoxWorkers.DisplayMember = "név";
            userControlLeaderWorks1.metroComboBoxWorkers.ValueMember = "id";

            userControlLeaderWorks1.metroComboBoxWorker.DataSource = model.getWorkersName().DefaultView;
            userControlLeaderWorks1.metroComboBoxWorker.DisplayMember = "név";
            userControlLeaderWorks1.metroComboBoxWorker.ValueMember = "név";
            //controller.loadWorkerData();
            //dataGridViewWorkers.DataSource = controller.getWorkerData();

           
            userControlLeaderWorks1.dataGridViewAllNewWorks.DataSource = model.getNewWorkData();

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




        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            userControlLeaderWorks1.Hide();
            userControlLeaderClientsData1.Hide();
            userControlLeaderSettings1.Hide();
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
    }
}
