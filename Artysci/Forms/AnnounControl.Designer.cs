﻿namespace Artysci.Forms
{
    partial class AnnounControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnnounControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelName = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelLookFor = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelLookForSpecific = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelCity = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelDate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxDecription = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonOdpowiedz = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.LabelName);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.LabelName_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelName.ForeColor = System.Drawing.Color.White;
            this.LabelName.Location = new System.Drawing.Point(40, 5);
            this.LabelName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(191, 31);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "OGLOSZENIE";
            this.LabelName.Click += new System.EventHandler(this.LabelName_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(17, 59);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(66, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Szukam:";
            // 
            // LabelLookFor
            // 
            this.LabelLookFor.AutoSize = true;
            this.LabelLookFor.Depth = 0;
            this.LabelLookFor.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelLookFor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelLookFor.Location = new System.Drawing.Point(87, 59);
            this.LabelLookFor.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelLookFor.Name = "LabelLookFor";
            this.LabelLookFor.Size = new System.Drawing.Size(39, 19);
            this.LabelLookFor.TabIndex = 2;
            this.LabelLookFor.Text = "tego";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(17, 87);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(80, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Dokładnie:";
            // 
            // LabelLookForSpecific
            // 
            this.LabelLookForSpecific.AutoSize = true;
            this.LabelLookForSpecific.Depth = 0;
            this.LabelLookForSpecific.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelLookForSpecific.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelLookForSpecific.Location = new System.Drawing.Point(103, 87);
            this.LabelLookForSpecific.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelLookForSpecific.Name = "LabelLookForSpecific";
            this.LabelLookForSpecific.Size = new System.Drawing.Size(39, 19);
            this.LabelLookForSpecific.TabIndex = 4;
            this.LabelLookForSpecific.Text = "tego";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(17, 113);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(60, 19);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Miasto:";
            // 
            // LabelCity
            // 
            this.LabelCity.AutoSize = true;
            this.LabelCity.Depth = 0;
            this.LabelCity.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelCity.Location = new System.Drawing.Point(83, 113);
            this.LabelCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.Size = new System.Drawing.Size(52, 19);
            this.LabelCity.TabIndex = 6;
            this.LabelCity.Text = "o tutaj";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(17, 138);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(108, 19);
            this.materialLabel7.TabIndex = 7;
            this.materialLabel7.Text = "Data i godzina:";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Depth = 0;
            this.LabelDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelDate.Location = new System.Drawing.Point(131, 138);
            this.LabelDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(47, 19);
            this.LabelDate.TabIndex = 8;
            this.LabelDate.Text = "ta i ta";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(17, 163);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(80, 19);
            this.materialLabel9.TabIndex = 9;
            this.materialLabel9.Text = "Szczegóły:";
            // 
            // TextBoxDecription
            // 
            this.TextBoxDecription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDecription.Location = new System.Drawing.Point(10, 188);
            this.TextBoxDecription.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.TextBoxDecription.Name = "TextBoxDecription";
            this.TextBoxDecription.ReadOnly = true;
            this.TextBoxDecription.Size = new System.Drawing.Size(248, 98);
            this.TextBoxDecription.TabIndex = 10;
            this.TextBoxDecription.Text = "";
            // 
            // ButtonOdpowiedz
            // 
            this.ButtonOdpowiedz.AutoSize = true;
            this.ButtonOdpowiedz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonOdpowiedz.Depth = 0;
            this.ButtonOdpowiedz.Location = new System.Drawing.Point(21, 295);
            this.ButtonOdpowiedz.Margin = new System.Windows.Forms.Padding(4, 6, 4, 10);
            this.ButtonOdpowiedz.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonOdpowiedz.Name = "ButtonOdpowiedz";
            this.ButtonOdpowiedz.Primary = false;
            this.ButtonOdpowiedz.Size = new System.Drawing.Size(90, 36);
            this.ButtonOdpowiedz.TabIndex = 11;
            this.ButtonOdpowiedz.Text = "ODPOWIEDZ";
            this.ButtonOdpowiedz.UseVisualStyleBackColor = true;
            this.ButtonOdpowiedz.Click += new System.EventHandler(this.ButtonOdpowiedz_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AnnounControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.ButtonOdpowiedz);
            this.Controls.Add(this.TextBoxDecription);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.LabelCity);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.LabelLookForSpecific);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.LabelLookFor);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.panel1);
            this.Name = "AnnounControl";
            this.Size = new System.Drawing.Size(268, 341);
            this.Tag = "Open";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel LabelLookFor;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel LabelLookForSpecific;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel LabelCity;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel LabelDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.RichTextBox TextBoxDecription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton ButtonOdpowiedz;

    }
}
