namespace Artysci.Forms
{
    partial class FormNewAnnouncement
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
            this.LabelName = new MaterialSkin.Controls.MaterialLabel();
            this.LabelCity = new MaterialSkin.Controls.MaterialLabel();
            this.LabelDate = new MaterialSkin.Controls.MaterialLabel();
            this.LabelTypeAnoun = new MaterialSkin.Controls.MaterialLabel();
            this.LabelTypeLooking = new MaterialSkin.Controls.MaterialLabel();
            this.LabelDescription = new MaterialSkin.Controls.MaterialLabel();
            this.TextBoxName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ComboBoxTypeAnoun = new System.Windows.Forms.ComboBox();
            this.TextBoxTypeLooking = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.TextBoxCity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ButtonMake = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Depth = 0;
            this.LabelName.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelName.Location = new System.Drawing.Point(13, 73);
            this.LabelName.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(54, 19);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "Nazwa";
            // 
            // LabelCity
            // 
            this.LabelCity.AutoSize = true;
            this.LabelCity.Depth = 0;
            this.LabelCity.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelCity.Location = new System.Drawing.Point(13, 160);
            this.LabelCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.Size = new System.Drawing.Size(56, 19);
            this.LabelCity.TabIndex = 1;
            this.LabelCity.Text = "Miasto";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Depth = 0;
            this.LabelDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelDate.Location = new System.Drawing.Point(13, 189);
            this.LabelDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(40, 19);
            this.LabelDate.TabIndex = 2;
            this.LabelDate.Text = "Data";
            // 
            // LabelTypeAnoun
            // 
            this.LabelTypeAnoun.AutoSize = true;
            this.LabelTypeAnoun.Depth = 0;
            this.LabelTypeAnoun.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelTypeAnoun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelTypeAnoun.Location = new System.Drawing.Point(13, 102);
            this.LabelTypeAnoun.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelTypeAnoun.Name = "LabelTypeAnoun";
            this.LabelTypeAnoun.Size = new System.Drawing.Size(114, 19);
            this.LabelTypeAnoun.TabIndex = 3;
            this.LabelTypeAnoun.Text = "Czego szukam?";
            // 
            // LabelTypeLooking
            // 
            this.LabelTypeLooking.AutoSize = true;
            this.LabelTypeLooking.Depth = 0;
            this.LabelTypeLooking.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelTypeLooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelTypeLooking.Location = new System.Drawing.Point(13, 131);
            this.LabelTypeLooking.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelTypeLooking.Name = "LabelTypeLooking";
            this.LabelTypeLooking.Size = new System.Drawing.Size(120, 19);
            this.LabelTypeLooking.TabIndex = 4;
            this.LabelTypeLooking.Text = "Czego dokładnie";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Depth = 0;
            this.LabelDescription.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelDescription.Location = new System.Drawing.Point(13, 218);
            this.LabelDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(39, 19);
            this.LabelDescription.TabIndex = 5;
            this.LabelDescription.Text = "Opis";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxName.Depth = 0;
            this.TextBoxName.Hint = "Nazwa ogłoszenia";
            this.TextBoxName.Location = new System.Drawing.Point(74, 73);
            this.TextBoxName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.PasswordChar = '\0';
            this.TextBoxName.SelectedText = "";
            this.TextBoxName.SelectionLength = 0;
            this.TextBoxName.SelectionStart = 0;
            this.TextBoxName.Size = new System.Drawing.Size(214, 23);
            this.TextBoxName.TabIndex = 6;
            this.TextBoxName.UseSystemPasswordChar = false;
            // 
            // ComboBoxTypeAnoun
            // 
            this.ComboBoxTypeAnoun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxTypeAnoun.FormattingEnabled = true;
            this.ComboBoxTypeAnoun.Items.AddRange(new object[] {
            "Miejsce",
            "Osoby"});
            this.ComboBoxTypeAnoun.Location = new System.Drawing.Point(134, 102);
            this.ComboBoxTypeAnoun.Name = "ComboBoxTypeAnoun";
            this.ComboBoxTypeAnoun.Size = new System.Drawing.Size(154, 21);
            this.ComboBoxTypeAnoun.TabIndex = 7;
            // 
            // TextBoxTypeLooking
            // 
            this.TextBoxTypeLooking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxTypeLooking.Depth = 0;
            this.TextBoxTypeLooking.Hint = "Opisz kogo szukasz";
            this.TextBoxTypeLooking.Location = new System.Drawing.Point(140, 130);
            this.TextBoxTypeLooking.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxTypeLooking.Name = "TextBoxTypeLooking";
            this.TextBoxTypeLooking.PasswordChar = '\0';
            this.TextBoxTypeLooking.SelectedText = "";
            this.TextBoxTypeLooking.SelectionLength = 0;
            this.TextBoxTypeLooking.SelectionStart = 0;
            this.TextBoxTypeLooking.Size = new System.Drawing.Size(148, 23);
            this.TextBoxTypeLooking.TabIndex = 8;
            this.TextBoxTypeLooking.UseSystemPasswordChar = false;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(60, 187);
            this.DatePicker.MinDate = new System.DateTime(2017, 6, 5, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(139, 20);
            this.DatePicker.TabIndex = 10;
            this.DatePicker.Value = new System.DateTime(2017, 6, 5, 20, 6, 58, 0);
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxDescription.Location = new System.Drawing.Point(17, 241);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(271, 113);
            this.TextBoxDescription.TabIndex = 11;
            this.TextBoxDescription.Text = "";
            // 
            // TextBoxCity
            // 
            this.TextBoxCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxCity.Depth = 0;
            this.TextBoxCity.Hint = "Miasto";
            this.TextBoxCity.Location = new System.Drawing.Point(75, 160);
            this.TextBoxCity.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextBoxCity.Name = "TextBoxCity";
            this.TextBoxCity.PasswordChar = '\0';
            this.TextBoxCity.SelectedText = "";
            this.TextBoxCity.SelectionLength = 0;
            this.TextBoxCity.SelectionStart = 0;
            this.TextBoxCity.Size = new System.Drawing.Size(213, 23);
            this.TextBoxCity.TabIndex = 12;
            this.TextBoxCity.UseSystemPasswordChar = false;
            // 
            // ButtonMake
            // 
            this.ButtonMake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMake.AutoSize = true;
            this.ButtonMake.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonMake.Depth = 0;
            this.ButtonMake.Location = new System.Drawing.Point(221, 358);
            this.ButtonMake.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonMake.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonMake.Name = "ButtonMake";
            this.ButtonMake.Primary = false;
            this.ButtonMake.Size = new System.Drawing.Size(67, 36);
            this.ButtonMake.TabIndex = 13;
            this.ButtonMake.Text = "STWÓRZ";
            this.ButtonMake.UseVisualStyleBackColor = true;
            this.ButtonMake.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // FormNewAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.ButtonMake);
            this.Controls.Add(this.TextBoxCity);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.TextBoxTypeLooking);
            this.Controls.Add(this.ComboBoxTypeAnoun);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelDescription);
            this.Controls.Add(this.LabelTypeLooking);
            this.Controls.Add(this.LabelTypeAnoun);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.LabelCity);
            this.Controls.Add(this.LabelName);
            this.Name = "FormNewAnnouncement";
            this.Text = "Stwórz ogłoszenie:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LabelName;
        private MaterialSkin.Controls.MaterialLabel LabelCity;
        private MaterialSkin.Controls.MaterialLabel LabelDate;
        private MaterialSkin.Controls.MaterialLabel LabelTypeAnoun;
        private MaterialSkin.Controls.MaterialLabel LabelTypeLooking;
        private MaterialSkin.Controls.MaterialLabel LabelDescription;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxName;
        private System.Windows.Forms.ComboBox ComboBoxTypeAnoun;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxTypeLooking;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.RichTextBox TextBoxDescription;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextBoxCity;
        private MaterialSkin.Controls.MaterialFlatButton ButtonMake;
    }
}