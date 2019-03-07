using MysSqlDataGridViewHalak;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.controller
{
    class LoadNewWorksNumber
    {
        
        internal static string newWorksNumberLoad(string username)
        {
            string numb ="";
            ConnectToDatabase a = new ConnectToDatabase();
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            mdi = a.connect();
            mdi.open();
            string query = "SELECT COUNT(work.id) FROM `work`,worker,workerdata where worker.id=workerdata.id and work.workerid=worker.id and done=0 and worker.username='" + username + "'";
            DataTable worksnumb = new DataTable();
            worksnumb = mdi.getToDataTable(query);
            foreach (DataRow row in worksnumb.Rows)
            {
                 numb = row[0].ToString();
            }
                //string newWorksNumb = worksnumb.Rows[0].ToString();
            mdi.close();
            return numb;
        }
    }
}
