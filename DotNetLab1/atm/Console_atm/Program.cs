// See https://aka.ms/new-console-template for more information
using atm.Models;
using atm;
using Console_atm;
using atm.Repositories;


ConsoleRepo repo = new ConsoleRepo();
Account account = new Account(1, "User1", "LUser2", new Card(1, "Universal",
    new DateTime(2022,10,14), new DateTime(2020, 09, 14), 400, "441 421 4232", 4423),false);
Account account2 = new Account(2, "User2", "LUser3", new Card(2, "Universal", new DateTime(2022, 11, 14),
    new DateTime(2020, 09, 11), 300, "443 423 4233", 4123), false);

List<Account> accounts = new List<Account>();
accounts.Add(account);
accounts.Add(account2);
AccountRepo accountRepo = new AccountRepo(new AccountList()
{
    Accounts = accounts
});
EmailSender email = new EmailSender();
int a = 1;
Console.Write("Enter card number:");
string cardNumber = Console.ReadLine();
Console.Write("Enter pin:");
int pin = int.Parse(Console.ReadLine());
accountRepo.AuthorizationInfo += repo.Autorization;
accountRepo.ErrorInfo += repo.Erorr;
accountRepo.Transfer += repo.Transfer;
accountRepo.AuthorizationInfo += email.Autorization;
accountRepo.Authorization(cardNumber, pin);
var user = accountRepo.GetUserByCardNumber(cardNumber);
user.Info += repo.ShowMessage;

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
                user.WithDraw(sum);
            }
            break;
        case 3:
            {
                Console.Write("Enter receiver card number:");
                string receverCar = Console.ReadLine();
                var receiver = accountRepo.GetUserByCardNumber(receverCar);
                sum = double.Parse(Console.ReadLine());

                accountRepo.TranferMoney(user, receiver, sum);
            }
            break;
        case 4:
            {
                user.GetBalance();  
            }
            break;
        case 5:
            {
                Console.Write("Enter card number:");
                cardNumber = Console.ReadLine();
                Console.Write("Enter pin:");
                pin = int.Parse(Console.ReadLine());
                accountRepo.Authorization(cardNumber, pin);
            }
            break;
        default:
            {
                Console.WriteLine("Action not exist");
            }
            break;
    }

    a = int.Parse(Console.ReadLine());

} while (a != 0);













