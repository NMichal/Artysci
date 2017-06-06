namespace Artysci.Forms
{
    partial class SondControl
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
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelQuestion = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonSend = new MaterialSkin.Controls.MaterialFlatButton();
            this.Odp1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.Odp2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.Odp4 = new MaterialSkin.Controls.MaterialRadioButton();
            this.Odp3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTitle
            // 
            this.PanelTitle.AutoSize = true;
            this.PanelTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelTitle.Controls.Add(this.LabelName);
            this.PanelTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Margin = new System.Windows.Forms.Padding(4);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(309, 49);
            this.PanelTitle.TabIndex = 0;
            this.PanelTitle.Click += new System.EventHandler(this.PanelTitle_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelName.Location = new System.Drawing.Point(45, 6);
            this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(224, 39);
            this.LabelName.TabIndex = 0;
            this.LabelName.Text = "SOND NAME";
            this.LabelName.Click += new System.EventHandler(this.PanelTitle_Click);
            // 
            // LabelQuestion
            // 
            this.LabelQuestion.AutoSize = true;
            this.LabelQuestion.Depth = 0;
            this.LabelQuestion.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelQuestion.Location = new System.Drawing.Point(19, 64);
            this.LabelQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQuestion.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelQuestion.Name = "LabelQuestion";
            this.LabelQuestion.Size = new System.Drawing.Size(72, 24);
            this.LabelQuestion.TabIndex = 1;
            this.LabelQuestion.Text = "Pytanie";
            // 
            // ButtonSend
            // 
            this.ButtonSend.AutoSize = true;
            this.ButtonSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonSend.Depth = 0;
            this.ButtonSend.Location = new System.Drawing.Point(24, 260);
            this.ButtonSend.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ButtonSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Primary = false;
            this.ButtonSend.Size = new System.Drawing.Size(77, 36);
            this.ButtonSend.TabIndex = 6;
            this.ButtonSend.Text = "GŁOSUJ";
            this.ButtonSend.UseVisualStyleBackColor = true;
            // 
            // Odp1
            // 
            this.Odp1.AutoSize = true;
            this.Odp1.Depth = 0;
            this.Odp1.Font = new System.Drawing.Font("Roboto", 10F);
            this.Odp1.Location = new System.Drawing.Point(24, 105);
            this.Odp1.Margin = new System.Windows.Forms.Padding(0);
            this.Odp1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Odp1.MouseState = MaterialSkin.MouseState.HOVER;
            this.Odp1.Name = "Odp1";
            this.Odp1.Ripple = true;
            this.Odp1.Size = new System.Drawing.Size(69, 30);
            this.Odp1.TabIndex = 7;
            this.Odp1.TabStop = true;
            this.Odp1.Text = "odp1";
            this.Odp1.UseVisualStyleBackColor = true;
            // 
            // Odp2
            // 
            this.Odp2.AutoSize = true;
            this.Odp2.Depth = 0;
            this.Odp2.Font = new System.Drawing.Font("Roboto", 10F);
            this.Odp2.Location = new System.Drawing.Point(24, 142);
            this.Odp2.Margin = new System.Windows.Forms.Padding(0);
            this.Odp2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Odp2.MouseState = MaterialSkin.MouseState.HOVER;
            this.Odp2.Name = "Odp2";
            this.Odp2.Ripple = true;
            this.Odp2.Size = new System.Drawing.Size(69, 30);
            this.Odp2.TabIndex = 8;
            this.Odp2.TabStop = true;
            this.Odp2.Text = "odp2";
            this.Odp2.UseVisualStyleBackColor = true;
            // 
            // Odp4
            // 
            this.Odp4.AutoSize = true;
            this.Odp4.Depth = 0;
            this.Odp4.Font = new System.Drawing.Font("Roboto", 10F);
            this.Odp4.Location = new System.Drawing.Point(24, 215);
            this.Odp4.Margin = new System.Windows.Forms.Padding(0);
            this.Odp4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Odp4.MouseState = MaterialSkin.MouseState.HOVER;
            this.Odp4.Name = "Odp4";
            this.Odp4.Ripple = true;
            this.Odp4.Size = new System.Drawing.Size(69, 30);
            this.Odp4.TabIndex = 10;
            this.Odp4.TabStop = true;
            this.Odp4.Text = "odp4";
            this.Odp4.UseVisualStyleBackColor = true;
            // 
            // Odp3
            // 
            this.Odp3.AutoSize = true;
            this.Odp3.Depth = 0;
            this.Odp3.Font = new System.Drawing.Font("Roboto", 10F);
            this.Odp3.Location = new System.Drawing.Point(24, 178);
            this.Odp3.Margin = new System.Windows.Forms.Padding(0);
            this.Odp3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Odp3.MouseState = MaterialSkin.MouseState.HOVER;
            this.Odp3.Name = "Odp3";
            this.Odp3.Ripple = true;
            this.Odp3.Size = new System.Drawing.Size(69, 30);
            this.Odp3.TabIndex = 9;
            this.Odp3.TabStop = true;
            this.Odp3.Text = "odp3";
            this.Odp3.UseVisualStyleBackColor = true;
            // 
            // SondControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.Odp4);
            this.Controls.Add(this.Odp3);
            this.Controls.Add(this.Odp2);
            this.Controls.Add(this.Odp1);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.LabelQuestion);
            this.Controls.Add(this.PanelTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SondControl";
            this.Size = new System.Drawing.Size(313, 303);
            this.Tag = "Open";
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label LabelName;
        private MaterialSkin.Controls.MaterialLabel LabelQuestion;
        private MaterialSkin.Controls.MaterialFlatButton ButtonSend;
        private MaterialSkin.Controls.MaterialRadioButton Odp1;
        private MaterialSkin.Controls.MaterialRadioButton Odp2;
        private MaterialSkin.Controls.MaterialRadioButton Odp4;
        private MaterialSkin.Controls.MaterialRadioButton Odp3;
    }
}
