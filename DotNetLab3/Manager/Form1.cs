using System;
using System.Diagnostics;
using System.ComponentModel;
using ProcesManager;

namespace Manager
{
    public partial class Form1 : Form
    {
        private PManager manager;
        private BackgroundWorker worker;
        public Form1()
        {
            InitializeComponent();
            manager = new PManager();
            worker = new BackgroundWorker();
            worker.DoWork += DisplayProcessAsync;
            worker.RunWorkerCompleted += DisplayCompleted;
        }

        private void ProcessGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"{e.ColumnIndex}");
        }
        private void DisplayCompleted(object? sender,RunWorkerCompletedEventArgs e)
        {
            GetProcessBth.Enabled = true;
        }
        private void DisplayProcessAsync(object? sender,DoWorkEventArgs e)
        {
            GetProcessBth.Enabled = false;
            foreach (Process item in manager._processes)
            {
                Invoke(new Action(() =>
                {
                    try
                    {
                        var time = item.StartTime;
                        ProcessGrid.Rows.Add(item.ProcessName, $"{Math.Round(item.PagedMemorySize * Math.Pow(10, -6))}MB", $"{time.Hour}:{time.Minute}" +
                            $":{time.Second}",
                            item.BasePriority, item.ProcessorAffinity);
                    }
                    catch (Exception er)
                    {
                      
                    }
                }));
                
            }
        }
        private void GetProcessBth_Click(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
        }

        private void StopProcesss_Click(object sender, EventArgs e)
        {
            if (ProcessName.Text.Length > 0)
            {
                manager.CloseProcess(ProcessName.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StopSelectProcess_Click(object sender, EventArgs e)
        {
            if (Selection.SelectedItems.Count==1)
            {
                manager.OpenProcess(Selection.SelectedItem.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}