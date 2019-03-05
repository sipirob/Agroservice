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
           controller.loadVegetablesDistance();
           controller.loadGraincropDistanceDt();
           // metroComboBoxDis.Items.Add(controller.loadGraincropDistanceDt().DefaultView);


        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double pesticidLiter = Convert.ToDouble(textBoxLiter.Text);
            double parcelHa = Convert.ToDouble(labelHa.Text);
            labelPermetszer.Text= controller.calculatePesticid(parcelHa,pesticidLiter);

           string plantDistance = metroComboBoxDis.Text;

        
          // controller.calculateSeed(plantDistance);
            
        }
    }
}
