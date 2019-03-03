using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agroservice.View
{
    public partial class FormCalculator : Form 
    {
        controller.AgroserviceController controller = new controller.AgroserviceController();
        UserControlNewWorks newWorks = new UserControlNewWorks();
        public FormCalculator()
        {
            InitializeComponent();
            
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {
           
        }
    }
}
