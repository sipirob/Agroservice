using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.repository
{
    class Parcel
    {
        controller.LoadParcelData LoadParcelData = new controller.LoadParcelData();
        private int id;
        private int parcelnumber;
        private double ha;
        private int m2;
        private string coordinates;

        public Parcel(int id, int parcelnumber, double ha, int m2, string coordinates)
        {
            this.id = id;
            this.parcelnumber = parcelnumber;
            this.ha = ha;
            this.m2 = m2;
            this.coordinates = coordinates;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public void setParcelnumber(int parcelnumber)
        {
            this.parcelnumber = parcelnumber;
        }
        public void setHa(double ha)
        {
            this.ha = ha;
        }
        public void setM2(int m2)
        {
            this.m2 = m2;
        }
        public void setCoordinates(string coordinates)
        {
            this.coordinates = coordinates;
        }
        public int getId()
        {
            return id;
        }
        public int getParcelnumber()
        {
            return parcelnumber;
        }
        public double getHa()
        {
            return ha;
        }
        public int getM2()
        {
            return m2;
        }
        public string getCoordinates()
        {
            return coordinates;
        }


    }
}
