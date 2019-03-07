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
        model.AgroserviceModel model = new model.AgroserviceModel();
        UserControlNewWorks newWorks = new UserControlNewWorks();
        public FormCalculator()
        {
            InitializeComponent();
            
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {
            model.loadVegetablesDistance();
            model.loadGraincropDistanceDt();
            metroComboBoxDis.DataSource = model.loadGraincropDistanceDt().DefaultView;
            metroComboBoxDis.DisplayMember = "distance";
            metroComboBoxDis.ValueMember = "value";


        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double pesticidLiter = Convert.ToDouble(textBoxLiter.Text);
            double parcelHa = Convert.ToDouble(labelHa.Text);
            labelPermetszer.Text= model.calculatePesticid(parcelHa,pesticidLiter);

           
            int plantDisValue = Convert.ToInt32(metroComboBoxDis.SelectedValue);
            

           double seed= model.calculateSeed(plantDisValue,parcelHa);
            labelVetomag.Text = seed.ToString();
            
            
        }
    }
}
