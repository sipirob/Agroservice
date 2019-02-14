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
        private string name;
       
        private DateTime birthday;
        private string place;
        private int tel;

        public Worker(int workerid, string name, DateTime birthday, string place, int tel)
        {
            this.workerid = workerid;
            this.name = name;
            this.birthday = birthday;
            this.place = place;
            this.tel = tel;
        }
        public void setWorkerid(int workerid)
        {
            this.workerid = workerid;
        }
        public void setName(string name)
        {
            this.name = name;
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
        public string getName()
        {
            return name;
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
