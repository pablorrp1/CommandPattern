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

        public SimpleRemoteControl() { }

        public void setCommand(Command command) {
            slot = command;
        }

        public string buttonWasPressed()
        {
            return slot.execute();
        }
    }
}
