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
    public partial class UserControlWorkerClientData : UserControl
    {
       
        model.AgroserviceModel model = new model.AgroserviceModel();
        public UserControlWorkerClientData()
        {
            InitializeComponent();
        }

        private void buttonSearchClient_Click(object sender, EventArgs e)
        {
            errorProviderNameFirstLetterLover.Clear();
            string clientname = TextboxClientName.Text;
            Validation.NameValidation nv = new Validation.NameValidation(clientname);
            try
            {
                nv.validation();
            }
            catch(Exceptions.NameException ne)
            {
                errorProviderNameFirstLetterLover.SetError(TextboxClientName, ne.Message);
                return;
            }
            DataTable searchedClient= model.searchClient(clientname);
            if (searchedClient.Rows.Count <= 0)
            {
                MessageBox.Show("Ilyen nevű ügyfél nem szerepel a nyilvántartásban");
                
            }
            else
            foreach (DataRow dr in searchedClient.Rows)
            {
                ListViewItem clvi = new ListViewItem(dr["id"].ToString());
                clvi.SubItems.Add(dr["név"].ToString());
                clvi.SubItems.Add(dr["lakhely"].ToString());
                clvi.SubItems.Add(dr["telefonszám"].ToString());
                listViewClientData.Items.Clear();
                listViewClientData.Items.Add(clvi);
                
            }
        }
    }
}
