using MysSqlDataGridViewHalak;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agroservice.repository;

namespace Agroservice.controller
{
    class LoadParcelData
    {
        private static List<repository.Parcel> Parcels;

        public LoadParcelData()
        {
            Parcels = new List<repository.Parcel>();
        }

        public static void parcelDataLoad()
        {
            try
            {

                loadParceldata();
            }
            catch (Exception e)
            {

            }
        }

        private static void loadParceldata()
        {
            ConnectToDatabase a = new ConnectToDatabase();
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            mdi = a.connect();
            mdi.open();
            string query = "SELECT * from parcels ";
            DataTable parceldt = new DataTable();
            parceldt = mdi.getToDataTable(query);
            loadParcelList(parceldt);
            mdi.close();
        }
     
        private static void loadParcelList(DataTable parceldt)
        {
            foreach (DataRow row in parceldt.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                int parcelnumber = Convert.ToInt32(row[1]);
                double ha = Convert.ToDouble(row[2]);
                int m2 = Convert.ToInt32(row[3]);
                string coordinates = (row[4]).ToString();
                Parcel p = new Parcel(id, parcelnumber, ha, m2, coordinates);
                
                Parcels.Add(p);
            }

        }

        public static double getParcelData(string parcelnumber)
        {
            double parcelHa = 0;
            foreach (Parcel p in Parcels)
            {
                if (p.getParcelnumber() == Convert.ToInt32(parcelnumber))
                    return p.getHa();
                parcelHa = p.getHa();
            }
            return parcelHa;
           
            
        }
    }
}
