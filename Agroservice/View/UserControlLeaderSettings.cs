using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agroservice.View
{
    public partial class UserControlLeaderSettings : UserControl
    {
        model.AgroserviceModel model = new model.AgroserviceModel();
        public UserControlLeaderSettings()
        {
            InitializeComponent();
            buttonCancel.Hide();
        }
        private void refreshService()
        {
            model.getClearServiceList();
            model.getloadServiceData();
            listBoxServices.DataSource = model.getLoadServiceName().DefaultView;
            listBoxServices.DisplayMember = "name";
            listBoxServices.ValueMember = "id";
        }
        private void listBoxServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxServices.ValueMember = "id";
            int serviceid = Convert.ToInt32(listBoxServices.SelectedValue);
            model.getloadServiceData();
            
            DataTable serviceData= model.getLoadServiceName();
            if (listBoxServices.SelectedIndex >= 0)
            {
                DataTable servicedata = model.getSelectedService(serviceid);
                textBoxServiceName.Text = servicedata.Rows[0]["name"].ToString();
                textBoxServicePrice.Text = servicedata.Rows[0]["price"].ToString();
            }
           
        }

        private void buttonNewService_Click(object sender, EventArgs e)
        {
            textBoxServicePrice.Clear();
            textBoxServiceName.Clear();
            buttonDeleteService.Hide();
            buttonUpdateService.Hide();
            buttonCancel.Show();
            buttonNewService.Hide();
        }

        private void buttonDeleteService_Click(object sender, EventArgs e)
        {
            int serviceid = Convert.ToInt32(listBoxServices.SelectedValue);
            if (MessageBox.Show("Biztosan törli a szolgáltatást?", "Igen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                model.getDelteService(serviceid);
                refreshService();
                MessageBox.Show("A kiválasztott szolgáltatás törölve");
            }
            else
                return;
        }

        private void buttonSaveService_Click(object sender, EventArgs e)
        {
            string servicename = textBoxServiceName.Text;
            int servicePrice = Convert.ToInt32(textBoxServicePrice.Text);
            Validation.ServicePriceValidation spval = new Validation.ServicePriceValidation(servicePrice);
            try
            {
                spval.validation();
            }
            catch (Exceptions.ServicePriceException spex)
            {
                errorProviderServiePrice. SetError(textBoxServicePrice, spex.Message);
                return;
            }
            
            if (MessageBox.Show("Biztosan felveszi az új szolgáltatást?", "Igen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                errorProviderServiePrice.Clear();
                model.addNewService(servicename, servicePrice);
                refreshService();
                MessageBox.Show("Szolgáltatás mentve");
                
            }
          
        }

        private void buttonUpdateService_Click(object sender, EventArgs e)
        {
            string servicename = textBoxServiceName.Text;
            int servicePrice = Convert.ToInt32(textBoxServicePrice.Text);
            int serviceid = Convert.ToInt32(listBoxServices.SelectedValue);
            if (MessageBox.Show("Biztosan módosítja a szolgáltatás adatait?", "Igen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                model.updateServiceData(serviceid, servicename, servicePrice);
                refreshService();
                MessageBox.Show("A szolgáltatás módosítva");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonDeleteService.Show();
            buttonNewService.Show();
            buttonUpdateService.Show();
        }
    }
}
