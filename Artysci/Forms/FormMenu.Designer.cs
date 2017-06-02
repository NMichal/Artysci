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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.TextBoxSzukaj = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PanelMenu.SuspendLayout();
            this.TabMain.SuspendLayout();
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
            this.ButtonGrupy.Size = new System.Drawing.Size(56, 36);
            this.ButtonGrupy.TabIndex = 2;
            this.ButtonGrupy.Text = "GRUPY";
            this.ButtonGrupy.UseVisualStyleBackColor = true;
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
            // 
            // TabMain
            // 
            this.TabMain.Controls.Add(this.tabPage1);
            this.TabMain.Controls.Add(this.tabPage2);
            this.TabMain.Controls.Add(this.tabPage3);
            this.TabMain.Depth = 0;
            this.TabMain.Location = new System.Drawing.Point(109, 63);
            this.TabMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(690, 538);
            this.TabMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Twoje Ogloszenia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Twoje Sondy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(682, 512);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Twoje Grupy";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.TextBoxSzukaj);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.TabMain);
            this.Controls.Add(this.PanelMenu);
            this.Name = "FormMenu";
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.TabMain.ResumeLayout(false);
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
    }
}