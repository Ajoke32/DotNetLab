namespace WinAppAtm
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
            this.CardNumberAutorizate = new System.Windows.Forms.Button();
            this.CardNumber = new System.Windows.Forms.TextBox();
            this.Header = new System.Windows.Forms.Label();
            this.Pin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CardNumberAutorizate
            // 
            this.CardNumberAutorizate.Location = new System.Drawing.Point(334, 311);
            this.CardNumberAutorizate.Name = "CardNumberAutorizate";
            this.CardNumberAutorizate.Size = new System.Drawing.Size(94, 29);
            this.CardNumberAutorizate.TabIndex = 0;
            this.CardNumberAutorizate.Text = "Next";
            this.CardNumberAutorizate.UseVisualStyleBackColor = true;
            this.CardNumberAutorizate.Click += new System.EventHandler(this.CardNumberAutorizate_Click);
            // 
            // CardNumber
            // 
            this.CardNumber.Location = new System.Drawing.Point(246, 207);
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(261, 27);
            this.CardNumber.TabIndex = 2;
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Header.Location = new System.Drawing.Point(207, 111);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(355, 54);
            this.Header.TabIndex = 3;
            this.Header.Text = "Input card number";
            this.Header.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pin
            // 
            this.Pin.Location = new System.Drawing.Point(315, 253);
            this.Pin.Name = "Pin";
            this.Pin.Size = new System.Drawing.Size(125, 27);
            this.Pin.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pin);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.CardNumber);
            this.Controls.Add(this.CardNumberAutorizate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CardNumberAutorizate;
        private TextBox CardNumber;
        private Label Header;
        private TextBox Pin;
    }
}