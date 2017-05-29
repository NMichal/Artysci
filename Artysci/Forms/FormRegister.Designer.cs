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
            this.acceptBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.loginBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passwordBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.repasswordBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.emailBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.errLoginLabel = new MaterialSkin.Controls.MaterialLabel();
            this.errPassLabel = new MaterialSkin.Controls.MaterialLabel();
            this.errRePassLabel = new MaterialSkin.Controls.MaterialLabel();
            this.errEmailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // acceptBtn
            // 
            this.acceptBtn.AutoSize = true;
            this.acceptBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.acceptBtn.Depth = 0;
            this.acceptBtn.Location = new System.Drawing.Point(272, 288);
            this.acceptBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.acceptBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Primary = false;
            this.acceptBtn.Size = new System.Drawing.Size(87, 36);
            this.acceptBtn.TabIndex = 0;
            this.acceptBtn.Text = "Zatwierdz";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // loginBox
            // 
            this.loginBox.Depth = 0;
            this.loginBox.Hint = "";
            this.loginBox.Location = new System.Drawing.Point(33, 101);
            this.loginBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginBox.Name = "loginBox";
            this.loginBox.PasswordChar = '\0';
            this.loginBox.SelectedText = "";
            this.loginBox.SelectionLength = 0;
            this.loginBox.SelectionStart = 0;
            this.loginBox.Size = new System.Drawing.Size(100, 23);
            this.loginBox.TabIndex = 1;
            this.loginBox.UseSystemPasswordChar = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Depth = 0;
            this.loginLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginLabel.Location = new System.Drawing.Point(59, 79);
            this.loginLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(46, 19);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Depth = 0;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordLabel.Location = new System.Drawing.Point(59, 136);
            this.passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(49, 19);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Hasło";
            // 
            // passwordBox
            // 
            this.passwordBox.Depth = 0;
            this.passwordBox.Hint = "";
            this.passwordBox.Location = new System.Drawing.Point(33, 158);
            this.passwordBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.SelectedText = "";
            this.passwordBox.SelectionLength = 0;
            this.passwordBox.SelectionStart = 0;
            this.passwordBox.Size = new System.Drawing.Size(100, 23);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(41, 209);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Powtórz Hasło";
            // 
            // repasswordBox
            // 
            this.repasswordBox.Depth = 0;
            this.repasswordBox.Hint = "";
            this.repasswordBox.Location = new System.Drawing.Point(33, 231);
            this.repasswordBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.repasswordBox.Name = "repasswordBox";
            this.repasswordBox.PasswordChar = '*';
            this.repasswordBox.SelectedText = "";
            this.repasswordBox.SelectionLength = 0;
            this.repasswordBox.SelectionStart = 0;
            this.repasswordBox.Size = new System.Drawing.Size(100, 23);
            this.repasswordBox.TabIndex = 5;
            this.repasswordBox.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(239, 209);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // emailBox
            // 
            this.emailBox.Depth = 0;
            this.emailBox.Hint = "";
            this.emailBox.Location = new System.Drawing.Point(213, 225);
            this.emailBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailBox.Name = "emailBox";
            this.emailBox.PasswordChar = '\0';
            this.emailBox.SelectedText = "";
            this.emailBox.SelectionLength = 0;
            this.emailBox.SelectionStart = 0;
            this.emailBox.Size = new System.Drawing.Size(100, 23);
            this.emailBox.TabIndex = 7;
            this.emailBox.UseSystemPasswordChar = false;
            // 
            // errLoginLabel
            // 
            this.errLoginLabel.AutoSize = true;
            this.errLoginLabel.Depth = 0;
            this.errLoginLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.errLoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errLoginLabel.Location = new System.Drawing.Point(139, 105);
            this.errLoginLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.errLoginLabel.Name = "errLoginLabel";
            this.errLoginLabel.Size = new System.Drawing.Size(21, 19);
            this.errLoginLabel.TabIndex = 9;
            this.errLoginLabel.Text = "**";
            this.errLoginLabel.Visible = false;
            // 
            // errPassLabel
            // 
            this.errPassLabel.AutoSize = true;
            this.errPassLabel.Depth = 0;
            this.errPassLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.errPassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errPassLabel.Location = new System.Drawing.Point(139, 162);
            this.errPassLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.errPassLabel.Name = "errPassLabel";
            this.errPassLabel.Size = new System.Drawing.Size(21, 19);
            this.errPassLabel.TabIndex = 10;
            this.errPassLabel.Text = "**";
            this.errPassLabel.Visible = false;
            // 
            // errRePassLabel
            // 
            this.errRePassLabel.AutoSize = true;
            this.errRePassLabel.Depth = 0;
            this.errRePassLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.errRePassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errRePassLabel.Location = new System.Drawing.Point(139, 235);
            this.errRePassLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.errRePassLabel.Name = "errRePassLabel";
            this.errRePassLabel.Size = new System.Drawing.Size(21, 19);
            this.errRePassLabel.TabIndex = 11;
            this.errRePassLabel.Text = "**";
            this.errRePassLabel.Visible = false;
            // 
            // errEmailLabel
            // 
            this.errEmailLabel.AutoSize = true;
            this.errEmailLabel.Depth = 0;
            this.errEmailLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.errEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errEmailLabel.Location = new System.Drawing.Point(319, 228);
            this.errEmailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.errEmailLabel.Name = "errEmailLabel";
            this.errEmailLabel.Size = new System.Drawing.Size(21, 19);
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

        private MaterialSkin.Controls.MaterialFlatButton acceptBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField passwordBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField repasswordBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailBox;
        private MaterialSkin.Controls.MaterialLabel loginLabel;
        private MaterialSkin.Controls.MaterialLabel passwordLabel;
        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MaterialSkin.Controls.MaterialLabel errLoginLabel;
        private MaterialSkin.Controls.MaterialLabel errPassLabel;
        private MaterialSkin.Controls.MaterialLabel errRePassLabel;
        private MaterialSkin.Controls.MaterialLabel errEmailLabel;
    }
}