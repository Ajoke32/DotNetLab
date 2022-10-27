using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using atm.EventArgs;
using atm.Models;


namespace Console_atm
{
    public class EmailSender
    {
        
        public SmtpClient GetSmtplient()
        {

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("ipz211_bmm@student.ztu.edu.ua", ""),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network
            };

            return smtpClient;
        }
        public void SendMessage(Account sender, AccountEventArgs e)
        {
            GetSmtplient().Send("ipz211_bmm@student.ztu.edu.ua", "bekker.misha@gmail.com", "Bank operation", $"{e.Message}"); 
        }
        public void Autorisation(Account sender, AuthorizationEventArgs e)
        {
            GetSmtplient().Send("ipz211_bmm@student.ztu.edu.ua", "bekker.misha@gmail.com", "Autorisation bank account",
                $"{e.Message} Signed in account {e.UserName}");
        }
        public void Erorr(ErorrArgs e)
        {
            if (e.Code == 2 || e.Code == 1)
            {
                GetSmtplient().Send("ipz211_bmm@student.ztu.edu.ua", "bekker.misha@gmail.com", "Erorr bank operation",
                $"{e.Message}");
            }
        }
        public void Transfer(Account sender, TransferEventArgs e)
        {
            GetSmtplient().Send("ipz211_bmm@student.ztu.edu.ua", "bekker.misha@gmail.com", "Bank account transfer",
                $"You tranfered {e.Sum} to ${e.Receiver}");
        }
    }
}
