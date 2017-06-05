namespace Artysci.Forms
{
    partial class FormNewProfile
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
            this.TextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.LabelName = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LabelDescription = new MaterialSkin.Controls.MaterialLabel();
            this.LabelType = new MaterialSkin.Controls.MaterialLabel();
            this.ComboBoxType = new System.Windows.Forms.ComboBox();
            this.LabelGenre = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxGenre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ButtonMake = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxDescription.Location = new System.Drawing.Point(12, 203);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(336, 94);
            this.TextBoxDescription.TabIndex = 0;
            this.TextBoxDescription.Text = "";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Depth = 0;
            this.LabelName.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelName.Location = new System.Drawing.Point(12, 84);
            this.LabelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(54, 19);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Nazwa";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxName.Depth = 0;
            this.TextBoxName.Hint = "nazwa artysty/organizatora";
            this.TextBoxName.Location = new System.Drawing.Point(72, 84);
            this.TextBoxName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.PasswordChar = '\0';
            this.TextBoxName.SelectedText = "";
            this.TextBoxName.SelectionLength = 0;
            this.TextBoxName.SelectionStart = 0;
            this.TextBoxName.Size = new System.Drawing.Size(276, 23);
            this.TextBoxName.TabIndex = 2;
            this.TextBoxName.UseSystemPasswordChar = false;
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Depth = 0;
            this.LabelDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelDescription.Location = new System.Drawing.Point(12, 181);
            this.LabelDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(39, 19);
            this.LabelDescription.TabIndex = 3;
            this.LabelDescription.Text = "Opis";
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Depth = 0;
            this.LabelType.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelType.Location = new System.Drawing.Point(12, 119);
            this.LabelType.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(111, 19);
            this.LabelType.TabIndex = 4;
            this.LabelType.Text = "Typ twórczości";
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.Items.AddRange(new object[] {
            "Organizator",
            "Artysta",
            "Kombinator"});
            this.ComboBoxType.Location = new System.Drawing.Point(130, 117);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxType.TabIndex = 5;
            // 
            // LabelGenre
            // 
            this.LabelGenre.AutoSize = true;
            this.LabelGenre.Depth = 0;
            this.LabelGenre.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelGenre.Location = new System.Drawing.Point(12, 151);
            this.LabelGenre.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelGenre.Name = "LabelGenre";
            this.LabelGenre.Size = new System.Drawing.Size(136, 19);
            this.LabelGenre.TabIndex = 6;
            this.LabelGenre.Text = "Rodzaj Twórczości";
            this.LabelGenre.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // TextBoxGenre
            // 
            this.TextBoxGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxGenre.Depth = 0;
            this.TextBoxGenre.Hint = "Napisz czym się zajmujesz";
            this.TextBoxGenre.Location = new System.Drawing.Point(155, 151);
            this.TextBoxGenre.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxGenre.Name = "TextBoxGenre";
            this.TextBoxGenre.PasswordChar = '\0';
            this.TextBoxGenre.SelectedText = "";
            this.TextBoxGenre.SelectionLength = 0;
            this.TextBoxGenre.SelectionStart = 0;
            this.TextBoxGenre.Size = new System.Drawing.Size(193, 23);
            this.TextBoxGenre.TabIndex = 7;
            this.TextBoxGenre.UseSystemPasswordChar = false;
            this.TextBoxGenre.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            // 
            // ButtonMake
            // 
            this.ButtonMake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMake.AutoSize = true;
            this.ButtonMake.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonMake.Depth = 0;
            this.ButtonMake.Location = new System.Drawing.Point(280, 306);
            this.ButtonMake.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonMake.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonMake.Name = "ButtonMake";
            this.ButtonMake.Primary = false;
            this.ButtonMake.Size = new System.Drawing.Size(67, 36);
            this.ButtonMake.TabIndex = 8;
            this.ButtonMake.Text = "STWÓRZ";
            this.ButtonMake.UseVisualStyleBackColor = true;
            // 
            // FormNewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 356);
            this.Controls.Add(this.ButtonMake);
            this.Controls.Add(this.TextBoxGenre);
            this.Controls.Add(this.LabelGenre);
            this.Controls.Add(this.ComboBoxType);
            this.Controls.Add(this.LabelType);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextBoxDescription);
            this.Name = "FormNewProfile";
            this.Text = "Stwórz nowy profil:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBoxDescription;
        private MaterialSkin.Controls.MaterialLabel LabelName;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxName;
        private MaterialSkin.Controls.MaterialLabel LabelDescription;
        private MaterialSkin.Controls.MaterialLabel LabelType;
        private System.Windows.Forms.ComboBox ComboBoxType;
        private MaterialSkin.Controls.MaterialLabel LabelGenre;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxGenre;
        private MaterialSkin.Controls.MaterialFlatButton ButtonMake;
    }
}