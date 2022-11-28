using FileWorkerLib;
using System.ComponentModel;

namespace DotNetLab3
{
    public partial class Form1 : Form
    {
        private OpenFileDialog dialog;
        const string SrcFolder = @"c:\Documents\";
        private FileWorker worker;
        public Form1()
        {
            InitializeComponent();
            dialog = new OpenFileDialog();
            worker = new FileWorker();
            worker.background.ProgressChanged += BackChanges;
            worker.background.RunWorkerCompleted += WorkerCompleted;
        }

        private void SelectFileBth_Click(object sender, EventArgs e)
        {

            dialog.InitialDirectory = SrcFolder;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fName = dialog.FileName;
                if (fName != null)
                {
                    SelectFileBth.Enabled = false;
                    worker.DoEncryption(new FileInfo(fName));
                }
            }

        }
        private void BackChanges(object? sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
        private void WorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            Thread.Sleep(500);
            MessageBox.Show($"{worker.Info}");
            DecryptBth.Enabled = true;
            EncryptBth.Enabled = true;
            SelectFileBth.Enabled = true;
            checkKey.Enabled = true;
            progressBar.Value = 0;
        }
        private void checkKey_Click(object sender, EventArgs e)
        {
            if (keyValue.Text.Length>=4)
            {
                worker.Key = keyValue.Text;
                SelectFileBth.Visible = true;
                progressBar.Visible = true;
                checkKey.Enabled = false;
            }
            else
            {
                MessageBox.Show("Key length must be >3");
            }
        }
        private void ShowEncryptInfo()
        {
            EnterKey.Visible = true;
            checkKey.Visible = true;
            keyValue.Visible = true;
        }
        private void HideEncryptInfo()
        {
            EnterKey.Visible = false;
            checkKey.Visible = false;
            keyValue.Visible = false;
            progressBar.Visible = false;
        }

        private void EncryptBth_Click(object sender, EventArgs e)
        {
            worker.isEncrypt = true;
            DecryptBth.Enabled = false;
            ShowEncryptInfo();
        }

        private void DecryptBth_Click(object sender, EventArgs e)
        {
            worker.isEncrypt = false;
            HideEncryptInfo();
            EncryptBth.Enabled = false;
            SelectFileBth.Visible = true;
        }

        private void TestBth_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}