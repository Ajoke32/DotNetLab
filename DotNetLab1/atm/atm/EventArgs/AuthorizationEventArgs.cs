using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm.EventArgs
{
    public class AuthorizationEventArgs:System.EventArgs
    {
        public AuthorizationEventArgs(string userName, double balance, string cardName, string cardNumber, string message)
        {
            UserName = userName;
            Balance = balance;
            CardName = cardName;
            CardNumber = cardNumber;
            Message = message;
        }

        public string UserName { get; }
        public double Balance { get; }
        public string CardName { get; }
        public string CardNumber { get; }
        public string Message { get; }


    }
}
