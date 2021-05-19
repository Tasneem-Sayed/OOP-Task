using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTask
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Age { get ; set; }

        public abstract void Breath();
        public abstract void Eat();


        public void Talk()
        {
            Console.WriteLine("Animal Talk");
        }
    }
}
