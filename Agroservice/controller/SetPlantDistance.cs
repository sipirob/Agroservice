using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Agroservice.controller
{
    class SetPlantDistance
    {

        private static List<repository.PlantDistance> Plant;
       public static DataTable plantDisDt = new DataTable();

        
        public SetPlantDistance()
        {
            Plant = new List<repository.PlantDistance>();
        }

        public static void setCornDistance()
        {
         
        }
        public static DataTable plantDistanceWithValue()
        {
            DataTable corn_sunflowerDt = new DataTable();
            corn_sunflowerDt.Columns.Add("distance", typeof(string));
            corn_sunflowerDt.Columns.Add("value", typeof(int));
            corn_sunflowerDt.Rows.Add("18cm", 79400);
            corn_sunflowerDt.Rows.Add("19cm", 75200);
            corn_sunflowerDt.Rows.Add("20cm", 71400);
            corn_sunflowerDt.Rows.Add("21cm", 68800);
            corn_sunflowerDt.Rows.Add("22cm", 64900);
            corn_sunflowerDt.Rows.Add("23cm", 62100);
            corn_sunflowerDt.Rows.Add("24cm", 59500);
            corn_sunflowerDt.Rows.Add("25cm", 57100);
            corn_sunflowerDt.Rows.Add("26cm", 54900);
            corn_sunflowerDt.Rows.Add("27cm", 52900);
            corn_sunflowerDt.Rows.Add("28cm", 51000);
            corn_sunflowerDt.Rows.Add("29cm", 49300);
            corn_sunflowerDt.Rows.Add("30cm", 47600);
            corn_sunflowerDt.Rows.Add("31cm", 46100);

            return corn_sunflowerDt;
        }
      

       
    }
}
