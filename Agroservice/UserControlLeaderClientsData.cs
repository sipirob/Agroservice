using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agroservice
{
    public partial class UserControlLeaderClientsData : UserControl
    {
        bool modified = false;
        int workerid;
        string workerName;
        DateTime workerBirthday;
        string workerPlace;
        int workerTelnumb;
        DataTable workerdata = new DataTable();
        model.AgroserviceModel model = new model.AgroserviceModel();
        DataTable listboxDt;
       
        public UserControlLeaderClientsData()
        {
            InitializeComponent();
            
            listboxDt = new DataTable();
           
           
        }

        public static object ListViewClientsData { get; internal set; }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void UserControlLeaderClientsData_Load(object sender, EventArgs e)
        {

            model.loadWorkerData();
            
            listBoxWorkers.DataSource = model.getWorkersName().DefaultView;
            listBoxWorkers.DisplayMember = "név";
            listBoxWorkers.ValueMember = "id";
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            int clientid =Convert.ToInt32(listViewClientsData.SelectedItems[0].Text);
           
            if (MessageBox.Show("Biztosan törli az ügyfelet?", "Igen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                model.getdeleteUser(clientid);
                listViewClientsData.Items.Remove(listViewClientsData.SelectedItems[0]);
                MessageBox.Show("Ügyfél törölve");
            }

            else
                return;
        }

        private void buttonSearchClient_Click(object sender, EventArgs e)
        {
            string clientname = TextboxClientName.Text;
            DataTable searchedClient = model.searchClient(clientname);
            foreach (DataRow dr in searchedClient.Rows)
            {
                ListViewItem clvi = new ListViewItem(dr["id"].ToString());
                clvi.SubItems.Add(dr["név"].ToString());
                clvi.SubItems.Add(dr["lakhely"].ToString());
                clvi.SubItems.Add(dr["telefonszám"].ToString());
                listViewClientsData.Items.Clear();
                listViewClientsData.Items.Add(clvi);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int workerid = Convert.ToInt32(listBoxWorkers.SelectedValue);

            if (MessageBox.Show( "Biztosan törli a dolgozót?","Igen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                model.getDeleteWorker(workerid);
                MessageBox.Show("Dolgozó törölve");
                
                model.getWorkersName().Clear();
                listBoxWorkers.DataSource = null;
                listBoxWorkers.Items.Clear();
                model.loadWorkerData();
               
                listBoxWorkers.DataSource = listboxDt.DefaultView;
                listBoxWorkers.DisplayMember = "név";
                listBoxWorkers.ValueMember = "id";
              
            }
                
            else 
            return;
        }

        private void buttonUpdateWorkerData_Click(object sender, EventArgs e)
        {
            modified = true;
            workerid = Convert.ToInt32(listBoxWorkers.SelectedValue);
            workerName = textBoxWorkerName.Text;
            workerBirthday = Convert.ToDateTime(metroWorkerBirthday.Text);
            workerPlace = textBoxWorkerPlace.Text;
            workerTelnumb = Convert.ToInt32(textBoxWorkerTelnumber.Text);
           
            model.getUpdateWorkerData(workerid,workerName,workerBirthday,workerPlace,workerTelnumb);
            
            model.getClearWorkerList();
            model.loadWorkerData();
            listBoxWorkers.DataSource = model.getWorkersName().DefaultView;
            listBoxWorkers.DisplayMember = "név";
            listBoxWorkers.ValueMember = "id";
        }

        private void listBoxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (listBoxWorkers.SelectedIndex >= 0)
            {
               
                listBoxWorkers.ValueMember = "id";
                model.loadWorkerData();
                workerid = Convert.ToInt32(listBoxWorkers.SelectedValue);
                workerdata = model.getSelectedWorkerdata(workerid);
                textBoxWorkerName.Text = workerdata.Rows[0]["név"].ToString();
                metroWorkerBirthday.Text = workerdata.Rows[0]["születési idő"].ToString();
                textBoxWorkerPlace.Text = workerdata.Rows[0]["lakhely"].ToString();
                textBoxWorkerTelnumber.Text = workerdata.Rows[0]["telefonszám"].ToString();
                workerdata.Clear();

                
            }
            else return;


           

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            model.getClearWorkerList();
            //listBoxWorkers.DataSource = null;
            //listBoxWorkers.Items.Clear();
            //model.getWorkersName().Clear();
            model.loadWorkerData();
            //listBoxWorkers.DataSource =workerdata.DefaultView;
            listBoxWorkers.DataSource =model.getWorkersName().DefaultView;

            listBoxWorkers.DisplayMember = "név";
           
        }
    }
}
