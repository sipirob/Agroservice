﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agroservice.Exceptions
{
   public class NameException :Exception
    {
        public NameException(string message) : base(message)
        {

        }
    }
}
