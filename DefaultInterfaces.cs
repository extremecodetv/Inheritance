using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultInterfaces
{
    interface ISwimmer
    {
        void Swim()
        {
            Console.WriteLine("Swim");
        }
    }

    interface IWalker
    {
        void Walk()
        {
            Console.WriteLine("Walk");
        }
    }

    class Penguin : ISwimmer, IWalker { }

    class Runner
    {
        static void Run(string[] args)
        {
            var penguin = new Penguin();

            var swimmer = (ISwimmer)penguin;
            swimmer.Swim();

            var walker = (IWalker)penguin;
            walker.Walk();
        }
    }
}
