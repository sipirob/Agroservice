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
        }

        private void listBoxServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxServices.ValueMember = "id";
            int serviceid = Convert.ToInt32(listBoxServices.SelectedValue);
            model.getloadServiceData();
            
            DataTable serviceData= model.getLoadServiceName();
            if (listBoxServices.SelectedIndex > 0)
            {
                DataTable servicedata = model.getSelectedService(serviceid);
                textBoxServiceName.Text = servicedata.Rows[0]["name"].ToString();
                textBoxServicePrice.Text = servicedata.Rows[0]["price"].ToString();
            }
           
        }
    }
}
