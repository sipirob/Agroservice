using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.Exceptions
{
  public  class ServicePriceException : Exception
    {
        public ServicePriceException(string message) : base(message)
        {

        }
    }
}
