using Agroservice.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agroservice
{
    public partial class FormWorker : Form
    {
        FormSignIn signIn = new FormSignIn();
        model.AgroserviceModel controller = new model.AgroserviceModel();
        UserControlNewWorks userControlNew;
        DataTable cldt;
        public void newWorksNumber()
        {
            string username = FormSignIn.username;
            panelNoWork.Hide();
            panelNoWork.Location = panelIsWork.Location;
            labelNewWorkNumber.Text = controller.loadNewWorksNumber(username);
            if (labelNewWorkNumber.Text == "0")
            {
                panelIsWork.Hide();
                panelNoWork.Show();
            }
        }

        public static string workername="";
        public FormWorker()
        {
            signIn.Hide();
            InitializeComponent();
            panelSign.Height = buttonHome.Height;
            userControlNew = new UserControlNewWorks();
            cldt = new DataTable();
           

        }

      
        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelSign.Height = buttonHome.Height;
            panelSign.Top = buttonHome.Top;
            userControlNewWorks1.Hide();
            userControlWorkerCompleteWorks1.Hide();
            userControlWorkerClientData1.Hide();
            newWorksNumber();
        }

        private void buttonNewWork_Click(object sender, EventArgs e)
        {
            userControlWorkerCompleteWorks1.Hide();
            panelSign.Height = buttonNewWork.Height;
            panelSign.Top = buttonNewWork.Top;
            userControlNewWorks1.Show();
            userControlNewWorks1.gMapControlParcelMap.Hide();
            userControlWorkerClientData1.Hide();
            
            
        }
        
        private void FormWorker_Load(object sender, EventArgs e)
        {
            userControlWorkerClientData1.Hide();
            userControlNewWorks1.Hide();
            userControlWorkerCompleteWorks1.Hide();
            controller.usernameLoad();
            workername = controller.getloadUsername();
            labelUsername.Text = workername;
            userControlWorkerDoneWorks1.Hide();


            //Függőben lévő munkálatok betöltése
            controller.loadNewWorkData();
            DataTable dt = new DataTable();
            dt = controller.getNewWorkData();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem(dr["Id"].ToString());
                lvi.SubItems.Add(dr["dátum"].ToString());
                lvi.SubItems.Add(dr["parcellaszám"].ToString());
                lvi.SubItems.Add(dr["munkálat neve"].ToString());
                lvi.SubItems.Add(dr["gabona"].ToString());

                userControlNewWorks1.listViewNewWork.Items.Add(lvi);
            }
           
            //El nem végzett munkálatok számának kiírása
            newWorksNumber();
        }

        private void buttonDoneWork_Click(object sender, EventArgs e)
        {
            panelSign.Height = buttonDoneWork.Height;
            panelSign.Top = buttonDoneWork.Top;
            userControlWorkerCompleteWorks1.Show();
            userControlWorkerClientData1.Hide();
            userControlNewWorks1.Hide();
            //Elvégzett munkálatok betöltése

            //controller.getClearWorkerList();
            controller.getClearCompleteWorksList();
            controller.loadCompleteData();

            //userControlCompleteWorks1.dataGridView1.DataSource = null;
            
            userControlWorkerDoneWorks1.dataGridView1.DataSource = controller.getCompleteWorksData();

        }

        private void buttonClientData_Click(object sender, EventArgs e)
        {
           
            panelSign.Height = buttonClientData.Height;
            panelSign.Top = buttonClientData.Top;
            userControlWorkerCompleteWorks1.Hide();
            userControlNewWorks1.Hide();
            userControlWorkerClientData1.Show();

            //Ügyfelek adatainak betöltése
            controller.getClearClientsDataList();
            cldt.Clear();
            userControlWorkerClientData1.listViewClientData.Items.Clear();
            controller.loadClientData();
            cldt = new DataTable();
            cldt = controller.getClientData();
            foreach (DataRow dr in cldt.Rows)
            {
                ListViewItem clvi = new ListViewItem(dr["id"].ToString());
                clvi.SubItems.Add(dr["név"].ToString());
                clvi.SubItems.Add(dr["lakhely"].ToString());
                clvi.SubItems.Add(dr["telefonszám"].ToString());
                userControlWorkerClientData1.listViewClientData.Items.Add(clvi);
            }



        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControlWorkerDoneWorks1.Show();
            controller.getClearCompleteWorksList();
            controller.loadCompleteData();
            userControlWorkerDoneWorks1.dataGridView1.DataSource = controller.getCompleteWorksData();
        }
    }
}
