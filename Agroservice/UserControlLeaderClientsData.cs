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
        public UserControlLeaderClientsData()
        {
            InitializeComponent();
        }

        public static object ListViewClientsData { get; internal set; }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
