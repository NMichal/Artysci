using System;

namespace Artysci.Forms
{
    partial class FormLogins
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
            this.RememberMeCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.PasswordTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LoginTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LoginButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.ForgetPasswordButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.RegisterButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // RememberMeCheckBox
            // 
            this.RememberMeCheckBox.AutoSize = true;
            this.RememberMeCheckBox.Depth = 0;
            this.RememberMeCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.RememberMeCheckBox.Location = new System.Drawing.Point(26, 172);
            this.RememberMeCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.RememberMeCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RememberMeCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.RememberMeCheckBox.Name = "RememberMeCheckBox";
            this.RememberMeCheckBox.Ripple = true;
            this.RememberMeCheckBox.Size = new System.Drawing.Size(120, 30);
            this.RememberMeCheckBox.TabIndex = 0;
            this.RememberMeCheckBox.Text = "Zapamiętaj mnie";
            this.RememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Depth = 0;
            this.PasswordTextBox.Hint = "Hasło";
            this.PasswordTextBox.Location = new System.Drawing.Point(26, 133);
            this.PasswordTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.Size = new System.Drawing.Size(254, 23);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = false;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Depth = 0;
            this.LoginTextBox.Hint = "Login";
            this.LoginTextBox.Location = new System.Drawing.Point(26, 95);
            this.LoginTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PasswordChar = '\0';
            this.LoginTextBox.SelectedText = "";
            this.LoginTextBox.SelectionLength = 0;
            this.LoginTextBox.SelectionStart = 0;
            this.LoginTextBox.Size = new System.Drawing.Size(254, 23);
            this.LoginTextBox.TabIndex = 2;
            this.LoginTextBox.UseSystemPasswordChar = false;
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = true;
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.Depth = 0;
            this.LoginButton.Location = new System.Drawing.Point(228, 172);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Primary = false;
            this.LoginButton.Size = new System.Drawing.Size(52, 36);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Zaloguj";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(26, 217);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(253, 0);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // ForgetPasswordButton
            // 
            this.ForgetPasswordButton.AutoSize = true;
            this.ForgetPasswordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ForgetPasswordButton.BackColor = System.Drawing.SystemColors.Control;
            this.ForgetPasswordButton.Depth = 0;
            this.ForgetPasswordButton.ForeColor = System.Drawing.SystemColors.Window;
            this.ForgetPasswordButton.Location = new System.Drawing.Point(13, 259);
            this.ForgetPasswordButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ForgetPasswordButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ForgetPasswordButton.Name = "ForgetPasswordButton";
            this.ForgetPasswordButton.Primary = false;
            this.ForgetPasswordButton.Size = new System.Drawing.Size(185, 36);
            this.ForgetPasswordButton.TabIndex = 5;
            this.ForgetPasswordButton.Text = "Zapomniałeś hasła?";
            this.ForgetPasswordButton.UseVisualStyleBackColor = false;
            
            // 
            // RegisterButton
            // 
            this.RegisterButton.AutoSize = true;
            this.RegisterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegisterButton.Depth = 0;
            this.RegisterButton.Location = new System.Drawing.Point(224, 259);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegisterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Primary = false;
            this.RegisterButton.Size = new System.Drawing.Size(74, 36);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "Rejestracja";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(26, 227);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(253, 2);
            this.materialDivider2.TabIndex = 7;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 334);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.ForgetPasswordButton);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.RememberMeCheckBox);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private MaterialSkin.Controls.MaterialCheckBox RememberMeCheckBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField LoginTextBox;
        private MaterialSkin.Controls.MaterialFlatButton LoginButton;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialFlatButton ForgetPasswordButton;
        private MaterialSkin.Controls.MaterialFlatButton RegisterButton;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
    }
}

