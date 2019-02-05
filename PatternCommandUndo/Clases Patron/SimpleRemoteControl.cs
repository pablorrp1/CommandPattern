using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand.Clases_Patron
{
    class SimpleRemoteControl
    {
        Command slot;
        Command undo;

        public SimpleRemoteControl() { }

        public void setCommand(Command command) {
            slot = command;
        }

        public string buttonWasPressed()
        {
            undo = slot;
            return slot.execute();
        }

        public string undoWasPressed()
        {
            return undo.undo();
        }
    }
}
