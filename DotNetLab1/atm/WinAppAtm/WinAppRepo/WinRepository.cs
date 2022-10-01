using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atm.Models;
using atm.EventArgs;

namespace WinAppAtm.WinAppRepo
{
    internal class WinRepository
    {
        public void MoneyAction(Account sender, AccountEventArgs e)
        {
            MessageBox.Show(e.Message, "Action");
        }
        public void Erorr(ErorrArgs e)
        {
            MessageBox.Show(e.Message, "Action");
        }
        public void Transfer(Account sender, TransferEventArgs e)
        {
            MessageBox.Show($"You send {e.Sum} to {e.Receiver}", "Action");
        }
        
    }
}
