using System;

namespace Inheritance
{    
    class Program
    {

        abstract class Animal
        {
            public abstract void Speak();


        }

        abstract class WalkingAnimal : Animal
        {
            public abstract void Walk();
        }

        abstract class WalkingSwimingAnimal : WalkingAnimal
        {
            public abstract void Swim();
        }

        abstract class WalkingFlyingSwimingAnimal : WalkingSwimingAnimal
        {
            public abstract void Fly();
        }

        class Elephant : WalkingAnimal
        {
            public override void Speak()
            {
                Console.WriteLine("Туту");
            }

            public override void Walk()
            {
                Console.WriteLine("Топ топ");
            }
        }

        class Dog : WalkingSwimingAnimal
        {
            public override void Speak()
            {
                Console.WriteLine("гаф");
            }
            public override void Walk()
            {
                Console.WriteLine("Топ топ");
            }
        }

        class Penguin : WalkingSwimingAnimal
        {
            public override void Speak()
            {
                Console.WriteLine("ХЗ");
            }
            public override void Walk()
            {
                Console.WriteLine("Топ топ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
