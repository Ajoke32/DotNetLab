using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using atm.EventArgs;

namespace atm.Models
{
    public delegate void MachineHandler(AutomatedTellerMachine sender, EventMachineArgs e);
    public class AutomatedTellerMachine
    {
        public event MachineHandler MachineHandlerInfo;

        public AutomatedTellerMachine(int id, double balance, string? adress)
        {
            Id = id;
            Balance = balance;
            Adress = adress;
        }

        public int Id { get; set; }
        public double Balance { get; set; }
        public string? Adress { get; set; }

        public bool WithDrawMoney(double sum)
        {
            if (Balance >= sum)
            {
                Balance-= sum;

                MachineHandlerInfo.Invoke(this, new EventMachineArgs("Current machine balance", Balance));
                return true;
            }
            else
            {
                MachineHandlerInfo.Invoke(this, new EventMachineArgs($"Not enought money in machine, current balance {Balance}", Balance));
                return false;
            }
        }
    }
}
