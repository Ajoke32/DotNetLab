using atm.Models;
using atm.EventArgs;
using atm;

namespace WinAppAtm
{
    public partial class Form1 : Form
    {
        Bank bank =  new Bank(new ExapleUsers().InitUsers());
        public Form1()
        {
            InitializeComponent();
            bank.AuthorizationInfo += this.Autorisation;
            bank.ErrorInfo += this.Error;
        }
        private void CardNumberAutorizate_Click(object sender, EventArgs e)
        {
            
            bank.Authorization(CardNumber.Text,int.Parse(Pin.Text));

        }
        public void Autorisation(Account sender, AuthorizationEventArgs e)
        {
            MessageBox.Show($"{e.Message}");
            this.Hide();
            MainForm main = new MainForm(sender,bank);
            main.Show();
        }
        public void Error(ErorrArgs e)
        {
            MessageBox.Show(e.Message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CardNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}