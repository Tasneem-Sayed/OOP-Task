using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTask
{
    public class Shark : Fish, IMeat
    {
        public override void Breath()
        {
          
        }

        public override void Eat()
        {
           
        }

        public void MeatEat()
        {
            throw new NotImplementedException();
        }

        public override void Swim()
        {
            
        }
    }
}
