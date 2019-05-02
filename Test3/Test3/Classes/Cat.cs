using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Interfaces;

namespace Test3.Classes
{
    class Cat:AnimalData,Interface
    {
     
    

        public string Talk()
        {
            Sound.Sonido();

            return "Miau";
        }
    }
}
