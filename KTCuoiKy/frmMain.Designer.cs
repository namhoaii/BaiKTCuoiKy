namespace KTCuoiKy
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiNămDươngLịchSangÂmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiSốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.táchHọTênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khácHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiNămDươngLịchSangÂmToolStripMenuItem,
            this.đổiSốToolStripMenuItem,
            this.táchHọTênToolStripMenuItem,
            this.khácHàngToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "&Chức năng";
            // 
            // đổiNămDươngLịchSangÂmToolStripMenuItem
            // 
            this.đổiNămDươngLịchSangÂmToolStripMenuItem.Name = "đổiNămDươngLịchSangÂmToolStripMenuItem";
            this.đổiNămDươngLịchSangÂmToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.đổiNămDươngLịchSangÂmToolStripMenuItem.Text = "Đổi &năm dương lịch sang âm";
            this.đổiNămDươngLịchSangÂmToolStripMenuItem.Click += new System.EventHandler(this.đổiNămDươngLịchSangÂmToolStripMenuItem_Click);
            // 
            // đổiSốToolStripMenuItem
            // 
            this.đổiSốToolStripMenuItem.Name = "đổiSốToolStripMenuItem";
            this.đổiSốToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.đổiSốToolStripMenuItem.Text = "Đổi &số thập sang nhị và ngược lại";
            this.đổiSốToolStripMenuItem.Click += new System.EventHandler(this.đổiSốToolStripMenuItem_Click);
            // 
            // táchHọTênToolStripMenuItem
            // 
            this.táchHọTênToolStripMenuItem.Name = "táchHọTênToolStripMenuItem";
            this.táchHọTênToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.táchHọTênToolStripMenuItem.Text = "&Tách họ tên";
            this.táchHọTênToolStripMenuItem.Click += new System.EventHandler(this.táchHọTênToolStripMenuItem_Click);
            // 
            // khácHàngToolStripMenuItem
            // 
            this.khácHàngToolStripMenuItem.Name = "khácHàngToolStripMenuItem";
            this.khácHàngToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.khácHàngToolStripMenuItem.Text = "&Khách hàng";
            this.khácHàngToolStripMenuItem.Click += new System.EventHandler(this.khácHàngToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.frmMain_Validating);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiNămDươngLịchSangÂmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiSốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem táchHọTênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khácHàngToolStripMenuItem;
    }
}

