using System.ComponentModel.DataAnnotations;
using atm.EventArgs;


namespace atm.Models
{
    public delegate void AccountHandler(Account sender,AccountEventArgs e);
    public delegate void TransferHandler(Account sender,TransferEventArgs e);
    public class Account
    {
        
        public event AccountHandler Info;
      
        public Account(int id, string? name, string? lastName, Card card, bool status)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Card = card;
            Status = status;    
        }

        public int Id { get;}
        public string? Name { get;}
        public string? LastName { get;}
        public Card Card { get;}
        public bool Status { get; set; }



        public void PutMoney(double sum)
        {
            Card.Balance += sum;
            Info?.Invoke(this, new AccountEventArgs($"Your bank account replished on {sum}", sum));
        }
        public void WithDraw(double sum)
        {
            if (Card.Balance >= sum)
            {
                Card.Balance -= sum;
                Info?.Invoke(this,new AccountEventArgs($"Your withdraw: {sum}", sum));
            }
            else
            {
                Info?.Invoke(this, new AccountEventArgs($"Not enough money in the account",sum));
            }
        }
        public void GetBalance()
        {
            Info?.Invoke(this,new AccountEventArgs($"Your balance:{Card.Balance}",Card.Balance));
        }
        

    }
}