using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atm.Models;
using atm.EventArgs;


namespace atm.Repositories
{
    public delegate void AuthorizationHandler(Account sender, AuthorizationEventArgs e);
    public delegate void ErrorHandler(ErorrArgs e);
    public class AccountRepo
    {
        public AccountList _list;
        public event AuthorizationHandler AuthorizationInfo;
        public event ErrorHandler ErrorInfo;
        public event TransferHandler Transfer;
        public AccountRepo(AccountList list)
        {
            _list = list;
        }

        public void Authorization(string cardNumber, int pin)
        {

            var auto = _list.Accounts.FirstOrDefault(c => c.Card.Number == cardNumber);

            if (auto != null)
            {
                if (auto.Card.Pin == pin)
                {
                    auto.Status = true;
                    AuthorizationInfo.Invoke(auto, new EventArgs.AuthorizationEventArgs(auto.Name, auto.Card.Balance, auto.Card.Name,
                        auto.Card.Number, "Succeeded autorization!"));
                }
                else
                {
                    ErrorInfo.Invoke(new ErorrArgs("Incorrect card password","Reinput passwod",1));
                }
            }
            else
            {
                ErrorInfo.Invoke(new ErorrArgs("Card not exist","Input existing card number",2));
            }

        }
        public Account GetUserByCardNumber(string number)
        {
            var result = _list.Accounts.FirstOrDefault(c => c.Card.Number == number);
            if(result == null)
            {
                ErrorInfo.Invoke(new ErorrArgs("Card not exist", "Input existing number",2));
            }
            
            return result;
        }
        public void TranferMoney(Account sender, Account receiver,double sum)
        {
            var result = _list.Accounts.FirstOrDefault(r => r.Card.Number == receiver.Card.Number);

            if( result != null)
            {
                if (sender.Card.Balance >= sum&&sender.Card.Number!=result.Card.Number)
                {
                    sender.WithDraw(sum);
                    receiver.PutMoney(sum);
                    Transfer.Invoke(sender, new TransferEventArgs(receiver.Name,sum));
                }
                else
                {
                    ErrorInfo.Invoke(new ErorrArgs("Not enough money or incorrect card number","input coorect date",3));
                }
            }

        }
       
    }
}
