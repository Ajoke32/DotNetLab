namespace WinAtm
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
            this.CardNumAutorizate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CardNumAutorizate
            // 
            this.CardNumAutorizate.Location = new System.Drawing.Point(339, 256);
            this.CardNumAutorizate.Name = "CardNumAutorizate";
            this.CardNumAutorizate.Size = new System.Drawing.Size(94, 29);
            this.CardNumAutorizate.TabIndex = 0;
            this.CardNumAutorizate.Text = "Next";
            this.CardNumAutorizate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(532, 400);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button CardNumAutorizate;
    }
}