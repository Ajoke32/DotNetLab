using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm.EventArgs
{
    public class AccountEventArgs
    {
        public AccountEventArgs(string message,double sum)
        {
            Sum = sum;
            Message = message;
        }

        public double Sum { get;}

        public string Message { get;}


    }
}
