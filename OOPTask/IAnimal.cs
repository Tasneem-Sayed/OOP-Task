using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTask
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public string Age { get; set; }

        void Eat();
        void Breath();
    }
}
