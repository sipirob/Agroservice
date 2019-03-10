using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MysSqlDataGridViewHalak;

namespace Agroservice.controller
{
    class UpdateDatatable
    {
        public static MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
        internal static void updateWorkerData(DataTable workerdata)
        {
           
            mdi.updateChangesInTable(workerdata);
        }
    }
}
