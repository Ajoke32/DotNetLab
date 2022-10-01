using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm.Models
{
    
    public class Transaction
    {
       
        public int Id { get; set; }

        public Account Sender { get; set; }

        public Account Receiver { get; set; }

        public double Sum { get; set; }

        public DateTime SendDate { get; set; }

        public int BankCode { get; set; }


    }
    
}
