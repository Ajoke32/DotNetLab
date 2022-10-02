namespace WinAppAtm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Put = new System.Windows.Forms.Button();
            this.Transfer = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.GetBalance = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.WithDraw = new System.Windows.Forms.Button();
            this.Executing = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.TextBox();
            this.TransferMoney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Put
            // 
            this.Put.Location = new System.Drawing.Point(262, 171);
            this.Put.Name = "Put";
            this.Put.Size = new System.Drawing.Size(94, 29);
            this.Put.TabIndex = 1;
            this.Put.Text = "Put money";
            this.Put.UseVisualStyleBackColor = true;
            this.Put.Click += new System.EventHandler(this.Action);
            // 
            // Transfer
            // 
            this.Transfer.Location = new System.Drawing.Point(388, 171);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(162, 29);
            this.Transfer.TabIndex = 2;
            this.Transfer.Text = "Transfer money";
            this.Transfer.UseVisualStyleBackColor = true;
            this.Transfer.Click += new System.EventHandler(this.TransferOperation);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(626, 409);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(162, 29);
            this.Logout.TabIndex = 3;
            this.Logout.Text = "Exit";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // GetBalance
            // 
            this.GetBalance.Location = new System.Drawing.Point(577, 171);
            this.GetBalance.Name = "GetBalance";
            this.GetBalance.Size = new System.Drawing.Size(162, 29);
            this.GetBalance.TabIndex = 4;
            this.GetBalance.Text = "Balance";
            this.GetBalance.UseVisualStyleBackColor = true;
            this.GetBalance.Click += new System.EventHandler(this.GetBalance_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(250, 233);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(288, 27);
            this.Input.TabIndex = 5;
            this.Input.Visible = false;
            // 
            // WithDraw
            // 
            this.WithDraw.Location = new System.Drawing.Point(52, 171);
            this.WithDraw.Name = "WithDraw";
            this.WithDraw.Size = new System.Drawing.Size(157, 29);
            this.WithDraw.TabIndex = 6;
            this.WithDraw.Text = "Withdraw money";
            this.WithDraw.UseVisualStyleBackColor = true;
            this.WithDraw.Click += new System.EventHandler(this.Action);
            // 
            // Executing
            // 
            this.Executing.Location = new System.Drawing.Point(348, 271);
            this.Executing.Name = "Executing";
            this.Executing.Size = new System.Drawing.Size(94, 29);
            this.Executing.TabIndex = 7;
            this.Executing.Text = "Execute";
            this.Executing.UseVisualStyleBackColor = true;
            this.Executing.Visible = false;
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(334, 273);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(125, 27);
            this.Sum.TabIndex = 8;
            this.Sum.Visible = false;
            // 
            // TransferMoney
            // 
            this.TransferMoney.Location = new System.Drawing.Point(348, 330);
            this.TransferMoney.Name = "TransferMoney";
            this.TransferMoney.Size = new System.Drawing.Size(94, 29);
            this.TransferMoney.TabIndex = 9;
            this.TransferMoney.Text = "Transfer";
            this.TransferMoney.UseVisualStyleBackColor = true;
            this.TransferMoney.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TransferMoney);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Executing);
            this.Controls.Add(this.WithDraw);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.GetBalance);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.Put);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private Button Put;
        private Button Transfer;
        private Button Logout;
        private Button GetBalance;
        private TextBox Input;
        private Button WithDraw;
        private Button Executing;
        private TextBox Sum;
        private Button TransferMoney;
    }
}