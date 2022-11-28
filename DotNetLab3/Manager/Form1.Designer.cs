namespace Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProcessGrid = new System.Windows.Forms.DataGridView();
            this.Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Streams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetProcessBth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcessName = new System.Windows.Forms.TextBox();
            this.StopProcesss = new System.Windows.Forms.Button();
            this.OpenProcess = new System.Windows.Forms.Button();
            this.Selection = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessGrid
            // 
            this.ProcessGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Process,
            this.Memory,
            this.Time,
            this.Priority,
            this.Streams});
            this.ProcessGrid.Location = new System.Drawing.Point(12, 12);
            this.ProcessGrid.Name = "ProcessGrid";
            this.ProcessGrid.RowHeadersWidth = 51;
            this.ProcessGrid.RowTemplate.Height = 29;
            this.ProcessGrid.Size = new System.Drawing.Size(786, 389);
            this.ProcessGrid.TabIndex = 0;
            this.ProcessGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProcessGrid_CellContentClick);
            // 
            // Process
            // 
            this.Process.HeaderText = "Process";
            this.Process.MinimumWidth = 6;
            this.Process.Name = "Process";
            this.Process.Width = 125;
            // 
            // Memory
            // 
            this.Memory.HeaderText = "Memory";
            this.Memory.MinimumWidth = 6;
            this.Memory.Name = "Memory";
            this.Memory.Width = 125;
            // 
            // Time
            // 
            this.Time.HeaderText = "RunTime";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.Width = 125;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            this.Priority.Width = 125;
            // 
            // Streams
            // 
            this.Streams.HeaderText = "SteamsCount";
            this.Streams.MinimumWidth = 6;
            this.Streams.Name = "Streams";
            this.Streams.Width = 125;
            // 
            // GetProcessBth
            // 
            this.GetProcessBth.Location = new System.Drawing.Point(12, 419);
            this.GetProcessBth.Name = "GetProcessBth";
            this.GetProcessBth.Size = new System.Drawing.Size(266, 27);
            this.GetProcessBth.TabIndex = 1;
            this.GetProcessBth.Text = "Get Processes";
            this.GetProcessBth.UseVisualStyleBackColor = true;
            this.GetProcessBth.Click += new System.EventHandler(this.GetProcessBth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(293, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Process Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProcessName
            // 
            this.ProcessName.Location = new System.Drawing.Point(477, 419);
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Size = new System.Drawing.Size(165, 27);
            this.ProcessName.TabIndex = 3;
            // 
            // StopProcesss
            // 
            this.StopProcesss.Location = new System.Drawing.Point(648, 419);
            this.StopProcesss.Name = "StopProcesss";
            this.StopProcesss.Size = new System.Drawing.Size(150, 27);
            this.StopProcesss.TabIndex = 4;
            this.StopProcesss.Text = "Stop Process";
            this.StopProcesss.UseVisualStyleBackColor = true;
            this.StopProcesss.Click += new System.EventHandler(this.StopProcesss_Click);
            // 
            // OpenProcess
            // 
            this.OpenProcess.Location = new System.Drawing.Point(804, 142);
            this.OpenProcess.Name = "OpenProcess";
            this.OpenProcess.Size = new System.Drawing.Size(112, 29);
            this.OpenProcess.TabIndex = 6;
            this.OpenProcess.Text = "Open Process";
            this.OpenProcess.UseVisualStyleBackColor = true;
            this.OpenProcess.Click += new System.EventHandler(this.StopSelectProcess_Click);
            // 
            // Selection
            // 
            this.Selection.FormattingEnabled = true;
            this.Selection.ItemHeight = 20;
            this.Selection.Items.AddRange(new object[] {
            "calc",
            "Word",
            "lightshot",
            "Excel",
            "Reverso",
            "chrome"});
            this.Selection.Location = new System.Drawing.Point(804, 12);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(112, 124);
            this.Selection.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(939, 561);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.OpenProcess);
            this.Controls.Add(this.StopProcesss);
            this.Controls.Add(this.ProcessName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetProcessBth);
            this.Controls.Add(this.ProcessGrid);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView ProcessGrid;
        private DataGridViewTextBoxColumn Process;
        private DataGridViewTextBoxColumn Memory;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Priority;
        private DataGridViewTextBoxColumn Streams;
        private Button GetProcessBth;
        private Label label1;
        private TextBox ProcessName;
        private Button StopProcesss;
        private Button OpenProcess;
        private ListBox Selection;
    }
}