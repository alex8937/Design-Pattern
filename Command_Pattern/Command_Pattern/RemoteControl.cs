namespace Command_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoteControl
    {
        private List<Command> onCommands;
        private List<Command> offCommands;

        private Stack<Command> undoCommands;

        private const int NumButton = 2;

        public RemoteControl()
        {
            this.onCommands = new List<Command>(Enumerable.Repeat<Command>(new NoCommand(), NumButton));
            this.offCommands = new List<Command>(Enumerable.Repeat<Command>(new NoCommand(), NumButton));
            this.undoCommands = new Stack<Command>();

        }


        public void SetCommand(int num, Command onCommand, Command offCommand)
        {
            this.onCommands[num] = onCommand;
            this.offCommands[num] = offCommand;
        }

        public void OnButtonWasPressed(int num)
        {
            this.onCommands[num].Execute();
            this.undoCommands.Push(this.onCommands[num]);
        }

        public void OffButtonWasPressed(int num)
        {
            this.offCommands[num].Execute();
            this.undoCommands.Push(this.offCommands[num]);
        }

        public void UndoButtonWasPressed()
        {
            if (this.undoCommands.Count > 0)
            {
                Console.Write("Undo: ");
                this.undoCommands.Pop().Execute();
            }
        }

    }
}