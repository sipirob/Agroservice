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
    public class NameValidationTests
    {
        [TestMethod()]
        public void validNameFirstLetterLovercaseTest()
        {
            try
            {
                NameValidation nv = new NameValidation("sipos");
                bool actual = nv.validation();
                Assert.Fail("kisbetűre nem dob kivételt");

            }
            catch (Exceptions.NameException ne)
            {
                if (ne.Message != "A vezetéknév nem kezdőthet kisbetűvel")
                    Assert.Fail("Kisbetűre rossz szövegű kivételt dobott");
            }
        }
    }
}