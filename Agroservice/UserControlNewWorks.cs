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
        View.FormCalculator formCalc;
        model.AgroserviceModel model = new model.AgroserviceModel();
        GMapPolygon polygon;
        int openlayer = 0;
        PointLatLng endposition;
        PointLatLng startposition;
        GMapRoute r;
        int workId;//kiválasztott munkálat ID-je
        bool existRoute = false;
        string parcelnumber;


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

            gMapControlParcelMap.Zoom = 15;//a térkép alap zoom távolsága
            gMapControlParcelMap.Show();
            if (existRoute==true)
            {
                r.Clear();
            }
            if (openlayer > 0)
            {
                polygon.Clear();
            }

            //Parcella polygon megjelenítése a térképen
            if (listViewNewWork.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewNewWork.SelectedItems[0];
                parcelnumber = item.SubItems[2].Text;
                workId = Convert.ToInt32(item.SubItems[0].Text);
                GMapOverlay polyOverlay = new GMapOverlay("polygons");
                model.getLoadParcelMapCoordinates(parcelnumber);
                string[] latlong = model.getLoadParcelMapCoordinates(parcelnumber);

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
            if (existRoute == true)
                r.Clear();
            //Útvonal megjelenítése a térképen
            MapRoute route = GMap.NET.MapProviders.OpenStreetMapQuestProvider.Instance.GetRoute(startposition, endposition, true, false, 11);
            r = new GMapRoute(route.Points, "My route");
            GMapOverlay routesOverlay = new GMapOverlay("routes");
            routesOverlay.Routes.Add(r);
            r.Stroke.Width = 4;
            r.Stroke.Color = Color.SkyBlue;
            gMapControlParcelMap.Overlays.Add(routesOverlay);

            gMapControlParcelMap.UpdateRouteLocalPosition(r);

            //Marker jelzés elhelyezése a kezdő ponthoz
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(startposition,GMarkerGoogleType.green_dot);
            markers.Markers.Add(marker);
            gMapControlParcelMap.Overlays.Add(markers);
            gMapControlParcelMap.Position = startposition;
            gMapControlParcelMap.Zoom = 12;
            marker.ToolTipText = "Agroservice kft.";
            existRoute = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show(
           "Biztosan elvégezte a munkát?",
           "Igen",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Exclamation
          ) == DialogResult.Yes)
            {

                try
                {
                    model.setDoneWork(workId);
                    listViewNewWork.Items.Clear();
                    model.loadNewWorkData();
                    DataTable dt = new DataTable();

                    dt = model.getNewWorkData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        ListViewItem lvi = new ListViewItem(dr["Id"].ToString());
                        lvi.SubItems.Add(dr["dátum"].ToString());
                        lvi.SubItems.Add(dr["parcellaszám"].ToString());
                        lvi.SubItems.Add(dr["munkálat neve"].ToString());
                        lvi.SubItems.Add(dr["gabona"].ToString());
                        //listViewNewWork.Items.Clear();
                        listViewNewWork.Items.Add(lvi);
                    }
                    MessageBox.Show("A kijelölt munkálat elvégezve");
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            formCalc = new View.FormCalculator();
            formCalc.Show();
            //if (listViewNewWork.SelectedItems.Count < 0)
            //{
            //    return;
            //}
            //string servicename = listViewNewWork.SelectedItems[3].ToString();
            //string graincropname = listViewNewWork.SelectedItems[4].ToString();

            model.parcelDataloadFromList();
            model.loadParcelData(parcelnumber);
            double parcelHa= model.loadParcelData(parcelnumber);
            formCalc.labelHa.Text = Convert.ToString(parcelHa);

        }
    }
}
