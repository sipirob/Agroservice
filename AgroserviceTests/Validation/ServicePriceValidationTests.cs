using Microsoft.VisualStudio.TestTools.UnitTesting;
using Agroservice.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.Validation.Tests
{
    [TestClass()]
    public class ServicePriceValidationTests
    {
        [TestMethod()]
        public void ellenorizNegativTest()
        {
            try
            {
                ServicePriceValidation spe = new ServicePriceValidation(-55);
                bool actual = spe.validation();
                Assert.Fail("Negatív számra nem dobott kivételt");

            }
            catch (Exceptions.ServicePriceException sprex)
            {
                if (sprex.Message != "A szolgáltatás ára nem lehet negatív")
                    Assert.Fail("Negatív számra rossz szövegű kivételt dobott");
            }
        }

       
    }
}