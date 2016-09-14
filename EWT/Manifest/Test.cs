namespace EWT
{
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Diagnostics.Eventing;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Security.Principal;

    public class Security : IDisposable
    {
        //
        // Provider Security Event Count 1
        //

        internal EventProviderVersionTwo m_provider = new EventProviderVersionTwo(new Guid("c2049a44-5be8-4b88-a4cd-1e0ee4139f3b"));
        //
        // Task :  eventGUIDs
        //

        //
        // Event Descriptors
        //
        protected EventDescriptor EVT1000;

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                m_provider.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public Security()
        {
            unchecked
            {
                EVT1000 = new EventDescriptor(0x3e8, 0x1, 0x65, 0x2, 0x0, 0x0, (long)0x8000000000000000);
            }
        }


        //
        // Event method for EVT1000
        //
        public bool EventWriteEVT1000(string Message)
        {

            return m_provider.WriteEvent(ref EVT1000, Message);

        }
    }

    internal class EventProviderVersionTwo : EventProvider
    {
         internal EventProviderVersionTwo(Guid id)
                : base(id)
         {}


        [StructLayout(LayoutKind.Explicit, Size = 16)]
        private struct EventData
        {
            [FieldOffset(0)]
            internal UInt64 DataPointer;
            [FieldOffset(8)]
            internal uint Size;
            [FieldOffset(12)]
            internal int Reserved;
        }

    }

}
