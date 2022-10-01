using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace atm.Models
{
    public class AutomatedTellerMachine
    {
        public int Id { get; set; }
        public double Balance { get; set; }
        public string? Adress { get; set; }
        
    }
}
