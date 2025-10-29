using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.polymorphism.Overriding
{

    internal class Animal
    {
        public virtual void Eats() 
        {
            Console.WriteLine("Animal is eating");
        }
    }

    internal class Dog : Animal
    {
        public override void Eats()       //exact same function as parent, gets overriden and this is executed not parent one.
        {
            Console.WriteLine("Dog eats dog food");
        }
    }



    internal class OverridingDemo
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            a1.Eats();

            Dog d1 = new Dog();
            d1.Eats();
        }

    }

   
}
