using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using GMap.NET;

namespace Agroservice.controller
{
   
   public class AgroserviceController
    {
        private model.ClientDataLoad clientDataLoad;
        private model.WorkerDataLoad workerDataLoad;
        private model.NewWorkDataLoad newWorkDataLoad;
        private model.LoadUsername loadUsername;
        private model.CompleteWorkDataLoad completeWorkDataLoad;
        private model.LoadParcelMap loadParcelMap;
       
        public AgroserviceController()
        {
            clientDataLoad = new model.ClientDataLoad();
            workerDataLoad = new model.WorkerDataLoad();
            newWorkDataLoad = new model.NewWorkDataLoad();
            loadUsername = new model.LoadUsername();
            completeWorkDataLoad = new model.CompleteWorkDataLoad();
            loadParcelMap = new model.LoadParcelMap();
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

        internal DataTable getCompleteWorksData()
        {
            DataTable compWorkData = model.CompleteWorkDataLoad.getCompleteWorkDataFromList();
            return compWorkData;
        }

        public void loadCompleteData()
        {
            model.CompleteWorkDataLoad.completeWorkDataLoad();
        }


        /// <summary>
        /// A még el nem végzett munkálatok listájának lekérése
        /// </summary>
        /// <returns>Az el nem végzett munkálatok listája</returns>
        internal DataTable getNewWorkData()
        {
            DataTable newWorkDT = model.NewWorkDataLoad.getNewWorkDataFromList();
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

        //public void loadMap()
        //{
        //    model.LoadParcelMap.LoadParcelCoordinates();
        //}
        //internal List<PointLatLng> getLoadParcelMapCoordinates()
        //{
        //    List<PointLatLng> coordinates = model.LoadParcelMap.getParcelmapCoordinatesFromList();
        //    return coordinates;
        //}
        internal string[] getLoadParcelMapCoordinates()
        {
            string[] coordinates = model.LoadParcelMap.LoadParcelCoordinates();
            return coordinates;
        }

        /// <summary>
        /// A bejelentkezett dolgozó el nem végzett munkálatainak számának lekérése
        /// </summary>
        /// <returns>Bejelentkezett dolgozó nem végzett munkálatainak száma</returns>
        internal string loadNewWorksNumber(string username)
        {
            string newWorksNumber= model.LoadNewWorksNumber.newWorksNumberLoad(username);
            return newWorksNumber;
        }
    }
}
