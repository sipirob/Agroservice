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
        int category;
        int newWorkerId;
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
            buttonCancel.Hide();
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
                
                model.getClearWorkerList();
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
            if (MessageBox.Show("Biztosan módosítja a dolgozó adatait?", "Igen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                workerid = Convert.ToInt32(listBoxWorkers.SelectedValue);
                workerName = textBoxWorkerName.Text;
                workerBirthday = Convert.ToDateTime(metroWorkerBirthday.Text);
                workerPlace = textBoxWorkerPlace.Text;
                workerTelnumb = Convert.ToInt32(textBoxWorkerTelnumber.Text);

                model.getUpdateWorkerData(workerid, workerName, workerBirthday, workerPlace, workerTelnumb);

                model.getClearWorkerList();
                model.loadWorkerData();
                listBoxWorkers.DataSource = model.getWorkersName().DefaultView;
                listBoxWorkers.DisplayMember = "név";
                listBoxWorkers.ValueMember = "id";
                MessageBox.Show("Dolgozó adataina módosítása megtörtént");
            }
               
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

        private void buttonAddNewWorker_Click(object sender, EventArgs e)
        {
            newWorkerId = model.getSearchLastWorkerId() + 1;
            textBoxWorkerName.Text = null;
            metroWorkerBirthday.Text = null;
            textBoxWorkerPlace.Text = null;
            textBoxWorkerTelnumber.Text = null;
            button3.Hide();
            buttonUpdateWorkerData.Hide();
            buttonCancel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBoxCategory.Text == "worker")
            {
                category = 1;
            }
            else if (comboBoxCategory.Text == "leader")
            {
                category = 2;
            }
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            workerName = textBoxWorkerName.Text;
            workerBirthday = Convert.ToDateTime(metroWorkerBirthday.Text);
            workerPlace = textBoxWorkerPlace.Text;
            workerTelnumb = Convert.ToInt32(textBoxWorkerTelnumber.Text);
            model.getInsertNewWorkerData(workerName, workerBirthday, workerPlace, workerTelnumb);
            
            model.getInsertNewWorker(newWorkerId, username, password, category);
            textBoxPassword.Text = null;
            textBoxUsername.Text = null;
            button3.Show();
            buttonUpdateWorkerData.Show();

            model.getClearWorkerList();
            model.loadWorkerData();
            listBoxWorkers.DataSource = model.getWorkersName().DefaultView;
            listBoxWorkers.DisplayMember = "név";
            listBoxWorkers.ValueMember = "id";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            button3.Show();
            buttonUpdateWorkerData.Show();
            buttonCancel.Hide();
        }
    }
}
