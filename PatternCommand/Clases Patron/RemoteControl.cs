using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand.Clases_Patron
{
    class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;

        public RemoteControl(int cant)
        {
            onCommands = new Command[cant];
            offCommands = new Command[cant];

            Command noCommand = new NoCommand();
            for(int i=0; i < cant; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public string onButtonWasPushed(int slot)
        {
            if(onCommands[slot]!=null)
                return onCommands[slot].execute();
            return "";
        }

        public string offButtonWasPushed(int slot)
        {
            if (offCommands[slot] != null)
                return offCommands[slot].execute();
            return "";
        }

        public String toString()
        {
            string buff = "";
            buff += "Control";
            for(int i=0; i< onCommands.Length; i++)
            {
                buff += "\n [slot"+i+"] " + onCommands[i].GetType()+"   "+ offCommands[i].GetType();
            }
            return buff;
        }
    }
}
