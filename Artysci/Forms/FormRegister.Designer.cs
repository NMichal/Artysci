namespace Artysci.Forms
{
    partial class FormRegister
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
            this.acceptBtn = new System.Windows.Forms.Button();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.repasswordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.errLoginLabel = new System.Windows.Forms.Label();
            this.errPassLabel = new System.Windows.Forms.Label();
            this.errRePassLabel = new System.Windows.Forms.Label();
            this.errEmailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(275, 304);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptBtn.TabIndex = 0;
            this.acceptBtn.Text = "Zatwierdz";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(32, 50);
            this.loginBox.MaxLength = 50;
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(100, 20);
            this.loginBox.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(58, 34);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(33, 13);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(58, 91);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(36, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Hasło";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(32, 107);
            this.passwordBox.MaxLength = 50;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Powtórz Hasło";
            // 
            // repasswordBox
            // 
            this.repasswordBox.Location = new System.Drawing.Point(32, 180);
            this.repasswordBox.MaxLength = 50;
            this.repasswordBox.Name = "repasswordBox";
            this.repasswordBox.PasswordChar = '*';
            this.repasswordBox.Size = new System.Drawing.Size(100, 20);
            this.repasswordBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(212, 180);
            this.emailBox.MaxLength = 50;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 20);
            this.emailBox.TabIndex = 7;
            // 
            // errLoginLabel
            // 
            this.errLoginLabel.AutoSize = true;
            this.errLoginLabel.Location = new System.Drawing.Point(138, 53);
            this.errLoginLabel.Name = "errLoginLabel";
            this.errLoginLabel.Size = new System.Drawing.Size(15, 13);
            this.errLoginLabel.TabIndex = 9;
            this.errLoginLabel.Text = "**";
            this.errLoginLabel.Visible = false;
            // 
            // errPassLabel
            // 
            this.errPassLabel.AutoSize = true;
            this.errPassLabel.Location = new System.Drawing.Point(138, 110);
            this.errPassLabel.Name = "errPassLabel";
            this.errPassLabel.Size = new System.Drawing.Size(15, 13);
            this.errPassLabel.TabIndex = 10;
            this.errPassLabel.Text = "**";
            this.errPassLabel.Visible = false;
            // 
            // errRePassLabel
            // 
            this.errRePassLabel.AutoSize = true;
            this.errRePassLabel.Location = new System.Drawing.Point(138, 183);
            this.errRePassLabel.Name = "errRePassLabel";
            this.errRePassLabel.Size = new System.Drawing.Size(15, 13);
            this.errRePassLabel.TabIndex = 11;
            this.errRePassLabel.Text = "**";
            this.errRePassLabel.Visible = false;
            // 
            // errEmailLabel
            // 
            this.errEmailLabel.AutoSize = true;
            this.errEmailLabel.Location = new System.Drawing.Point(318, 183);
            this.errEmailLabel.Name = "errEmailLabel";
            this.errEmailLabel.Size = new System.Drawing.Size(15, 13);
            this.errEmailLabel.TabIndex = 12;
            this.errEmailLabel.Text = "**";
            this.errEmailLabel.Visible = false;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 339);
            this.Controls.Add(this.errEmailLabel);
            this.Controls.Add(this.errRePassLabel);
            this.Controls.Add(this.errPassLabel);
            this.Controls.Add(this.errLoginLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repasswordBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.acceptBtn);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repasswordBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label errLoginLabel;
        private System.Windows.Forms.Label errPassLabel;
        private System.Windows.Forms.Label errRePassLabel;
        private System.Windows.Forms.Label errEmailLabel;
    }
}