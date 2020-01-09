using System;

namespace Interfaces
{

    interface IAnimal { }

    interface IWalker
    {
        void Walk();
    }

    interface ISwimmer
    {
        void Swim();
    }

    class Penguin : IAnimal, IWalker, ISwimmer
    {
        public void Swim()
        {
            Console.WriteLine("Swim");
        }

        public void Walk()
        {
            Console.WriteLine("Walk");
        }
    }

    class Runner
    {
        static void Run(string[] args)
        {
            var penguin = new Penguin();
            penguin.Walk();
            penguin.Swim();
        }
    }
}
