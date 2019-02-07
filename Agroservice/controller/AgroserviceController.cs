using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.controller
{
   
    class AgroserviceController
    {
        model.ClientDataLoad clientDataLoad;
        public AgroserviceController()
        {
            clientDataLoad = new model.ClientDataLoad();
        }

        internal void loadClientData()
        {
            clientDataLoad.clientDataLoad();
        }
    }
}
