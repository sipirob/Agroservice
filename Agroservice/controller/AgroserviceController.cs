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
        private model.NewWorkDataLoad newWorkDataLoad;
        private model.LoadUsername loadUsername;
       
        public AgroserviceController()
        {
            clientDataLoad = new model.ClientDataLoad();
            workerDataLoad = new model.WorkerDataLoad();
            newWorkDataLoad = new model.NewWorkDataLoad();
            loadUsername = new model.LoadUsername();
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

      

        internal DataTable getNewWorkData()
        {
            DataTable newWorkDT = model.NewWorkDataLoad.getClientDataFromList();
            return newWorkDT;
        }
        public void loadNewWorkData()
        {
            model.NewWorkDataLoad.newWorkDataLoad();
            //model.NewWorkDataLoad.newWorkDataLoad();
        }

        internal string getloadUsername()
        {
            string username = model.LoadUsername.getUsername();
            return username;
                
        }
        public void usernameLoad()
        {
            model.LoadUsername.workerDataLoad();
        }
    }
}
