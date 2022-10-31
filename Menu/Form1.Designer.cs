namespace Menu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Theme_Light = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Theme_Dark = new System.Windows.Forms.ToolStripMenuItem();
            this.темнаяТемаToolStripMenuItem = new System.Windows.Forms.ToolStripDropDownMenu();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Theme_Light,
            this.mi_Theme_Dark});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // mi_Theme_Light
            // 
            this.mi_Theme_Light.Checked = true;
            this.mi_Theme_Light.CheckOnClick = true;
            this.mi_Theme_Light.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_Theme_Light.Name = "mi_Theme_Light";
            this.mi_Theme_Light.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mi_Theme_Light.Size = new System.Drawing.Size(180, 22);
            this.mi_Theme_Light.Text = "Light";
            this.mi_Theme_Light.Click += new System.EventHandler(this.mi_Theme_Light_Click);
            // 
            // mi_Theme_Dark
            // 
            this.mi_Theme_Dark.CheckOnClick = true;
            this.mi_Theme_Dark.Name = "mi_Theme_Dark";
            this.mi_Theme_Dark.Size = new System.Drawing.Size(180, 22);
            this.mi_Theme_Dark.Text = "Dark";
            this.mi_Theme_Dark.Click += new System.EventHandler(this.mi_Theme_Dark_Click_1);
            // 
            // темнаяТемаToolStripMenuItem
            // 
            this.темнаяТемаToolStripMenuItem.AutoClose = false;
            this.темнаяТемаToolStripMenuItem.Name = "темнаяТемаToolStripMenuItem";
            this.темнаяТемаToolStripMenuItem.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem mi_Theme_Light;
        private ToolStripMenuItem mi_Theme_Dark;
        private ToolStripDropDownMenu темнаяТемаToolStripMenuItem;
    }
}