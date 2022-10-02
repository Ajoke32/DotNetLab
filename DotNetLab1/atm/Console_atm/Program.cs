// See https://aka.ms/new-console-template for more information
using atm.Models;
using atm;
using Console_atm;



ConsoleRepo repo = new ConsoleRepo();
Bank bank = new Bank(new ExapleUsers().InitUsers())
{
    Id = 1,
    Code = 554023,
    Name = "Privat24"
};


AutomatedTellerMachine automatedTellerMachine = new AutomatedTellerMachine(1,15000,"Strit1");

//EmailSender email = new EmailSender();
int a = 1;
Console.Write("Enter card number:");
string cardNumber = Console.ReadLine();
Console.Write("Enter pin:");
int pin = int.Parse(Console.ReadLine());
bank.AuthorizationInfo += repo.Autorization;
bank.ErrorInfo += repo.Erorr;
bank.Transfer += repo.Transfer;
automatedTellerMachine.MachineHandlerInfo += repo.MachineOperation;
//accountRepo.AuthorizationInfo += email.Autorization;
bank.Authorization(cardNumber, pin);
Account user = bank.GetUserByCardNumber(cardNumber);
user.Info += repo.ShowMessage;
bank.Transactions = new List<Transaction>();

do
{
    Console.WriteLine("Choose action: 1.PutMoney, 2.WithDraw, 3.Transfer, 4.GetBalance, 5.Logout");
    int action = int.Parse(Console.ReadLine());
    double sum = 0;
    switch (action)
    {
        case 1:
            {
                Console.Write("Enter sum:");
                sum = double.Parse(Console.ReadLine());
                user.PutMoney(sum);
            }
            break;
       case 2:
            {
                Console.Write("Enter sum:");
                sum = double.Parse(Console.ReadLine());
                var result = automatedTellerMachine.WithDrawMoney(sum);
                if(result==true)
                user.WithDraw(sum);
            }
            break;
        case 3:
            {
                Console.Write("Enter receiver card number:");
                string receverCar = Console.ReadLine();
                var receiver = bank.GetUserByCardNumber(receverCar);
                sum = double.Parse(Console.ReadLine());

                bank.TranferMoney(user, receiver, sum);
                bank.Transactions.Add(new Transaction()
                {
                    Id = new Random().Next(),
                    Sender = user,
                    Receiver = receiver,
                    SendDate = DateTime.Now,
                    Sum = sum,
                    BankCode = bank.Code
                });
            }
            break;
        case 4:
            {
                user.GetBalance();  
            }
            break;
        case 5:
            {
                user.Info -= repo.ShowMessage;
                Console.Write("Enter card number:");
                cardNumber = Console.ReadLine();
                Console.Write("Enter pin:");
                pin = int.Parse(Console.ReadLine());
                bank.Authorization(cardNumber, pin);
                user = bank.GetUserByCardNumber(cardNumber);
                user.Info += repo.ShowMessage;
            }
            break;
        default:
            {
                Console.WriteLine("Action not exist");
            }
            break;
    }
    Console.WriteLine("Press 0 to exit and any number to continue:");
    a = int.Parse(Console.ReadLine());

} while (a != 0);

Console.WriteLine("Transaction log");
foreach(var item in bank.Transactions)
{
    Console.WriteLine($"Operation code:{item.Id}\nSender:{item.Sender.Name}\nReceiver:{item.Receiver.Name}\nTransaction sum:{item.Sum}\nDate:{item.SendDate}\n");
}












