using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm.EventArgs
{
    public class TransferEventArgs
    {
        public TransferEventArgs(string receiver, double sum)
        {
            Receiver = receiver;
            Sum = sum;
        }

        public string Receiver { get; }
        public double Sum { get; } 

    }
}
