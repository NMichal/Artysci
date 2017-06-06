namespace Artysci.Forms
{
    partial class ProfileControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileControl));
            this.Icon = new System.Windows.Forms.PictureBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabelTyp = new MaterialSkin.Controls.MaterialLabel();
            this.LabelTworczosc = new MaterialSkin.Controls.MaterialLabel();
            this.LabelOpis = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.LabelProfileType = new MaterialSkin.Controls.MaterialLabel();
            this.LabelType = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // Icon
            // 
            this.Icon.Image = ((System.Drawing.Image)(resources.GetObject("Icon.Image")));
            this.Icon.Location = new System.Drawing.Point(4, 4);
            this.Icon.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(43, 39);
            this.Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon.TabIndex = 0;
            this.Icon.TabStop = false;
            this.Icon.Click += new System.EventHandler(this.PanelTitle_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelName.Location = new System.Drawing.Point(53, 9);
            this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(234, 31);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "NAME (kliknij mie)";
            this.LabelName.Click += new System.EventHandler(this.PanelTitle_Click);
            // 
            // PanelTitle
            // 
            this.PanelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelTitle.Controls.Add(this.LabelName);
            this.PanelTitle.Controls.Add(this.Icon);
            this.PanelTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(276, 49);
            this.PanelTitle.TabIndex = 2;
            this.PanelTitle.Click += new System.EventHandler(this.PanelTitle_Click);
            // 
            // LabelTyp
            // 
            this.LabelTyp.AutoSize = true;
            this.LabelTyp.Depth = 0;
            this.LabelTyp.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelTyp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelTyp.Location = new System.Drawing.Point(20, 68);
            this.LabelTyp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTyp.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelTyp.Name = "LabelTyp";
            this.LabelTyp.Size = new System.Drawing.Size(106, 24);
            this.LabelTyp.TabIndex = 3;
            this.LabelTyp.Text = "Typ profilu:";
            // 
            // LabelTworczosc
            // 
            this.LabelTworczosc.AutoSize = true;
            this.LabelTworczosc.Depth = 0;
            this.LabelTworczosc.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelTworczosc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelTworczosc.Location = new System.Drawing.Point(20, 103);
            this.LabelTworczosc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTworczosc.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelTworczosc.Name = "LabelTworczosc";
            this.LabelTworczosc.Size = new System.Drawing.Size(107, 24);
            this.LabelTworczosc.TabIndex = 4;
            this.LabelTworczosc.Text = "Twórczość:";
            // 
            // LabelOpis
            // 
            this.LabelOpis.AutoSize = true;
            this.LabelOpis.Depth = 0;
            this.LabelOpis.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelOpis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelOpis.Location = new System.Drawing.Point(20, 138);
            this.LabelOpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOpis.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelOpis.Name = "LabelOpis";
            this.LabelOpis.Size = new System.Drawing.Size(54, 24);
            this.LabelOpis.TabIndex = 5;
            this.LabelOpis.Text = "Opis:";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDescription.Location = new System.Drawing.Point(25, 232);
            this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 12);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ReadOnly = true;
            this.TextBoxDescription.Size = new System.Drawing.Size(227, 105);
            this.TextBoxDescription.TabIndex = 6;
            this.TextBoxDescription.Text = "";
            // 
            // LabelProfileType
            // 
            this.LabelProfileType.AutoSize = true;
            this.LabelProfileType.Depth = 0;
            this.LabelProfileType.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelProfileType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelProfileType.Location = new System.Drawing.Point(140, 68);
            this.LabelProfileType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelProfileType.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelProfileType.Name = "LabelProfileType";
            this.LabelProfileType.Size = new System.Drawing.Size(41, 24);
            this.LabelProfileType.TabIndex = 7;
            this.LabelProfileType.Text = "cos";
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Depth = 0;
            this.LabelType.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelType.Location = new System.Drawing.Point(144, 103);
            this.LabelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelType.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(41, 24);
            this.LabelType.TabIndex = 8;
            this.LabelType.Text = "cos";
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.LabelProfileType);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.LabelOpis);
            this.Controls.Add(this.LabelTworczosc);
            this.Controls.Add(this.LabelTyp);
            this.Controls.Add(this.PanelTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(189, 349);
            this.Tag = "Open";
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Icon;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Panel PanelTitle;
        private MaterialSkin.Controls.MaterialLabel LabelTyp;
        private MaterialSkin.Controls.MaterialLabel LabelTworczosc;
        private MaterialSkin.Controls.MaterialLabel LabelOpis;
        private System.Windows.Forms.RichTextBox TextBoxDescription;
        private MaterialSkin.Controls.MaterialLabel LabelProfileType;
        private MaterialSkin.Controls.MaterialLabel LabelType;
    }
}
