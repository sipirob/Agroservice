using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Agroservice.controller
{
   
    class AgroserviceController
    {
        model.ClientDataLoad clientDataLoad;
        public AgroserviceController()
        {
            clientDataLoad = new model.ClientDataLoad();
        }

        public DataTable loadClientData()
        {
            model.ClientDataLoad cl = new model.ClientDataLoad();
           return cl.clientDataLoad();
        }
    }
}
