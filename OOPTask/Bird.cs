using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTask
{
    public abstract class Bird : Animal
    {
        public int LegNumber { get; set; }
        public string FeatherColor { get; set; }
        public  override void Breath()
        {

        }

        public override void Eat()
        {
            Console.WriteLine("Bird Eat");
        }

        public abstract void Walk();


    }
}
