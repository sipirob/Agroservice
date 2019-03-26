using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.Validation
{
   public class NameValidation
    {
        private string name;
        public NameValidation(string name)
        {
            this.name = name;
        }
        public bool validation()
        {
            bool nameLoverFirstLetter = true;
            if (nameLoverFirstLetter = validNameFirstLetterLovercase())
                throw new Exceptions.NameException("A vezetéknév nem kezdőthet kisbetűvel");
            return nameLoverFirstLetter;
        }

        public bool validNameFirstLetterLovercase()
        {
            char firstLetter =  name[0];
            char firstletterLover = char.ToUpper(firstLetter);
            //for(int i=0; i<name.Length; i++)
            if (firstLetter == firstletterLover)
                return false;
            else
                return true;
        }
    }
}
