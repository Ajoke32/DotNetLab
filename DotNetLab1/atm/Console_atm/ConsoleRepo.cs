using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atm.EventArgs;
using atm.Models;

namespace Console_atm
{
    public class ConsoleRepo
    {
        public void ShowMessage(Account sender, AccountEventArgs e)
        {
            Console.WriteLine($"{e.Message}");
        }
        public void Autorisation(Account sender, AuthorizationEventArgs e)
        {
            Console.WriteLine($"{e.Message}\nAccount owner:{e.UserName}\nCard:{e.CardName}, balance:{e.Balance}");
        }
        public void Erorr(ErorrArgs e)
        {
            if (e.Code == 2||e.Code==1)
            {
                Console.WriteLine($"{e.Message}");
                Environment.Exit(2);
            }
            Console.WriteLine($"{e.Name}");
        }
        public void Transfer(Account sender, TransferEventArgs e)
        {
            Console.WriteLine($"You tranfer {e.Sum} to user {e.Receiver}");
        }

        public void MachineOperation(AutomatedTellerMachine sender, EventMachineArgs e)
        {
            Console.WriteLine($"{e.Message}");
        }

    }
}
