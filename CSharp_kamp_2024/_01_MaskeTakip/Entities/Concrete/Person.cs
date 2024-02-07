﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBirthYear { get; set; }

        public Person()
        {
            FirstName = "";
            LastName = "";
            NationalIdentity = 0;
            DateOfBirthYear = 0;
        }
    }
}
