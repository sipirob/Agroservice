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
    public partial class UserControlLeaderWorks : UserControl
    {
        model.AgroserviceModel model = new model.AgroserviceModel();
        public UserControlLeaderWorks()
        {
            InitializeComponent();
        }

        private void dataGridViewAllNewWorks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonAddWorker_Click(object sender, EventArgs e)
        {
            int workId = Convert.ToInt32(dataGridViewAllNewWorks.CurrentRow.Cells[0].Value);
            int workerId = Convert.ToInt32(metroComboBoxWorkers.SelectedValue);
            model.setWorkerOfWork(workerId, workId);
            dataGridViewAllNewWorks.Rows.RemoveAt(dataGridViewAllNewWorks.SelectedRows[0].Index);
            MessageBox.Show("Dolgozó hozzáadva a munkálathoz");
        }
    }
}
