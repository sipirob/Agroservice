using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.repository
{
   public class Worker
    {
        private int workerid;
        private string firstname;
        private string lastname;
        private DateTime birthday;
        private string place;
        private int tel;

        public Worker(int workerid, string firstname, string lastname, DateTime birthday, string place, int tel)
        {
            this.workerid = workerid;
            this.firstname = firstname;
            this.lastname = lastname;
            this.birthday = birthday;
            this.place = place;
            this.tel = tel;
        }
        public void setWorkerid(int workerid)
        {
            this.workerid = workerid;
        }
        public void setFirstname(string firstname)
        {
            this.firstname = firstname;
        }
        public void setLastname(string lastname)
        {
            this.lastname = lastname;
        }
        public void setBirthday(DateTime birthday)
        {
            this.birthday = birthday;
        }
        public void setPlace(string place)
        {
            this.place = place;
        }
        public void setTel(int tel)
        {
            this.tel = tel;
        }


        public int getWorkerid()
        {
            return workerid;
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
        public DateTime getBirtday()
        {
            return birthday;
        }
        public int getTel()
        {
            return tel;
        }

        
    }
}
