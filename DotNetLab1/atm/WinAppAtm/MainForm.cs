using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using atm.Models;
using atm.EventArgs;
using WinAppAtm.WinAppRepo;
using atm;

namespace WinAppAtm
{
    public partial class MainForm : Form
    {
        Account _account;
        WinRepository repo = new WinRepository();
        Bank bank = new Bank(new ExapleUsers().InitUsers());
        public MainForm(Account account)
        {
            InitializeComponent();
            _account = account;
            _account.Info += repo.MoneyAction;
            Executing.Click += new EventHandler(MoneyOperation);
            TransferMoney.Click += new EventHandler(Transfer_Click);
            bank.Transfer += repo.Transfer;
            bank.ErrorInfo += repo.Erorr;
        }

        public void Action(object sender, EventArgs e)
        {

            if (sender is Button)
            {
                Button button = (Button)sender;
                Input.Visible = true;
                Sum.Visible = false;
                TransferMoney.Visible = false;
                Executing.Visible = true;
                Executing.Text = button.Text;
                Input.Text = "";
            }

        }
        public void MoneyOperation(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = (Button)sender;
                switch (button.Text)
                {
                    case "Withdraw money":
                        {
                            _account.WithDraw(int.Parse(Input.Text));
                            Input.Visible = false;
                            Executing.Visible = false;
                        }
                        break;
                    case "Put money":
                        {
                            _account.PutMoney(int.Parse(Input.Text));
                            Input.Visible = false;
                            Executing.Visible = false;
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Action not exist");
                        }
                        break;
                }
            }
        }

        public void TransferOperation(object sender, EventArgs e)
        {
            Sum.Visible = true;
            Input.Visible = true;
            TransferMoney.Visible = true;
            Executing.Visible = false;
            Input.Text = "";
        }
        private void Transfer_Click(object sender, EventArgs e)
        {
            var receiver = bank.GetUserByCardNumber(Input.Text);
            if (receiver != null)
                bank.TranferMoney(_account, receiver, int.Parse(Sum.Text));
        }

        private void GetBalance_Click(object sender, EventArgs e)
        {
            _account.GetBalance();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }

}

