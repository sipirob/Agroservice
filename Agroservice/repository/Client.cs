using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.repository
{
   public class Client
    {
        private int clientid;
        private string name;
       
        private string place;
        private int tel;

        public Client(int clientid, string name, string place, int tel)
        {
            this.clientid = clientid;
            this.name = name;
           
            this.place = place;
            this.tel = tel;
        }

       

        public void setClientid(int clientid)
        {
            this.clientid = clientid;
        }
        public void setName(string name)
        {
            this.name = name;
        }
     
        public void setPlace(string place)
        {
            this.place = place;
        }
        public void setTel(int tel)
        {
            this.tel = tel;
        }

        public int getClientid()
        {
            return clientid;
        }
        public string getName()
        {
            return name;
        }
        
        public string getPlace()
        {
            return place;
        }
        public int getTel()
        {
            return tel;
        }
                
        
    }
}
