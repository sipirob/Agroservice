using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Agroservice.controller
{
   
   public class AgroserviceController
    {
        private model.ClientDataLoad clientDataLoad;
       
        public AgroserviceController()
        {
            clientDataLoad = new model.ClientDataLoad();
        }
       
        internal DataTable getClientData()
        {
            DataTable clientDT = model.ClientDataLoad.getClientDataFromList();
            return clientDT;
          
        }
        public void loadClientData()
        {
            model.ClientDataLoad.clientDataLoad();
        }
    }
}
