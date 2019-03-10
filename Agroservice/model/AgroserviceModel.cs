using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using GMap.NET;

namespace Agroservice.model
{
   
   public class AgroserviceModel
    {
        private controller.ClientDataLoad clientDataLoad;
        private controller.WorkerDataLoad workerDataLoad;
        private controller.NewWorkDataLoad newWorkDataLoad;
        private controller.LoadUsername loadUsername;
        private controller.CompleteWorkDataLoad completeWorkDataLoad;
        private controller.LoadParcelMap loadParcelMap;
        private controller.SetDoneWork setDoneWorkInDatabase;
        private controller.LoadParcelData loadParcelDataList;
        private controller.SetWorkerOfWork setWorkerofWork;
        

       
        private controller.SetPlantDistance plantDistance;

       
        public AgroserviceModel()
        {
            clientDataLoad = new controller.ClientDataLoad();
            workerDataLoad = new controller.WorkerDataLoad();
            newWorkDataLoad = new controller.NewWorkDataLoad();
            loadUsername = new controller.LoadUsername();
            completeWorkDataLoad = new controller.CompleteWorkDataLoad();
            loadParcelMap = new controller.LoadParcelMap();
            setDoneWorkInDatabase = new controller.SetDoneWork();
            loadParcelDataList = new controller.LoadParcelData();
            plantDistance = new controller.SetPlantDistance();
            setWorkerofWork = new controller.SetWorkerOfWork();
        }

       

        /// <summary>
        /// Ügyfelek adatainak lekérése listából
        /// </summary>
        /// <returns>Ügyfelek adatainak listája</returns>
        internal DataTable getClientData()
        {
            DataTable clientDT = controller.ClientDataLoad.getClientDataFromList();
            return clientDT;
        }
        /// <summary>
        /// Ügyfelek adatainak lekérése adatbázisból
        /// </summary>
        public void loadClientData()
        {
            controller.ClientDataLoad.clientDataLoad();
        }


        /// <summary>
        /// Dolgozók adatainak lekérése listából
        /// </summary>
        /// <returns>Dolgozók adatainak listája</returns>
        internal DataTable getWorkerData()
        {
            DataTable workerDT = controller.WorkerDataLoad.getWorkerDataFromList();
            return workerDT;
        }
        /// <summary>
        /// Dolgozók adatainak lekérése adatbázisból
        /// </summary>
        public void loadWorkerData()
        {
            controller.WorkerDataLoad.workerDataLoad();
        }

        internal DataTable getCompleteWorksData()
        {
            DataTable compWorkData = controller.CompleteWorkDataLoad.getCompleteWorkDataFromList();
            return compWorkData;
        }

        public void loadCompleteData()
        {
            controller.CompleteWorkDataLoad.completeWorkDataLoad();
        }


        /// <summary>
        /// A még el nem végzett munkálatok listájának lekérése
        /// </summary>
        /// <returns>Az el nem végzett munkálatok listája</returns>
        internal DataTable getNewWorkData()
        {
            DataTable newWorkDT = controller.NewWorkDataLoad.getNewWorkDataFromList();
            return newWorkDT;
        }


        /// <summary>
        /// Az el nem végzett munkálatok lekérése adatbázisból
        /// </summary>
        public void loadNewWorkData()
        {
            controller.NewWorkDataLoad.newWorkDataLoad();
           
        }

        /// <summary>
        /// a belépett felhasználó nevének lekérése listából
        /// </summary>
        /// <returns>A belépett felhasználó neve</returns>
        internal string getloadUsername()
        {
            string username = controller.LoadUsername.getUsername();
            return username;
                
        }

      

        /// <summary>
        /// A belépett felhasználó nevének lekérdezése adatbázisból
        /// </summary>
        public void usernameLoad()
        {
            controller.LoadUsername.workerDataLoad();
        }

        /// <summary>
        /// parcella cooordinátáinak kiolvasása tömbből
        /// </summary>
        /// <param name="parcelnumber"></param>
        /// <returns>parcella koordinátáinak tömbje</returns>
        internal string[] getLoadParcelMapCoordinates(string parcelnumber)
        {
            string[] coordinates = controller.LoadParcelMap.LoadParcelCoordinates(parcelnumber);
            return coordinates;
        }

        /// <summary>
        /// A bejelentkezett dolgozó el nem végzett munkálatainak számának lekérése
        /// </summary>
        /// <returns>Bejelentkezett dolgozó nem végzett munkálatainak száma</returns>
        internal string loadNewWorksNumber(string username)
        {
            string newWorksNumber= controller.LoadNewWorksNumber.newWorksNumberLoad(username);
            return newWorksNumber;
        }
        /// <summary>
        /// Munkálat elvégzésének visszaigazolása
        /// </summary>
        /// <param name="workId">A kiválasztott munkálat id-je</param>
        internal void setDoneWork(int workId)
        {
            controller.SetDoneWork.setDoneWorkInDatabase(workId);
        }

        /// <summary>
        /// kiválasztott termőföldhöz tartozó parcella adatainak lekérése
        /// </summary>
        /// <param name="parcelnumber"></param>
        /// <returns>a parcella területe hektárban</returns>
        internal double loadParcelData(string parcelnumber)
        {
           double parcelHa= controller.LoadParcelData.getParcelData(parcelnumber);
            return parcelHa;
        }

        internal void parcelDataloadFromList()
        {
            controller.LoadParcelData.parcelDataLoad();
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
            controller.SetPlantDistance.setCornDistance();
        }

        public double calculateSeed(int plantDisValue,double parcelHa)
        {
            double needSeed = Convert.ToDouble(plantDisValue) * parcelHa;
            return needSeed;

        }
        /// <summary>
        /// vetőmag tőtávolságának és a hozzá tartozó magszám adatainak lekérése
        /// </summary>
        /// <returns>tőtávolság, vetőmag adattáblája</returns>
        internal DataTable loadGraincropDistanceDt()
        {
            DataTable graincropDis = controller.SetPlantDistance.plantDistanceWithValue();
            return graincropDis;
            
        }
        /// <summary>
        /// Ügyfél keresése név alapján
        /// </summary>
        /// <param name="clientname">a keresett ügyfél neve</param>
        /// <returns>keresett ügyfél adatai</returns>
        internal DataTable searchClient(string clientname)
        {
            DataTable client = controller.ClientDataLoad.returnSearchedClient(clientname);
            return client;
        }


        internal DataTable getWorkersName()
        {
            DataTable workersname = controller.WorkerDataLoad.getWorkersName();
            return workersname;
        }
        /// <summary>
        /// Dolgozó hozzárendelése munkálathoz
        /// </summary>
        /// <param name="workerId">kiválasztott dolgozó id-ja</param>
        /// <param name="workId">a kiválasztott munkálat id-ja</param>
        internal void setWorkerOfWork(int workerId, int workId)
        {
            controller.SetWorkerOfWork.setWorker(workerId, workId);
        }
        internal void getdeleteUser(int clientid)
        {
            controller.DeleteUser.deleteUser(clientid);
        }

        internal void getDeleteWorker(int workerid)
        {
            controller.DeleteWorker.deleteWorker(workerid);
        }
    }
}
