using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace Agroservice.controller
{
    class LoadParcelMap
    {
        public static string[] latlong;
        public static string[] LoadParcelCoordinates(string parcelnumber)
        {
          
            UserControlNewWorks ucw = new UserControlNewWorks();
            ucw.gMapControlParcelMap.MapProvider = GMapProviders.GoogleSatelliteMap;

            ucw.gMapControlParcelMap.MinZoom = 1;
            ucw.gMapControlParcelMap.MaxZoom = 100;
            ucw.gMapControlParcelMap.Zoom = 16;
            MySqlConnection connection = new MySqlConnection(controller.Connection.connectionString);

            string query = "SELECT `coordinates` FROM `parcels` WHERE parcelnumber = '" + parcelnumber  + "'";
            MySqlCommand cmd = new MySqlCommand(query,connection);
            connection.Open();
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();

           
            while (dr.Read())
            {
                GMapOverlay polyOverlay = new GMapOverlay("polygons");
               latlong = dr[0].ToString().Split(' ');
               
                List<PointLatLng> points = new List<PointLatLng>();

              
            }
            
            

            dr.Close();
            connection.Close();
            return latlong;
            
        }
        
      
    }
}
