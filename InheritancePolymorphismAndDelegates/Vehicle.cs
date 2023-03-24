﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismAndDelegates
{
    public class Vehicle
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }

        public void honk(string sound)             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
}
