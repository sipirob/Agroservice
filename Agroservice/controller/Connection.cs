using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.controller
{
    class Connection
    {
       public static string connectionString =
                 "SERVER=\"127.0.0.1\";"
                 + "DATABASE=\"agroservice\";"
                 + "UID=\"root\";"
                 + "PASSWORD=\"\";"
                 + "PORT=\"3306\";"
                 + "SslMode=none";
       // MySqlConnection connection = new MySqlConnection(connectionString);

    }
}
