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
        private controller.LastWorkerId searchLastWorkerid;
        private controller.RegistryNewWorker registryNewWorkerData;
        private controller.ManageService manageService;

        
        private controller.LoadServices loadServices;
        

       
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
            searchLastWorkerid = new controller.LastWorkerId();
            registryNewWorkerData = new controller.RegistryNewWorker();
            loadServices = new controller.LoadServices();
            manageService = new controller.ManageService();
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

        internal void getUpdateWorkerData(int workerid, string workerName, DateTime workerBirthday, string workerPlace, int workerTelnumb)
        {
            controller.UpdateWorkerData.updateWorkerData(workerid, workerName, workerBirthday, workerPlace, workerTelnumb);
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

        /// <summary>
        /// termőföld adatainak lekérése
        /// </summary>
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

        /// <summary>
        /// tőtávolság lekérése
        /// </summary>
        internal void loadVegetablesDistance()
        {
            controller.SetPlantDistance.setCornDistance();
        }
        /// <summary>
        /// Szükésges vetőmag száma az adott parcellába, kiszámítása
        /// </summary>
        /// <param name="plantDisValue">tőtávolság</param>
        /// <param name="parcelHa">kiválazstott parcella területe</param>
        /// <returns></returns>
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

        /// <summary>
        /// Dolgozók nevének és azonosítójának lekérése
        /// </summary>
        /// <returns>Dolgozó neve és a hozzá tartozó azonosító</returns>
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
        /// <summary>
        /// Ügyfel törlése az adatbázisból
        /// </summary>
        /// <param name="clientid">Ügyfél id-ja</param>
        internal void getdeleteUser(int clientid)
        {
            controller.DeleteUser.deleteUser(clientid);
        }
        /// <summary>
        /// Törli a kiválasztott dolgozót az adatbázisból
        /// </summary>
        /// <param name="workerid">Dolgozó id-ja</param>
        internal void getDeleteWorker(int workerid)
        {
            controller.DeleteWorker.deleteWorker(workerid);
        }/// <summary>
        /// Kiválasztott dolgozó adatainak lekérése listából
        /// </summary>
        /// <param name="workerid">Dolgozó azonosítója</param>
        /// <returns>Kiválasztott dolgozó adatai</returns>
        internal DataTable getSelectedWorkerdata(int workerid)
        {
           return controller.WorkerDataLoad.getSelectedWorkerData(workerid);
        }
        //internal void getUpdateWorkerdata(DataTable workerdata)
        //{
        //    controller.UpdateDatatable.updateWorkerData(workerdata);
        //}
        /// <summary>
        /// Dolgozók adatainak listáját törli
        /// </summary>
        internal void getClearWorkerList()
        {
            controller.WorkerDataLoad.clearWorkerList();
        }

        /// <summary>
        /// Elvégzett munkálatok listáját törli
        /// </summary>
        internal void getClearCompleteWorksList()
        {
            controller.CompleteWorkDataLoad.clearCompleteWorksList();
        }
        /// <summary>
        /// Ügyfelek listáját törli
        /// </summary>
        internal void getClearClientsDataList()
        {
            controller.ClientDataLoad.clearClientsDataList();
        }

        internal DataTable getSearchWorkByClientName(string clientname)
        {
            DataTable work = controller.CompleteWorkDataLoad.searchWorkByClientName(clientname);
            return work;
        }
        internal DataTable getSearchWorkByWorkerName(string workername)
        {
            DataTable work = controller.CompleteWorkDataLoad.searchWorkByWorker(workername);
            return work;
        }

        internal object getSearchWorkComplex(string workername, string clientname)
        {
            DataTable work = controller.CompleteWorkDataLoad.searchWorkByWorkerAndClientname(workername,clientname);
            return work;
        }


        internal int getSearchLastWorkerId()
        {
            int id = searchLastWorkerid.searchLastWorkerId();
            return id;
        }
        internal void getInsertNewWorkerData(string workerName, DateTime workerBirthday, string workerPlace, int workerTelnumb)
        {
            registryNewWorkerData.setNewWorkerData(workerName, workerBirthday, workerPlace, workerTelnumb);
        }

        internal void getInsertNewWorker(int newWorkerId, string username, string password ,int category)
        {
            registryNewWorkerData.insertNewWorker(newWorkerId,username,password, category);
        }

        internal int getNumberOfNewWorks()
        {
            int numb = controller.NewWorkDataLoad.countNewWork();
            return numb;
        }
        internal DataTable getLoadServiceName()
        {
            DataTable sdata = controller.LoadServices.getServiceData();
            return sdata;
        }
        internal void getloadServiceData()
        {
            controller.LoadServices.serviceDataLoad();
        }
        internal DataTable getSelectedService(int serviceid)
        {
            DataTable servicedt = controller.LoadServices.selectedServicenameData(serviceid);
            return servicedt;
        }
        internal void addNewService(string servicename, int servicePrice)
        {
            controller.ManageService.getAddNewService(servicename,servicePrice);
        }

        internal void getDelteService(int serviceid)
        {
            controller.ManageService.getDeleteService(serviceid);
        }
        internal void updateServiceData(int serviceid, string servicename, int servicePrice)
        {
            controller.ManageService.getUpdateService(serviceid, servicename, servicePrice);
        }

    }
}
