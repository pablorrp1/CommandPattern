using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCommand.Clases_Externas;

namespace PatternCommand.Clases_Patron
{
    class FanOffCommand : Command
    {
        Fan fan;

        public FanOffCommand(Fan fan)
        {
            this.fan = fan;
        }

        public string execute()
        {
            return fan.off();
        }

        public string undo()
        {
            return fan.on();
        }

    }
}
