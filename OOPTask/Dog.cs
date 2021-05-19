using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTask
{
    internal class Dog : Mammal
    {
        public override void Breath()
        {
        }

        public override void Eat()
        {

            Console.WriteLine("Dog Eat");
        }

        public override void Walk()
        {
        }

        public new void Talk()
        {
            Console.WriteLine("Dog Talk");
        }

        public  override void MammalMethod()
        {
        }

    }
}
