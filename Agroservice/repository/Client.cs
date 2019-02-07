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
        private string firstname;
        private string lastname;
        private string place;
        private int tel;

        public Client(int clientid, string firstname, string lastname, string place, int tel)
        {
            this.clientid = clientid;
            this.firstname = firstname;
            this.lastname = lastname;
            this.place = place;
            this.tel = tel;
        }

        public Client()
        {
        }

        public void setClientid(int clientid)
        {
            this.clientid = clientid;
        }
        public void setFirstname(string firstname)
        {
            this.firstname = firstname;
        }
        public void setLastname(string lastname)
        {
            this.lastname = lastname;
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
        public string getFirstname()
        {
            return firstname;
        }
        public string getLastname()
        {
            return lastname;
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
