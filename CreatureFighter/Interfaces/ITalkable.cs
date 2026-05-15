using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureFighter.Interfaces
{
    internal interface ITalkable: INamed
    {
        string Say(string message);
    }
}
