using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atm.Models;


namespace atm.Models
{
    public class AccountList
    {

        public List<Account> Accounts { get; set; }


        public List<Account> GetList()
        {
            return Accounts;
        }

    }
}
