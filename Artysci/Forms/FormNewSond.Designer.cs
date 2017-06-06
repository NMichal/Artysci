namespace Artysci.Forms
{
    partial class FormNewSond
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
            this.TextFieldQuestion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LabelQuestion = new MaterialSkin.Controls.MaterialLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.LabelCount = new MaterialSkin.Controls.MaterialLabel();
            this.LabelAnswer1 = new MaterialSkin.Controls.MaterialLabel();
            this.TextFieldAnswer1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextFieldAnswer2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LabelAnswer2 = new MaterialSkin.Controls.MaterialLabel();
            this.TextFieldAnswer4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LabelAnswer4 = new MaterialSkin.Controls.MaterialLabel();
            this.TextFieldAnswer3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LabelAnswer3 = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonConfirm = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextFieldQuestion
            // 
            this.TextFieldQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextFieldQuestion.Depth = 0;
            this.TextFieldQuestion.Hint = "Pytanie";
            this.TextFieldQuestion.Location = new System.Drawing.Point(17, 95);
            this.TextFieldQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldQuestion.Name = "TextFieldQuestion";
            this.TextFieldQuestion.PasswordChar = '\0';
            this.TextFieldQuestion.SelectedText = "";
            this.TextFieldQuestion.SelectionLength = 0;
            this.TextFieldQuestion.SelectionStart = 0;
            this.TextFieldQuestion.Size = new System.Drawing.Size(260, 23);
            this.TextFieldQuestion.TabIndex = 0;
            this.TextFieldQuestion.UseSystemPasswordChar = false;
            // 
            // LabelQuestion
            // 
            this.LabelQuestion.AutoSize = true;
            this.LabelQuestion.Depth = 0;
            this.LabelQuestion.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelQuestion.Location = new System.Drawing.Point(13, 73);
            this.LabelQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelQuestion.Name = "LabelQuestion";
            this.LabelQuestion.Size = new System.Drawing.Size(58, 19);
            this.LabelQuestion.TabIndex = 2;
            this.LabelQuestion.Text = "Pytanie";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(227, 124);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.Depth = 0;
            this.LabelCount.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelCount.Location = new System.Drawing.Point(13, 121);
            this.LabelCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(122, 19);
            this.LabelCount.TabIndex = 4;
            this.LabelCount.Text = "Ilość odpowiedzi";
            // 
            // LabelAnswer1
            // 
            this.LabelAnswer1.AutoSize = true;
            this.LabelAnswer1.Depth = 0;
            this.LabelAnswer1.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelAnswer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelAnswer1.Location = new System.Drawing.Point(17, 154);
            this.LabelAnswer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelAnswer1.Name = "LabelAnswer1";
            this.LabelAnswer1.Size = new System.Drawing.Size(94, 19);
            this.LabelAnswer1.TabIndex = 5;
            this.LabelAnswer1.Text = "Odpowiedź 1";
            // 
            // TextFieldAnswer1
            // 
            this.TextFieldAnswer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextFieldAnswer1.Depth = 0;
            this.TextFieldAnswer1.Hint = "Odpowiedź 1";
            this.TextFieldAnswer1.Location = new System.Drawing.Point(21, 176);
            this.TextFieldAnswer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldAnswer1.Name = "TextFieldAnswer1";
            this.TextFieldAnswer1.PasswordChar = '\0';
            this.TextFieldAnswer1.SelectedText = "";
            this.TextFieldAnswer1.SelectionLength = 0;
            this.TextFieldAnswer1.SelectionStart = 0;
            this.TextFieldAnswer1.Size = new System.Drawing.Size(255, 23);
            this.TextFieldAnswer1.TabIndex = 6;
            this.TextFieldAnswer1.UseSystemPasswordChar = false;
            // 
            // TextFieldAnswer2
            // 
            this.TextFieldAnswer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextFieldAnswer2.Depth = 0;
            this.TextFieldAnswer2.Hint = "Odpowiedź 2";
            this.TextFieldAnswer2.Location = new System.Drawing.Point(21, 229);
            this.TextFieldAnswer2.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldAnswer2.Name = "TextFieldAnswer2";
            this.TextFieldAnswer2.PasswordChar = '\0';
            this.TextFieldAnswer2.SelectedText = "";
            this.TextFieldAnswer2.SelectionLength = 0;
            this.TextFieldAnswer2.SelectionStart = 0;
            this.TextFieldAnswer2.Size = new System.Drawing.Size(255, 23);
            this.TextFieldAnswer2.TabIndex = 8;
            this.TextFieldAnswer2.UseSystemPasswordChar = false;
            // 
            // LabelAnswer2
            // 
            this.LabelAnswer2.AutoSize = true;
            this.LabelAnswer2.Depth = 0;
            this.LabelAnswer2.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelAnswer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelAnswer2.Location = new System.Drawing.Point(17, 207);
            this.LabelAnswer2.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelAnswer2.Name = "LabelAnswer2";
            this.LabelAnswer2.Size = new System.Drawing.Size(94, 19);
            this.LabelAnswer2.TabIndex = 7;
            this.LabelAnswer2.Text = "Odpowiedź 2";
            // 
            // TextFieldAnswer4
            // 
            this.TextFieldAnswer4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextFieldAnswer4.Depth = 0;
            this.TextFieldAnswer4.Hint = "Odpowiedź 4";
            this.TextFieldAnswer4.Location = new System.Drawing.Point(21, 330);
            this.TextFieldAnswer4.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldAnswer4.Name = "TextFieldAnswer4";
            this.TextFieldAnswer4.PasswordChar = '\0';
            this.TextFieldAnswer4.SelectedText = "";
            this.TextFieldAnswer4.SelectionLength = 0;
            this.TextFieldAnswer4.SelectionStart = 0;
            this.TextFieldAnswer4.Size = new System.Drawing.Size(255, 23);
            this.TextFieldAnswer4.TabIndex = 12;
            this.TextFieldAnswer4.UseSystemPasswordChar = false;
            // 
            // LabelAnswer4
            // 
            this.LabelAnswer4.AutoSize = true;
            this.LabelAnswer4.Depth = 0;
            this.LabelAnswer4.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelAnswer4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelAnswer4.Location = new System.Drawing.Point(17, 308);
            this.LabelAnswer4.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelAnswer4.Name = "LabelAnswer4";
            this.LabelAnswer4.Size = new System.Drawing.Size(94, 19);
            this.LabelAnswer4.TabIndex = 11;
            this.LabelAnswer4.Text = "Odpowiedź 4";
            // 
            // TextFieldAnswer3
            // 
            this.TextFieldAnswer3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextFieldAnswer3.Depth = 0;
            this.TextFieldAnswer3.Hint = "Odpowiedź 3";
            this.TextFieldAnswer3.Location = new System.Drawing.Point(21, 277);
            this.TextFieldAnswer3.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextFieldAnswer3.Name = "TextFieldAnswer3";
            this.TextFieldAnswer3.PasswordChar = '\0';
            this.TextFieldAnswer3.SelectedText = "";
            this.TextFieldAnswer3.SelectionLength = 0;
            this.TextFieldAnswer3.SelectionStart = 0;
            this.TextFieldAnswer3.Size = new System.Drawing.Size(255, 23);
            this.TextFieldAnswer3.TabIndex = 10;
            this.TextFieldAnswer3.UseSystemPasswordChar = false;
            // 
            // LabelAnswer3
            // 
            this.LabelAnswer3.AutoSize = true;
            this.LabelAnswer3.Depth = 0;
            this.LabelAnswer3.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelAnswer3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelAnswer3.Location = new System.Drawing.Point(17, 255);
            this.LabelAnswer3.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelAnswer3.Name = "LabelAnswer3";
            this.LabelAnswer3.Size = new System.Drawing.Size(94, 19);
            this.LabelAnswer3.TabIndex = 9;
            this.LabelAnswer3.Text = "Odpowiedź 3";
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.AutoSize = true;
            this.ButtonConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonConfirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonConfirm.Depth = 0;
            this.ButtonConfirm.Location = new System.Drawing.Point(190, 50);
            this.ButtonConfirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ButtonConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Primary = false;
            this.ButtonConfirm.Size = new System.Drawing.Size(87, 36);
            this.ButtonConfirm.TabIndex = 13;
            this.ButtonConfirm.Text = "ZATWIERDZ";
            this.ButtonConfirm.UseVisualStyleBackColor = false;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // FormNewSond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(300, 361);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.TextFieldAnswer4);
            this.Controls.Add(this.LabelAnswer4);
            this.Controls.Add(this.TextFieldAnswer3);
            this.Controls.Add(this.LabelAnswer3);
            this.Controls.Add(this.TextFieldAnswer2);
            this.Controls.Add(this.LabelAnswer2);
            this.Controls.Add(this.TextFieldAnswer1);
            this.Controls.Add(this.LabelAnswer1);
            this.Controls.Add(this.LabelCount);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.LabelQuestion);
            this.Controls.Add(this.TextFieldQuestion);
            this.Name = "FormNewSond";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.Text = "Stwórz sonde:";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldQuestion;
        private MaterialSkin.Controls.MaterialLabel LabelQuestion;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MaterialSkin.Controls.MaterialLabel LabelCount;
        private MaterialSkin.Controls.MaterialLabel LabelAnswer1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldAnswer1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldAnswer2;
        private MaterialSkin.Controls.MaterialLabel LabelAnswer2;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldAnswer4;
        private MaterialSkin.Controls.MaterialLabel LabelAnswer4;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextFieldAnswer3;
        private MaterialSkin.Controls.MaterialLabel LabelAnswer3;
        private MaterialSkin.Controls.MaterialFlatButton ButtonConfirm;
    }
}