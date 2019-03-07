using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.repository
{
    class PlantDistance
    {
        private string distance;
        private int value;

        public PlantDistance(string distance, int value)
        {
            this.distance = distance;
            this.value = value;
        }
        public void setDistance(string distance)
        {
            this.distance = distance;
        }
        public void setValue(int value)
        {
            this.value = value;
        }
        public string getDistance()
        {
            return distance;
        }
        public int getValue()
        {
            return value;
        }
    }
}
