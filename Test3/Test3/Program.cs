using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test3.Classes;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog perro = new Dog();
            Cat gato = new Cat();

            Console.WriteLine(perro.Talk());
            Console.WriteLine(gato.Talk());
        }
    }
}
