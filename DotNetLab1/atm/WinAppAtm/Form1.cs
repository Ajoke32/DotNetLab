using atm.Models;
using atm.EventArgs;
using atm.Repositories;
using atm;

namespace WinAppAtm
{
    public partial class Form1 : Form
    {
        AccountRepo accountRepo;
        public Form1()
        {
            InitializeComponent();
            accountRepo = new AccountRepo(new ExapleUsers().InitUsers());
        }

        private void CardNumberAutorizate_Click(object sender, EventArgs e)
        {
            accountRepo.AuthorizationInfo += this.Autorisation;
            accountRepo.ErrorInfo+=this.Error;
            accountRepo.Authorization(CardNumber.Text,int.Parse(Pin.Text));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Autorisation(Account sender, AuthorizationEventArgs e)
        {
            MessageBox.Show($"{e.Message}");
            this.Hide();
            MainForm main = new MainForm(sender);
            main.Show();
        }
        public void Error(ErorrArgs e)
        {
            MessageBox.Show(e.Message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}