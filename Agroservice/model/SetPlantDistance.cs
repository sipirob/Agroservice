using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Agroservice.model
{
    class SetPlantDistance
    {

        private static List<repository.PlantDistance> Plant;
       public static DataTable plantDisDt = new DataTable();

        public SetPlantDistance()
        {
            Plant = new List<repository.PlantDistance>();
        }

        //public static void setPlantDistance()
        //{
        //    DataTable corn = new DataTable();
        //}
        public static void setCornDistance()
        {
            int cm18 = 79400;
            int cm19 = 75200;
            int cm20 = 71400;
            int cm21 = 68800;
            int cm22 = 64900;
            int cm23 = 62100;
            int cm24 = 59500;
            int cm25 = 57100;
            int cm26 = 54900;
            int cm27 = 52900;
            int cm28 = 51000;
            int cm29 = 49300;
            int cm30 = 47600;
            int cm31 = 46100;


            repository.PlantDistance corn = new repository.PlantDistance(cm18, cm19, cm20, cm21, cm22, cm23, cm24, cm25, cm26, cm27, cm28, cm29, cm30, cm31);
            Plant.Add(corn);
           
        }
        public static DataTable getSeedDatatable()
        {     
            plantDisDt.Columns.Add("18cm", typeof(int));
            plantDisDt.Columns.Add("19cm", typeof(int));
            plantDisDt.Columns.Add("20cm", typeof(int));
            plantDisDt.Columns.Add("21cm", typeof(int));
            plantDisDt.Columns.Add("22cm", typeof(int));
            plantDisDt.Columns.Add("23cm", typeof(int));
            plantDisDt.Columns.Add("24cm", typeof(int));
            plantDisDt.Columns.Add("25cm", typeof(int));
            plantDisDt.Columns.Add("26cm", typeof(int));
            plantDisDt.Columns.Add("27cm", typeof(int));
            plantDisDt.Columns.Add("28cm", typeof(int));
            plantDisDt.Columns.Add("29cm", typeof(int));
            plantDisDt.Columns.Add("30cm", typeof(int));
            plantDisDt.Columns.Add("31cm", typeof(int));
            foreach (repository.PlantDistance pd in Plant)
            {
                plantDisDt.Rows.Add(pd.get18cm(),pd.get19cm(),pd.get20cm(),pd.get21cm(),pd.get22cm(),pd.get23cm(),pd.get24cm(),pd.get25cm(),pd.get26cm(),pd.get27cm(),pd.get28cm(),pd.get29cm(),pd.get30cm(),pd.get31cm());

            }
            return plantDisDt;
        }

       
    }
}
