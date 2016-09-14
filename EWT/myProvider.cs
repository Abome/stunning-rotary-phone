using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EWT
{
    class MyProvider : EWT.Security
    {
        public MyProvider() : base()
        {
            Guid guid = Guid.NewGuid();
            Trace.CorrelationManager.ActivityId = guid;

        }
    }
}
