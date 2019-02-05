using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand.Clases_Patron
{
    class MacroCommand : Command
    {
        Command[] commands;

        public MacroCommand(Command[] commands)
        {
            this.commands = commands;
        }

        public string execute()
        {
            string ret = "";
            foreach(Command comm in commands)
            {
                ret += comm.execute()+"\n";
            }
            return ret;
        }

        public string undo()
        {
            string ret = "";
            foreach (Command comm in commands)
            {
                ret += comm.undo() + "\n";
            }
            return ret;
        }
    }
}
