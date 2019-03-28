using Agroservice.repository;
using MysSqlDataGridViewHalak;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.controller
{
    class NewWorkDataLoad
    {
        
        private static List<repository.Work> Work;

       

        public NewWorkDataLoad()
        {
            Work = new List<repository.Work>();
        }

        public static void newWorkDataLoad()
        {
            try
            {
                loadNewWork();
            }
            catch (Exception e)
            {

            }
        }

        private static void loadNewWork()
        {
            FormSignIn si = new FormSignIn();
            ConnectToDatabase a = new ConnectToDatabase();
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            mdi = a.connect();
            mdi.open();
            string query = "";
            if(FormSignIn.leader == true)
            {
                // query = "SELECT work.id,`date`,`parcelnumber`,`workname`,`graincropname`,clientdata.name as clientname, workerdata.name as workername,`rating`,`comment`,`price`,`done` FROM worker,client,`work`,clientdata, workerdata where work.workerid=worker.id and work.clientid=client.id and worker.id=workerdata.id and client.id=clientdata.id and done=0 and workerid=0";
                query = "SELECT work.id,`date`,`parcelnumber`,`workname`,`graincropname`,clientdata.name as clientname,workerid as workername, `rating`,`comment`,`price`,`done` FROM worker,client,`work`,clientdata where work.clientid=client.id and client.id=clientdata.id and work.workerid is null group by id";
                DataTable newworkdt = new DataTable();
                newworkdt = mdi.getToDataTable(query);
                loadNewWorkList(newworkdt);
                mdi.close();
            }
            else if (FormSignIn.leader==false)
            {
                query = "SELECT work.id,`date`,`parcelnumber`,`workname`,`graincropname`,clientdata.name as clientname, workerdata.name as workername,`rating`,`comment`,`price`,`done` FROM worker,client,`work`,clientdata, workerdata where work.workerid=worker.id and work.clientid=client.id and worker.id=workerdata.id and client.id=clientdata.id and done=0 and worker.username='" + FormSignIn.username + "'";
                DataTable newworkdt = new DataTable();
                newworkdt = mdi.getToDataTable(query);
                loadNewWorkList(newworkdt);
                mdi.close();
            }
           
           
        }



        public static void loadNewWorkList(DataTable newworkdt)
        {
            foreach (DataRow row in newworkdt.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                DateTime date = Convert.ToDateTime(row[1]);
                int parcelnumber = Convert.ToInt32(row[2]);
                string servicename = row[3].ToString();
                string graincropname = row[4].ToString();
                string clientname = row[5].ToString();
                string workername = row[6].ToString();
                int rating = Convert.ToInt32(row[7]);
                string comment = row[8].ToString();
                int price = Convert.ToInt32(row[9]);
                bool done = Convert.ToBoolean(row[10]);
                repository.Work w = new repository.Work(id, date, parcelnumber,servicename,graincropname,clientname,workername,rating,comment,price,done );
                Work.Add(w);
            }
        }

        public static DataTable getNewWorkDataFromList()
        {

            DataTable newWorkDT = new DataTable();
            newWorkDT.Columns.Add("Id", typeof(int));
            newWorkDT.Columns.Add("dátum", typeof(DateTime));
            newWorkDT.Columns.Add("parcellaszám", typeof(int));
            newWorkDT.Columns.Add("munkálat neve", typeof(string));
            newWorkDT.Columns.Add("gabona", typeof(string));
            newWorkDT.Columns.Add("Ügyfél", typeof(string));
            newWorkDT.Columns.Add("Megjegyzés", typeof(string));
            newWorkDT.Columns.Add("Ár", typeof(int));
            foreach (repository.Work w in Work)
            {
                newWorkDT.Rows.Add(w.getId(), w.getDate(), w.getParcelnumber(), w.getServicename(), w.getGraincropname(),w.getClientname(),w.getComment(),w.getPrice());

            }

            return newWorkDT;

        }
       public static int countNewWork()
        {
            int sum = 0;
            foreach (Work w in Work)
            {
                sum += 1;
            }
               
            return sum;
        }

        internal static void clerNewWorkList()
        {
            Work.Clear();
        }
    }
}
