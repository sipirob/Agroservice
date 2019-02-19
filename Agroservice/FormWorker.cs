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
        AgroserviceController controller = new AgroserviceController();
        UserControlNewWorks userControlNew;
        public static string workername="";
        public FormWorker()
        {
            InitializeComponent();
            panelSign.Height = buttonHome.Height;
            userControlNew = new UserControlNewWorks();
            
            //userControlNewWorks1.BringToFront();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelSign.Height = buttonHome.Height;
            panelSign.Top = buttonHome.Top;
            userControlNewWorks1.Hide();
            userControlCompleteWorks1.Hide();
        }

        private void buttonNewWork_Click(object sender, EventArgs e)
        {
            userControlCompleteWorks1.Hide();
            panelSign.Height = buttonNewWork.Height;
            panelSign.Top = buttonNewWork.Top;
            userControlNewWorks1.Show();
            userControlNew.gMapControlParcelMap.Hide();
            
            
        }

        private void userControlNewWorks1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void FormWorker_Load(object sender, EventArgs e)
        {
            userControlNewWorks1.Hide();
            userControlCompleteWorks1.Hide();
            controller.usernameLoad();
            workername = controller.getloadUsername();
            labelUsername.Text = workername;

            //Elvégzett munkálatok betöltése
            controller.loadCompleteData();
            userControlCompleteWorks1.dataGridViewCompleteWorks.DataSource = controller.getCompleteWorksData();

            //Függőben lévő munkálatok betöltése
            controller.loadNewWorkData();
            DataTable dt = new DataTable();
            dt = controller.getNewWorkData();
            ListViewItem lv = new ListViewItem();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem(dr["dátum"].ToString());
                lvi.SubItems.Add(dr["parcellaszám"].ToString());
                lvi.SubItems.Add(dr["munkálat neve"].ToString());
                lvi.SubItems.Add(dr["gabona"].ToString());

                userControlNewWorks1.listViewNewWork.Items.Add(lvi);
            }

            //controller.loadParcelMap();
        }

        private void buttonDoneWork_Click(object sender, EventArgs e)
        {
            panelSign.Height = buttonDoneWork.Height;
            panelSign.Top = buttonDoneWork.Top;
            userControlCompleteWorks1.Show();


        }

        private void buttonClientData_Click(object sender, EventArgs e)
        {
            panelSign.Height = buttonClientData.Height;
            panelSign.Top = buttonClientData.Top;
            userControlCompleteWorks1.Show();
        }
    }
}
