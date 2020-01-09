using System;

namespace Strategy
{
    interface IAnimal { }

    interface IAction
    {
        void DoAction();
    }

    interface IWalker
    {
        void Walk();
    }

    interface ISwimmer
    {
        void Swim();
    }

    class SwimAction : IAction
    {
        public void DoAction()
        {
            Console.WriteLine("Swim");
        }
    }

    class WalkAction : IAction
    {
        public void DoAction()
        {
            Console.WriteLine("Walk");
        }
    }

    class Penguin : IAnimal, IWalker, ISwimmer
    {
        IAction walkAction;
        IAction swimAction;

        public Penguin()
        {
            walkAction = new WalkAction();
            swimAction = new SwimAction();
        }

        public void Swim()
        {
            swimAction.DoAction();
        }

        public void Walk()
        {
            walkAction.DoAction();
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
