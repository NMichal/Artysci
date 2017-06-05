﻿namespace Artysci.Forms
{
    partial class FormMenu
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ButtonGrupy = new MaterialSkin.Controls.MaterialFlatButton();
            this.ButtonSondy = new MaterialSkin.Controls.MaterialFlatButton();
            this.ButtonOgloszenia = new MaterialSkin.Controls.MaterialFlatButton();
            this.TabMain = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.TextBoxSzukaj = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.profileControl1 = new Artysci.Forms.ProfileControl();
            this.sondControl1 = new Artysci.Forms.SondControl();
            this.announCorntrol1 = new Artysci.Forms.AnnounCorntrol();
            this.PanelMenu.SuspendLayout();
            this.TabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelMenu.Controls.Add(this.ButtonGrupy);
            this.PanelMenu.Controls.Add(this.ButtonSondy);
            this.PanelMenu.Controls.Add(this.ButtonOgloszenia);
            this.PanelMenu.Location = new System.Drawing.Point(0, 63);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(111, 534);
            this.PanelMenu.TabIndex = 0;
            // 
            // ButtonGrupy
            // 
            this.ButtonGrupy.AutoSize = true;
            this.ButtonGrupy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonGrupy.Depth = 0;
            this.ButtonGrupy.Location = new System.Drawing.Point(8, 116);
            this.ButtonGrupy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonGrupy.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonGrupy.Name = "ButtonGrupy";
            this.ButtonGrupy.Primary = false;
            this.ButtonGrupy.Size = new System.Drawing.Size(65, 36);
            this.ButtonGrupy.TabIndex = 2;
            this.ButtonGrupy.Text = "PROFILE";
            this.ButtonGrupy.UseVisualStyleBackColor = true;
            this.ButtonGrupy.Click += new System.EventHandler(this.ButtonGrupy_Click);
            // 
            // ButtonSondy
            // 
            this.ButtonSondy.AutoSize = true;
            this.ButtonSondy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSondy.Depth = 0;
            this.ButtonSondy.Location = new System.Drawing.Point(7, 70);
            this.ButtonSondy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonSondy.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSondy.Name = "ButtonSondy";
            this.ButtonSondy.Primary = false;
            this.ButtonSondy.Size = new System.Drawing.Size(57, 36);
            this.ButtonSondy.TabIndex = 1;
            this.ButtonSondy.Text = "SONDY";
            this.ButtonSondy.UseVisualStyleBackColor = true;
            this.ButtonSondy.Click += new System.EventHandler(this.ButtonSondy_Click);
            // 
            // ButtonOgloszenia
            // 
            this.ButtonOgloszenia.AutoSize = true;
            this.ButtonOgloszenia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonOgloszenia.Depth = 0;
            this.ButtonOgloszenia.Location = new System.Drawing.Point(7, 24);
            this.ButtonOgloszenia.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonOgloszenia.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonOgloszenia.Name = "ButtonOgloszenia";
            this.ButtonOgloszenia.Primary = false;
            this.ButtonOgloszenia.Size = new System.Drawing.Size(95, 36);
            this.ButtonOgloszenia.TabIndex = 0;
            this.ButtonOgloszenia.Text = "OGŁOSZENIA";
            this.ButtonOgloszenia.UseVisualStyleBackColor = true;
            this.ButtonOgloszenia.Click += new System.EventHandler(this.ButtonOgloszenia_Click);
            // 
            // TabMain
            // 
            this.TabMain.Controls.Add(this.tabPage1);
            this.TabMain.Controls.Add(this.tabPage2);
            this.TabMain.Controls.Add(this.tabPage3);
            this.TabMain.Depth = 0;
            this.TabMain.Location = new System.Drawing.Point(112, 63);
            this.TabMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(690, 538);
            this.TabMain.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.announCorntrol1);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Twoje Ogloszenia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(32, 29);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(126, 19);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Nowe Ogloszenie";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(220, 24);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "ogloszenia";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sondControl1);
            this.tabPage2.Controls.Add(this.materialFlatButton1);
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Twoje Sondy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatButton1.Location = new System.Drawing.Point(7, 9);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(172, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "materialFlatButton1";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(211, 48);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "sondy";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.profileControl1);
            this.tabPage3.Controls.Add(this.materialLabel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(682, 512);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Twoje Profile";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(16, 19);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(104, 19);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "NOWY PROFIL";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.TabMain;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(105, 24);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(693, 39);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // TextBoxSzukaj
            // 
            this.TextBoxSzukaj.Depth = 0;
            this.TextBoxSzukaj.Hint = "  Szukaj";
            this.TextBoxSzukaj.Location = new System.Drawing.Point(583, 34);
            this.TextBoxSzukaj.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxSzukaj.Name = "TextBoxSzukaj";
            this.TextBoxSzukaj.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TextBoxSzukaj.PasswordChar = '\0';
            this.TextBoxSzukaj.SelectedText = "";
            this.TextBoxSzukaj.SelectionLength = 0;
            this.TextBoxSzukaj.SelectionStart = 0;
            this.TextBoxSzukaj.Size = new System.Drawing.Size(212, 23);
            this.TextBoxSzukaj.TabIndex = 3;
            this.TextBoxSzukaj.UseSystemPasswordChar = false;
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(109, 66);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(681, 519);
            this.contentPanel.TabIndex = 2;
            // 
            // profileControl1
            // 
            this.profileControl1.AutoSize = true;
            this.profileControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.profileControl1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.profileControl1.Location = new System.Drawing.Point(20, 63);
            this.profileControl1.Margin = new System.Windows.Forms.Padding(0);
            this.profileControl1.Name = "profileControl1";
            this.profileControl1.Size = new System.Drawing.Size(274, 43);
            this.profileControl1.TabIndex = 2;
            this.profileControl1.Tag = "Open";
            // 
            // sondControl1
            // 
            this.sondControl1.AutoSize = true;
            this.sondControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sondControl1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sondControl1.Location = new System.Drawing.Point(25, 70);
            this.sondControl1.Name = "sondControl1";
            this.sondControl1.Size = new System.Drawing.Size(235, 253);
            this.sondControl1.TabIndex = 2;
            this.sondControl1.Tag = "Open";
            // 
            // announCorntrol1
            // 
            this.announCorntrol1.AutoSize = true;
            this.announCorntrol1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.announCorntrol1.Location = new System.Drawing.Point(52, 82);
            this.announCorntrol1.Name = "announCorntrol1";
            this.announCorntrol1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.announCorntrol1.Size = new System.Drawing.Size(216, 53);
            this.announCorntrol1.TabIndex = 3;
            this.announCorntrol1.Tag = "Open";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.TabMain);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.TextBoxSzukaj);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.PanelMenu);
            this.Name = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.TabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private MaterialSkin.Controls.MaterialFlatButton ButtonGrupy;
        private MaterialSkin.Controls.MaterialFlatButton ButtonSondy;
        private MaterialSkin.Controls.MaterialFlatButton ButtonOgloszenia;
        private MaterialSkin.Controls.MaterialTabControl TabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxSzukaj;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private ProfileControl profileControl1;
        private SondControl sondControl1;
        private AnnounCorntrol announCorntrol1;
    }
}