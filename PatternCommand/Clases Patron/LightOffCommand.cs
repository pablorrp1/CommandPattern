using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternCommand.Clases_Externas;

namespace PatternCommand.Clases_Patron
{
    class LightOffCommand : Command
    {
        Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public string execute()
        {
            return light.off();
        }

    }
}
