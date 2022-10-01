using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace atm.Models
{
    public class Card
    {
       
        public Card(int id, string? name, DateTime? endTerm, DateTime? createTerm, double balance, string? number, int pin)
        {
            Id = id;
            Name = name;
            EndTerm = endTerm;
            CreateTerm = createTerm;
            Balance = balance;
            Number = number;
            Pin = pin;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? EndTerm { get; set; }
        public DateTime? CreateTerm { get; set; }
        public double Balance { get; set; }
        public string? Number { get; set; }
        public int Pin { get; set; }
    }
}
