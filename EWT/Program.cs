using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWT
{
    class Program
    {
        static void Main(string[] args)
        {
            MyProvider mp = new MyProvider();
            mp.EventWriteEVT1000("on the way");

        }
    }
}
