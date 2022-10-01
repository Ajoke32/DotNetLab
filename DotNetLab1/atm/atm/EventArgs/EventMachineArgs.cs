using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm.EventArgs
{
    public class EventMachineArgs
    {
        public EventMachineArgs(string message, double balance)
        {
            Message = message;
            Balance = balance;
        }

        public string Message { get;}

        public double Balance { get;}



    }
}
