namespace DotNetLab3
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
            this.components = new System.ComponentModel.Container();
            this.keyValue = new System.Windows.Forms.TextBox();
            this.EnterKey = new System.Windows.Forms.Label();
            this.SelectFileBth = new System.Windows.Forms.Button();
            this.checkKey = new System.Windows.Forms.Button();
            this.EncryptBth = new System.Windows.Forms.Button();
            this.DecryptBth = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // keyValue
            // 
            this.keyValue.Location = new System.Drawing.Point(343, 115);
            this.keyValue.Name = "keyValue";
            this.keyValue.Size = new System.Drawing.Size(125, 27);
            this.keyValue.TabIndex = 0;
            this.keyValue.Visible = false;
            // 
            // EnterKey
            // 
            this.EnterKey.AutoSize = true;
            this.EnterKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterKey.Location = new System.Drawing.Point(243, 117);
            this.EnterKey.Name = "EnterKey";
            this.EnterKey.Size = new System.Drawing.Size(94, 22);
            this.EnterKey.TabIndex = 1;
            this.EnterKey.Text = "Enter Key:";
            this.EnterKey.Visible = false;
            // 
            // SelectFileBth
            // 
            this.SelectFileBth.Location = new System.Drawing.Point(243, 166);
            this.SelectFileBth.Name = "SelectFileBth";
            this.SelectFileBth.Size = new System.Drawing.Size(327, 105);
            this.SelectFileBth.TabIndex = 2;
            this.SelectFileBth.Text = "Select File";
            this.SelectFileBth.UseVisualStyleBackColor = true;
            this.SelectFileBth.Visible = false;
            this.SelectFileBth.Click += new System.EventHandler(this.SelectFileBth_Click);
            // 
            // checkKey
            // 
            this.checkKey.Location = new System.Drawing.Point(484, 115);
            this.checkKey.Name = "checkKey";
            this.checkKey.Size = new System.Drawing.Size(86, 29);
            this.checkKey.TabIndex = 3;
            this.checkKey.Text = "OK";
            this.checkKey.UseVisualStyleBackColor = true;
            this.checkKey.Visible = false;
            this.checkKey.Click += new System.EventHandler(this.checkKey_Click);
            // 
            // EncryptBth
            // 
            this.EncryptBth.Location = new System.Drawing.Point(12, 5);
            this.EncryptBth.Name = "EncryptBth";
            this.EncryptBth.Size = new System.Drawing.Size(366, 50);
            this.EncryptBth.TabIndex = 4;
            this.EncryptBth.Text = "Encrypt file";
            this.EncryptBth.UseVisualStyleBackColor = true;
            this.EncryptBth.Click += new System.EventHandler(this.EncryptBth_Click);
            // 
            // DecryptBth
            // 
            this.DecryptBth.Location = new System.Drawing.Point(384, 5);
            this.DecryptBth.Name = "DecryptBth";
            this.DecryptBth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DecryptBth.Size = new System.Drawing.Size(414, 50);
            this.DecryptBth.TabIndex = 5;
            this.DecryptBth.Text = "Decrypt file";
            this.DecryptBth.UseVisualStyleBackColor = true;
            this.DecryptBth.Click += new System.EventHandler(this.DecryptBth_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(243, 291);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(327, 29);
            this.progressBar.TabIndex = 6;
            this.progressBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.DecryptBth);
            this.Controls.Add(this.EncryptBth);
            this.Controls.Add(this.checkKey);
            this.Controls.Add(this.SelectFileBth);
            this.Controls.Add(this.EnterKey);
            this.Controls.Add(this.keyValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox keyValue;
        private Label EnterKey;
        private Button SelectFileBth;
        private Button checkKey;
        private Button EncryptBth;
        private Button DecryptBth;
        private BindingSource bindingSource1;
        public  ProgressBar progressBar;
    }
}