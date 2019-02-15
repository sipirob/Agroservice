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
       /// <summary>
       /// Ügyfelek adatainak lekérése listából
       /// </summary>
       /// <returns>Ügyfelek adatainak listája</returns>
        internal DataTable getClientData()
        {
            DataTable clientDT = model.ClientDataLoad.getClientDataFromList();
            return clientDT;
        }
        /// <summary>
        /// Ügyfelek adatainak lekérése adatbázisból
        /// </summary>
        public void loadClientData()
        {
            model.ClientDataLoad.clientDataLoad();
        }

        /// <summary>
        /// Dolgozók adatainak lekérése listából
        /// </summary>
        /// <returns>Dolgozók adatainak listája</returns>
        internal DataTable getWorkerData()
        {
            DataTable workerDT = model.WorkerDataLoad.getWorkerDataFromList();
            return workerDT;
        }
        /// <summary>
        /// Dolgozók adatainak lekérése adatbázisból
        /// </summary>
        public void loadWorkerData()
        {
            model.WorkerDataLoad.workerDataLoad();
        }

      
        /// <summary>
        /// A még el nem végzett munkálatok listájának lekérése
        /// </summary>
        /// <returns>Az el nem végzett munkálatok listája</returns>
        internal DataTable getNewWorkData()
        {
            DataTable newWorkDT = model.NewWorkDataLoad.getClientDataFromList();
            return newWorkDT;
        }
        /// <summary>
        /// Az el nem végzett munkálatok lekérése adatbázisból
        /// </summary>
        public void loadNewWorkData()
        {
            model.NewWorkDataLoad.newWorkDataLoad();
           
        }

        /// <summary>
        /// a belépett felhasználó nevének lekérése listából
        /// </summary>
        /// <returns>A belépett felhasználó neve</returns>
        internal string getloadUsername()
        {
            string username = model.LoadUsername.getUsername();
            return username;
                
        }
        /// <summary>
        /// A belépett felhasználó nevének lekérdezése adatbázisból
        /// </summary>
        public void usernameLoad()
        {
            model.LoadUsername.workerDataLoad();
        }
    }
}
