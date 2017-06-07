namespace Artysci.Forms
{
    partial class checkAnnoun
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
            this.appLV = new System.Windows.Forms.ListView();
            this.login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zatwierdzienie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // appLV
            // 
            this.appLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.login,
            this.zatwierdzienie});
            this.appLV.Location = new System.Drawing.Point(12, 85);
            this.appLV.Name = "appLV";
            this.appLV.Size = new System.Drawing.Size(504, 115);
            this.appLV.TabIndex = 0;
            this.appLV.UseCompatibleStateImageBehavior = false;
            this.appLV.View = System.Windows.Forms.View.Details;
            this.appLV.DoubleClick += new System.EventHandler(this.appLV_DoubleClick);
            // 
            // login
            // 
            this.login.Text = "Login";
            this.login.Width = 212;
            // 
            // zatwierdzienie
            // 
            this.zatwierdzienie.Text = "Zatwierdzenie";
            this.zatwierdzienie.Width = 285;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(13, 274);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(87, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "Zatwierdź";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(439, 274);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(76, 36);
            this.materialFlatButton3.TabIndex = 3;
            this.materialFlatButton3.Text = "Odwołaj";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // checkAnnoun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 325);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.appLV);
            this.Name = "checkAnnoun";
            this.Text = "Sprawdź kto się zgłosił";
            this.Load += new System.EventHandler(this.checkAnnoun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView appLV;
        private System.Windows.Forms.ColumnHeader login;
        private System.Windows.Forms.ColumnHeader zatwierdzienie;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
    }
}