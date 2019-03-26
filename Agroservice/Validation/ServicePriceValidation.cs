using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.Validation
{
    public class ServicePriceValidation
    {
        private int servicePrice;
        public ServicePriceValidation(int servicePrice)
        {
            this.servicePrice = servicePrice;
        }
        public bool validation()
        {
            bool servicepriceRight = true;
            if (servicepriceRight = validFirstLetterLovercase())
                throw new Exceptions.ServicePriceException("A szolgáltatás ára nem lehet negatív");
            return servicepriceRight;
        }
        public bool validFirstLetterLovercase()
        {
            if (servicePrice < 0)
                return true;
            else
                return false;
        }
    } 
}
