﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOverriding
{
    internal class Animal
    {
        public virtual void talk()
        {
            Console.WriteLine("this is a animal");
        }

        
    }
}