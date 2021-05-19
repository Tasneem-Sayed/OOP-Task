using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTask
{
    public class Human : Mammal, IMeat
    {

        public IWings Wings { get; set; }
        public override void Breath()
        {
           
        }

        public override void Eat()
        {
            
        }

        public void MeatEat()
        {
        }

        public override void Walk()
        {
            
        }
    }
}
