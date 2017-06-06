namespace Artysci.UserControls
{
    partial class ucSonds
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
            this.listViewSonds = new System.Windows.Forms.ListView();
            this.sondPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(305, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "sondy";
            // 
            // listViewSonds
            // 
            this.listViewSonds.Location = new System.Drawing.Point(30, 40);
            this.listViewSonds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewSonds.Name = "listViewSonds";
            this.listViewSonds.Size = new System.Drawing.Size(630, 140);
            this.listViewSonds.TabIndex = 1;
            this.listViewSonds.UseCompatibleStateImageBehavior = false;
            this.listViewSonds.DoubleClick += new System.EventHandler(this.listViewSonds_DoubleClick);
            // 
            // sondPanel
            // 
            this.sondPanel.Location = new System.Drawing.Point(30, 184);
            this.sondPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sondPanel.Name = "sondPanel";
            this.sondPanel.Size = new System.Drawing.Size(630, 290);
            this.sondPanel.TabIndex = 2;
            // 
            // ucSonds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sondPanel);
            this.Controls.Add(this.listViewSonds);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ucSonds";
            this.Size = new System.Drawing.Size(690, 538);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ListView listViewSonds;
        private System.Windows.Forms.Panel sondPanel;
    }
}
