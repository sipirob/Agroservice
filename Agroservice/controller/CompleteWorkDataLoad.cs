using MysSqlDataGridViewHalak;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.controller
{
    class CompleteWorkDataLoad
    {
        private bool leader;
        private static List<repository.Work> Work;



        public CompleteWorkDataLoad()
        {
            leader = FormSignIn.leader;
            Work = new List<repository.Work>();
        }

        public static void completeWorkDataLoad()
        {
            try
            {
                loadCompleteWork();
            }
            catch (Exception e)
            {

            }
        }

        private static void loadCompleteWork()
        {
            //FormSignIn si = new FormSignIn();
            ConnectToDatabase a = new ConnectToDatabase();
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            mdi = a.connect();
            mdi.open();
            string query = "";
            if (FormSignIn.leader == true)
            {
                query = "SELECT work.id,`date`,`parcelnumber`,`workname`,`graincropname`,clientdata.name as clientname, workerdata.name as workername,`rating`,`comment`,`price`,`done` FROM worker,client,`work`,clientdata, workerdata where work.workerid=worker.id and work.clientid=client.id and worker.id=workerdata.id and client.id=clientdata.id and done=1";
            }
            else
                query = "SELECT work.id,`date`,`parcelnumber`,`workname`,`graincropname`,clientdata.name as clientname, workerdata.name as workername,`rating`,`comment`,`price`,`done` FROM worker,client,`work`,clientdata, workerdata where work.workerid=worker.id and work.clientid=client.id and worker.id=workerdata.id and client.id=clientdata.id and done=1 and worker.username='" + FormSignIn.username + "'";


            DataTable completeworkdt = new DataTable();
            completeworkdt = mdi.getToDataTable(query);
            loadCompleteWorkList(completeworkdt);
            mdi.close();
        }



        private static void loadCompleteWorkList(DataTable completeworkdt)
        {
            foreach (DataRow row in completeworkdt.Rows)
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
                repository.Work w = new repository.Work(id, date, parcelnumber, servicename, graincropname, clientname, workername, rating, comment, price, done);
                Work.Add(w);
            }
        }

        public static DataTable getCompleteWorkDataFromList()
        {

            DataTable cpWorkDT = new DataTable();
            cpWorkDT.Columns.Add("dátum", typeof(DateTime));
            cpWorkDT.Columns.Add("parcellaszám", typeof(int));
            cpWorkDT.Columns.Add("munkálat neve", typeof(string));
            cpWorkDT.Columns.Add("gabona", typeof(string));
            cpWorkDT.Columns.Add("értékelés", typeof(int));
            cpWorkDT.Columns.Add("hozzászólás", typeof(string));
            foreach (repository.Work w in Work)
            {
                cpWorkDT.Rows.Add(w.getDate(), w.getParcelnumber(), w.getServicename(), w.getGraincropname(), w.getRating(),w.getComment());

            }

            return cpWorkDT;

        }
    }
}
