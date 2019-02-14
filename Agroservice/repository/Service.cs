using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.repository
{
    class Service
    {
        public int id;
        public string name;
        public int price;

        public Service(int id,string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setPrice(int price)
        {
            this.price = price;
        }

        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getPrice()
        {
            return price;
        }
    }
}
