namespace Artysci.UserControls
{
    partial class ucAnnouncements
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.login_user_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type_announ_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type_looking_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descr_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.annPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(290, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(82, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ogłoszenia";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.login_user_col,
            this.type_announ_col,
            this.type_looking_col,
            this.descr_col,
            this.date_col});
            this.listView1.Location = new System.Drawing.Point(29, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(614, 133);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // login_user_col
            // 
            this.login_user_col.Text = "Dodał";
            this.login_user_col.Width = 105;
            // 
            // type_announ_col
            // 
            this.type_announ_col.DisplayIndex = 3;
            this.type_announ_col.Text = "Rodzaj ogłoszenia";
            this.type_announ_col.Width = 107;
            // 
            // type_looking_col
            // 
            this.type_looking_col.DisplayIndex = 4;
            this.type_looking_col.Text = "Poszukuje";
            this.type_looking_col.Width = 88;
            // 
            // descr_col
            // 
            this.descr_col.DisplayIndex = 2;
            this.descr_col.Text = "Opis ogłoszenia";
            this.descr_col.Width = 205;
            // 
            // date_col
            // 
            this.date_col.DisplayIndex = 1;
            this.date_col.Text = "Data dodania";
            this.date_col.Width = 90;
            // 
            // annPanel
            // 
            this.annPanel.Location = new System.Drawing.Point(29, 185);
            this.annPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.annPanel.Name = "annPanel";
            this.annPanel.Size = new System.Drawing.Size(613, 351);
            this.annPanel.TabIndex = 2;
            // 
            // ucAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.annPanel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ucAnnouncements";
            this.Size = new System.Drawing.Size(690, 538);
            this.Load += new System.EventHandler(this.ucAnnouncements_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader login_user_col;
        private System.Windows.Forms.ColumnHeader type_announ_col;
        private System.Windows.Forms.ColumnHeader type_looking_col;
        private System.Windows.Forms.ColumnHeader descr_col;
        private System.Windows.Forms.ColumnHeader date_col;
        private System.Windows.Forms.Panel annPanel;
    }
}
