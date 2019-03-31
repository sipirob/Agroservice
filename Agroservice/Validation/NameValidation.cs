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
            bool validName = true;
            
            if (validName = validNameFirstLetterLovercase())
                throw new Exceptions.NameException("A vezetéknév nem kezdődhet kisbetűvel");
            if (validName = validLastname())
                throw new Exceptions.NameException("Nincs keresztnév!");
            return validName;
            
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
        public bool validLastname()
        {
            bool lastname = true;
            int index = 0;
           foreach(char letter in name)
            {
                index += 1;
                if (letter == Convert.ToChar(" ") && index > 3)
                {
                    lastname= false;
                }
                
            }
            return lastname;
        }
    }
}
