using MysSqlDataGridViewHalak;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.model
{
    class ConnectToDatabase
    {
        public MySQLDatabaseInterface connect()
        {
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            mdi.setErrorToUserInterface(true);
            mdi.setErrorToGraphicalUserInterface(true);
            mdi.setConnectionServerData("localhost", "agroservice", "3306");
            mdi.setConnectionUserData("root", "");
            mdi.makeConnectionToDatabase();
            return mdi;
        }
    }
}
