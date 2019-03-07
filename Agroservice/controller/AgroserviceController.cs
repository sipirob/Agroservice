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
        private model.SetDoneWork setDoneWorkInDatabase;
        private model.LoadParcelData loadParcelDataList;
        

       
        private model.SetPlantDistance plantDistance;

       
        public AgroserviceController()
        {
            clientDataLoad = new model.ClientDataLoad();
            workerDataLoad = new model.WorkerDataLoad();
            newWorkDataLoad = new model.NewWorkDataLoad();
            loadUsername = new model.LoadUsername();
            completeWorkDataLoad = new model.CompleteWorkDataLoad();
            loadParcelMap = new model.LoadParcelMap();
            setDoneWorkInDatabase = new model.SetDoneWork();
            loadParcelDataList = new model.LoadParcelData();
            plantDistance = new model.SetPlantDistance();
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

        /// <summary>
        /// parcella cooordinátáinak kiolvasása tömbből
        /// </summary>
        /// <param name="parcelnumber"></param>
        /// <returns>parcella koordinátáinak tömbje</returns>
        internal string[] getLoadParcelMapCoordinates(string parcelnumber)
        {
            string[] coordinates = model.LoadParcelMap.LoadParcelCoordinates(parcelnumber);
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
        /// <summary>
        /// Munkálat elvégzésének visszaigazolása
        /// </summary>
        /// <param name="workId">A kiválasztott munkálat id-je</param>
        internal void setDoneWork(int workId)
        {
            model.SetDoneWork.setDoneWorkInDatabase(workId);
        }

        /// <summary>
        /// kiválasztott termőföldhöz tartozó parcella adatainak lekérése
        /// </summary>
        /// <param name="parcelnumber"></param>
        /// <returns>a parcella területe hektárban</returns>
        internal double loadParcelData(string parcelnumber)
        {
           double parcelHa= model.LoadParcelData.getParcelData(parcelnumber);
            return parcelHa;
        }

        internal void parcelDataloadFromList()
        {
            model.LoadParcelData.parcelDataLoad();
        }
        /// <summary>
        /// Szükséges permetszer mennyiségének kiszámolása adott parcellához
        /// </summary>
        /// <param name="parcelHa">a kiválasztott termőföld területe hektárban</param>
        /// <param name="pesticidLiter">a permetszer szükséges hektáronkénti liter mennyisége</param>
        /// <returns>eredmény</returns>
        internal string calculatePesticid(double parcelHa, double pesticidLiter)
        {
            string result = Convert.ToString(parcelHa * pesticidLiter);
            return result;
        }

        internal void loadVegetablesDistance()
        {
            model.SetPlantDistance.setCornDistance();
        }

        //public int calculateSeed(string plantDistance)
        //{
        //   DataTable graincropDis = model.SetPlantDistance.getSeedDatatable();
        //   foreach(DataRow dr in graincropDis.Columns)
        //    {
        //        if(graincropDis.Columns.ToString()==plantDistance)
                    
        //    }
            
        //}
        internal DataTable loadGraincropDistanceDt()
        {
           DataTable graincropDis= model.SetPlantDistance.getSeedDatatable();
            return graincropDis;
            
        }
        /// <summary>
        /// Ügyfél keresése név alapján
        /// </summary>
        /// <param name="clientname">a keresett ügyfél neve</param>
        /// <returns>keresett ügyfél adatai</returns>
        internal DataTable searchClient(string clientname)
        {
            DataTable client = model.ClientDataLoad.returnSearchedClient(clientname);
            return client;
        }


    }
}
