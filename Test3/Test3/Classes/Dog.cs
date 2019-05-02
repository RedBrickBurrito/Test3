using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Interfaces;

namespace Test3.Classes
{
    class Dog: AnimalData, Interface
    {
      
        public string Talk()
        {
            return "Woof";
        }
    }
}
