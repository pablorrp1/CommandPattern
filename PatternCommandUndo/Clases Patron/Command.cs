using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternCommand.Clases_Patron
{
    interface Command
    {
        string execute();
        string undo();
    }
}
