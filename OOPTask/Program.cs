using System;

namespace OOPTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dog d = new Dog();
            Human h = new Human();
            h.Wings = new ElectronicWings();

            Duck du = new Duck();

            //Animal a = new Dog();
            //Animal animal = new Duck();

            //Feed(a);
            //Feed(animal);
            d.Talk();
            Feed(d);
            Feed(du);
            Fly(new Bat());
        }

        static void Feed(Animal animal)
        {
            animal.Eat();
            Talk(animal);

        }


        static void Talk(Animal animal)
        {
            animal.Talk();

        }
        static void Fly(IFly fly)
        {
            fly.Fly();

        }
    }
}
