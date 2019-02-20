using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agroservice.controller;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms;
using GMap.NET;

namespace Agroservice
{
    public partial class UserControlNewWorks : UserControl 
    {
        public static string parcelnumber;
        AgroserviceController controller = new AgroserviceController();
        GMapPolygon polygon;
        int openlayer = 0;
        
        public UserControlNewWorks()
        {
            InitializeComponent();
            gMapControlParcelMap.MapProvider = GMapProviders.GoogleSatelliteMap;
            gMapControlParcelMap.MinZoom = 1;
            gMapControlParcelMap.MaxZoom = 100;
            gMapControlParcelMap.Zoom = 16;
            
        }

        private void listViewNewWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            gMapControlParcelMap.Show();
            if (openlayer > 0)
            {
                polygon.Clear();
            }
           
            if (listViewNewWork.SelectedItems.Count > 0)
            {
                 ListViewItem item = listViewNewWork.SelectedItems[0];
                 parcelnumber = item.SubItems[1].Text;
               
                GMapOverlay polyOverlay = new GMapOverlay("polygons");
                controller.getLoadParcelMapCoordinates();
                string[] latlong = controller.getLoadParcelMapCoordinates();

                List<PointLatLng> points = new List<PointLatLng>();

                points.Add(new PointLatLng(Convert.ToDouble(latlong[0]), Convert.ToDouble(latlong[1])));
                points.Add(new PointLatLng(Convert.ToDouble(latlong[2]), Convert.ToDouble(latlong[3])));
                points.Add(new PointLatLng(Convert.ToDouble(latlong[4]), Convert.ToDouble(latlong[5])));
                points.Add(new PointLatLng(Convert.ToDouble(latlong[6]), Convert.ToDouble(latlong[7])));

                polygon = new GMapPolygon(points, "mypolygon");
                polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
                polygon.Stroke = new Pen(Color.Red, 1);
                polyOverlay.Polygons.Add(polygon);
                gMapControlParcelMap.Overlays.Add(polyOverlay);

                double lat = Convert.ToDouble(latlong[4]);
                double longt = Convert.ToDouble(latlong[7]);
                gMapControlParcelMap.Position = new PointLatLng(lat, longt);
                openlayer += 1;
                
            }
            
           
          


            //double lat = Convert.ToDouble(latlong[4]);
            //double longt = Convert.ToDouble(latlong[7]);
            //ucw.gMapControlParcelMap.Position = new PointLatLng(lat, longt);
            //MessageBox.Show(latlong[0]);
            //controller.loadMap();
            //GMapOverlay polyOverlay = new GMapOverlay("polygons");
            //GMapPolygon polygon = new GMapPolygon(controller.getLoadParcelMapCoordinates(), "mypolygon");
            //polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            //polygon.Stroke = new Pen(Color.Red, 1);
            //polyOverlay.Polygons.Add(polygon);
            //gMapControlParcelMap.Overlays.Add(polyOverlay);
        }

    }
}
