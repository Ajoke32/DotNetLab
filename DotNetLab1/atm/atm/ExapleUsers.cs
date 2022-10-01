using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atm.Models;

namespace atm
{
    public class ExapleUsers
    {
        public AccountList InitUsers()
        {
            Account account = new Account(1, "User1", "LUser2", new Card(1, "Universal",
    new DateTime(2022, 10, 14), new DateTime(2020, 09, 14), 400, "441 421 4232", 4423), false);
            Account account2 = new Account(2, "User2", "LUser3", new Card(2, "Universal", new DateTime(2022, 11, 14),
                new DateTime(2020, 09, 11), 300, "443 423 4233", 4123), false);

            List<Account> accounts = new List<Account>();
            accounts.Add(account);
            accounts.Add(account2);


            return new AccountList()
            {
                Accounts = accounts
            };
        }
    }
}
