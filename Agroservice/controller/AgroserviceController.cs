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
        private model.WorkerDataLoad workerDataLoad;
       
        public AgroserviceController()
        {
            clientDataLoad = new model.ClientDataLoad();
            workerDataLoad = new model.WorkerDataLoad();
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
        internal DataTable getWorkerData()
        {
            DataTable workerDT = model.WorkerDataLoad.getWorkerDataFromList();
            return workerDT;
        }
        public void loadWorkerData()
        {
            model.WorkerDataLoad.workerDataLoad();
        }
    }
}
