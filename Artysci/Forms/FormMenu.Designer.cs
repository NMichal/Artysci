namespace Artysci.Forms
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
            this.PanelAnnoun = new System.Windows.Forms.Panel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PanelSonds = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PanelProfiles = new System.Windows.Forms.Panel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.TextBoxSzukaj = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.refreshButton = new MaterialSkin.Controls.MaterialLabel();
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
            this.PanelMenu.Location = new System.Drawing.Point(0, 78);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(148, 657);
            this.PanelMenu.TabIndex = 0;
            // 
            // ButtonGrupy
            // 
            this.ButtonGrupy.AutoSize = true;
            this.ButtonGrupy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonGrupy.Depth = 0;
            this.ButtonGrupy.Location = new System.Drawing.Point(11, 143);
            this.ButtonGrupy.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ButtonGrupy.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonGrupy.Name = "ButtonGrupy";
            this.ButtonGrupy.Primary = false;
            this.ButtonGrupy.Size = new System.Drawing.Size(80, 36);
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
            this.ButtonSondy.Location = new System.Drawing.Point(9, 86);
            this.ButtonSondy.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ButtonSondy.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSondy.Name = "ButtonSondy";
            this.ButtonSondy.Primary = false;
            this.ButtonSondy.Size = new System.Drawing.Size(69, 36);
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
            this.ButtonOgloszenia.Location = new System.Drawing.Point(9, 30);
            this.ButtonOgloszenia.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ButtonOgloszenia.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonOgloszenia.Name = "ButtonOgloszenia";
            this.ButtonOgloszenia.Primary = false;
            this.ButtonOgloszenia.Size = new System.Drawing.Size(117, 36);
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
            this.TabMain.Location = new System.Drawing.Point(149, 78);
            this.TabMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(920, 662);
            this.TabMain.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PanelAnnoun);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(912, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Twoje Ogloszenia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PanelAnnoun
            // 
            this.PanelAnnoun.AutoSize = true;
            this.PanelAnnoun.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelAnnoun.Location = new System.Drawing.Point(23, 60);
            this.PanelAnnoun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelAnnoun.Name = "PanelAnnoun";
            this.PanelAnnoun.Size = new System.Drawing.Size(873, 542);
            this.PanelAnnoun.TabIndex = 3;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(32, 12);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(158, 24);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Nowe Ogloszenie";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PanelSonds);
            this.tabPage2.Controls.Add(this.materialFlatButton1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(912, 633);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Twoje Sondy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PanelSonds
            // 
            this.PanelSonds.AutoScroll = true;
            this.PanelSonds.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelSonds.Location = new System.Drawing.Point(33, 66);
            this.PanelSonds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelSonds.Name = "PanelSonds";
            this.PanelSonds.Size = new System.Drawing.Size(313, 452);
            this.PanelSonds.TabIndex = 5;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.materialFlatButton1.Location = new System.Drawing.Point(33, 11);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(213, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "materialFlatButton1";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.refreshButton);
            this.tabPage3.Controls.Add(this.PanelProfiles);
            this.tabPage3.Controls.Add(this.materialLabel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(912, 633);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Twoje Profile";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PanelProfiles
            // 
            this.PanelProfiles.AutoSize = true;
            this.PanelProfiles.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelProfiles.Location = new System.Drawing.Point(27, 59);
            this.PanelProfiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelProfiles.Name = "PanelProfiles";
            this.PanelProfiles.Size = new System.Drawing.Size(364, 553);
            this.PanelProfiles.TabIndex = 3;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.materialLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(21, 23);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(133, 24);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "NOWY PROFIL";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.TabMain;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(140, 30);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(924, 48);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // TextBoxSzukaj
            // 
            this.TextBoxSzukaj.Depth = 0;
            this.TextBoxSzukaj.Hint = "  Szukaj";
            this.TextBoxSzukaj.Location = new System.Drawing.Point(777, 42);
            this.TextBoxSzukaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxSzukaj.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxSzukaj.Name = "TextBoxSzukaj";
            this.TextBoxSzukaj.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.TextBoxSzukaj.PasswordChar = '\0';
            this.TextBoxSzukaj.SelectedText = "";
            this.TextBoxSzukaj.SelectionLength = 0;
            this.TextBoxSzukaj.SelectionStart = 0;
            this.TextBoxSzukaj.Size = new System.Drawing.Size(283, 28);
            this.TextBoxSzukaj.TabIndex = 3;
            this.TextBoxSzukaj.UseSystemPasswordChar = false;
            // 
            // contentPanel
            // 
            this.contentPanel.Location = new System.Drawing.Point(145, 81);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(908, 639);
            this.contentPanel.TabIndex = 2;
            // 
            // refreshButton
            // 
            this.refreshButton.AutoSize = true;
            this.refreshButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.Depth = 0;
            this.refreshButton.Font = new System.Drawing.Font("Roboto", 11F);
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.refreshButton.Location = new System.Drawing.Point(505, 23);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.refreshButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(82, 24);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Odśwież";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.TabMain);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.TextBoxSzukaj);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.PanelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Panel contentPanel;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Panel PanelSonds;
        private System.Windows.Forms.Panel PanelAnnoun;
        private System.Windows.Forms.Panel PanelProfiles;
        private MaterialSkin.Controls.MaterialLabel refreshButton;
    }
}