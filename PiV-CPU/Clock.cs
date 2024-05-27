using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiV
{
    public class Clock
    {
        public event Action RisingEdge;
        public event Action FallingEdge;

    }
}
