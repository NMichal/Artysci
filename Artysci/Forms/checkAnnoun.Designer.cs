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
            // checkAnnoun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 325);
            this.Controls.Add(this.appLV);
            this.Name = "checkAnnoun";
            this.Text = "Sprawdź kto się zgłosił";
            this.Load += new System.EventHandler(this.checkAnnoun_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView appLV;
        private System.Windows.Forms.ColumnHeader login;
        private System.Windows.Forms.ColumnHeader zatwierdzienie;
    }
}