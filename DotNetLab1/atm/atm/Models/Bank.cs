using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace atm.Models
{
    public class Bank
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

    }
}
