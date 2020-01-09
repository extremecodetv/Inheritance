using System;

namespace Traits
{
    abstract class Trait { }

    interface ITrait<T> where T : Trait { }

    class CanWalk : Trait { }

    class CanSwim : Trait { }

    class Penguin : ITrait<CanWalk>, ITrait<CanSwim> { }

    static class AnimalTraits
    {
        public static void Walk(this ITrait<CanWalk> trait)
        {
            Console.WriteLine("Walk");
        }

        public static void Swim(this ITrait<CanSwim> trait)
        {
            Console.WriteLine("Swim");
        }
    }

    class Runner
    {
        static void Run(string[] args)
        {
            var penguin = new Penguin();
            penguin.Swim();
            penguin.Walk();
        }
    }
}
