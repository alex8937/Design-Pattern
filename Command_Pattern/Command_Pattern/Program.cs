using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class Program
    {
        static void Main()
        {
            RemoteControl remote = new RemoteControl();
            Light kitchLight = new Light("kitchen");
            remote.SetCommand(0, new LightOnCommand(kitchLight), new LightOffCommand(kitchLight));
            Light livingroomLight = new Light("living room");
            remote.SetCommand(1, new LightOnCommand(livingroomLight), new LightOffCommand(livingroomLight));
            remote.OnButtonWasPressed(0);
            remote.OffButtonWasPressed(0);
            remote.OnButtonWasPressed(1);
            remote.OffButtonWasPressed(1);
            remote.UndoButtonWasPressed();
            remote.UndoButtonWasPressed();
            remote.UndoButtonWasPressed();
        }
    }
}
