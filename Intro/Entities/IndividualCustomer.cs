﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities
{
    internal class IndividualCustomer: BaseCustomer
    {
        public string FirstName { get; set; } // = string.Empty;
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
    }
}
