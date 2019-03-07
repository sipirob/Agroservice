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

                //points.Add(new PointLatLng(Convert.ToDouble(latlong[0]), Convert.ToDouble(latlong[1])));
                //points.Add(new PointLatLng(Convert.ToDouble(latlong[2]), Convert.ToDouble(latlong[3])));
                //points.Add(new PointLatLng(Convert.ToDouble(latlong[4]), Convert.ToDouble(latlong[5])));
                //points.Add(new PointLatLng(Convert.ToDouble(latlong[6]), Convert.ToDouble(latlong[7])));


                //GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
                //polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
                //polygon.Stroke = new Pen(Color.Red, 1);
                //polyOverlay.Polygons.Add(polygon);
                //ucw.gMapControlParcelMap.Overlays.Add(polyOverlay);


                //double lat = Convert.ToDouble(latlong[4]);
                //double longt = Convert.ToDouble(latlong[7]);
                //ucw.gMapControlParcelMap.Position = new PointLatLng(lat, longt);
                //MessageBox.Show(latlong[0]);
            }
            
            

            dr.Close();
            connection.Close();
            return latlong;
            
        }
        
        //public static List<PointLatLng> getParcelmapCoordinatesFromList()
        //{
        //    UserControlNewWorks ucw = new UserControlNewWorks();
        //    List<PointLatLng> points = new List<PointLatLng>();
        //    points.Add(new PointLatLng(Convert.ToDouble(latlong[0]), Convert.ToDouble(latlong[1])));
        //    points.Add(new PointLatLng(Convert.ToDouble(latlong[2]), Convert.ToDouble(latlong[3])));
        //    points.Add(new PointLatLng(Convert.ToDouble(latlong[4]), Convert.ToDouble(latlong[5])));
        //    points.Add(new PointLatLng(Convert.ToDouble(latlong[6]), Convert.ToDouble(latlong[7])));


        //    //GMapPolygon polygon = new GMapPolygon(points, "mypolygon");
        //    //polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
        //    //polygon.Stroke = new Pen(Color.Red, 1);
        //    //polyOverlay.Polygons.Add(polygon);
        //    //ucw.gMapControlParcelMap.Overlays.Add(polyOverlay);


        //    double lat = Convert.ToDouble(latlong[4]);
        //    double longt = Convert.ToDouble(latlong[7]);
        //    ucw.gMapControlParcelMap.Position = new PointLatLng(lat, longt);

        //    return points;
        //}
    }
}
