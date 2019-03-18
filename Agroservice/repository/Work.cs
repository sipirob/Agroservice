using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.repository
{
    public class Work
    {
        

        private int id;
        private DateTime date;
        private int parcelnumber;
        private string servicename;
        private string graincropname;
        private string clientname;
        private string workername;
        private int rating;
        private string comment;
        private int price;
        private bool done;
        public Work(int id, DateTime date,int parcelnumber, string servicename, string graincropname, string clientname, string workername, int rating, string comment, int price, bool done)
        {
            this.id = id;
            this.date = date;
            this.parcelnumber = parcelnumber;
            this.servicename = servicename;
            this.graincropname = graincropname;
            this.clientname = clientname;
            this.workername = workername;
            this.rating = rating;
            this.comment = comment;
            this.price = price;
            this.done = done;
           
        }

        public Work()
        {
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public void setDate(DateTime date)
        {
            this.date = date;
        }
        public void setParcelnumber(int parcelnumber)
        {
            this.parcelnumber = parcelnumber;
        }
        public void setServicename(string servicename)
        {
            this.servicename = servicename;
        }
        public void setGraincropname(string graincropname)
        {
            this.graincropname = graincropname;
        }
        public void setClientname(string clientname)
        {
            this.clientname = clientname;
        }
        public void setWorkername(string workername)
        {
            this.workername = workername;
        }
        public void setRating(int rating)
        {
            this.rating = rating;
        }
        public void setComment(string comment)
        {
            this.comment = comment;
        }
        public void setPrice(int price)
        {
            this.price = price;
        }
        public void setDone(bool done)
        {
            this.done = done;
        }

        public int getId()
        {
            return id;
        }
        public DateTime getDate()
        {
            return date;
        }
        public int getParcelnumber()
        {
            return parcelnumber;
        }
        public string getServicename()
        {
            return servicename;
        }
        public string getGraincropname()
        {
            return graincropname;
        }
        public string getClientname()
        {
            return clientname;
        }
        public string getWorkername()
        {
            return workername;
        }
        public int getRating()
        {
            return rating;
        }
        public string getComment()
        {
            return comment;
        }
        public int getPrice()
        {
            return price;
        }
        public bool getDone()
        {
            return done;
        }
           

    
    }
}
