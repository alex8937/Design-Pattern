namespace Command_Pattern
{
    using System;

    public class NoCommand : Command
    {
        public void Execute()
        {
            Console.WriteLine("Doing nothing");
        }

        public void Undo()
        {
            Console.WriteLine("Undoing nothing");
        }
    }
}