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
using GMap.NET.WindowsForms.Markers;

namespace Agroservice
{
    public partial class UserControlNewWorks : UserControl 
    {
        public static string parcelnumber;
        AgroserviceController controller = new AgroserviceController();
        GMapPolygon polygon;
        int openlayer = 0;
        PointLatLng endposition;
        PointLatLng startposition;


        public UserControlNewWorks()
        {
            InitializeComponent();
            gMapControlParcelMap.MapProvider = GMapProviders.GoogleSatelliteMap;
            gMapControlParcelMap.MinZoom = 1;
            gMapControlParcelMap.MaxZoom = 100;
            gMapControlParcelMap.Zoom = 15;
            gMapControlParcelMap.DragButton = MouseButtons.Left;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

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

                double lat = Convert.ToDouble(latlong[6]);
                double longt = Convert.ToDouble(latlong[7]);
                gMapControlParcelMap.Position = new PointLatLng(lat, longt);
                openlayer += 1;

                endposition = points[3];
                startposition = new PointLatLng(46.247612, 20.060842);
                
            }
            
        }

        private void buttonRoute_Click(object sender, EventArgs e)
        {
          

            //var route = GoogleMapProvider.Instance.GetRoute(startposition, endposition, false, false, 14);
            //var r = new GMapRoute(route.Points, "My Route");
            //var routes = new GMapOverlay("routes");
            //routes.Routes.Add(r);
            //gMapControlParcelMap.Overlays.Add(routes);
            //r.Stroke.Width = 2;
            //r.Stroke.Color = Color.SeaGreen;

            //PointLatLng startp = new PointLatLng(-25.974134, 32.593042);
            //PointLatLng endp = new PointLatLng(-25.959048, 32.592827);
            //MapRoute route = BingMapProvider.Instance.GetRoute(startp, endp, false, false, 15);
            //GMapRoute r = new GMapRoute(route.Points, "Myroutes");
            //GMapOverlay routesOverlay = new GMapOverlay("Myroutes");
            //routesOverlay.Routes.Add(r);
            //gMapControlParcelMap.Overlays.Add(routesOverlay);
            //r.Stroke.Width = 2;
            //r.Stroke.Color = Color.SeaGreen;

            MapRoute route = GMap.NET.MapProviders.OpenStreetMapQuestProvider.Instance.GetRoute(startposition, endposition, true, false, 11);
            GMapRoute r = new GMapRoute(route.Points, "My route");
            GMapOverlay routesOverlay = new GMapOverlay("routes");
            routesOverlay.Routes.Add(r);
            r.Stroke.Width = 4;
            r.Stroke.Color = Color.SkyBlue;
            gMapControlParcelMap.Overlays.Add(routesOverlay);

            gMapControlParcelMap.UpdateRouteLocalPosition(r);

            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(
            new PointLatLng(46.247612, 20.060842),
            GMarkerGoogleType.blue_pushpin);
            markers.Markers.Add(marker);
            gMapControlParcelMap.Overlays.Add(markers);
            gMapControlParcelMap.Position = new PointLatLng(46.247612, 20.060842);
            gMapControlParcelMap.Zoom = 12;


        }
    }
}
