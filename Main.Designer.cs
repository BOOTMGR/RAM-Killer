namespace RAM_Cleaner_2
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.log_msgbox = new System.Windows.Forms.RichTextBox();
            this.but_analyse = new System.Windows.Forms.Button();
            this.but_clean = new System.Windows.Forms.Button();
            this.but_log_clean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveLog = new System.Windows.Forms.SaveFileDialog();
            this.mem_status = new System.Windows.Forms.Label();
            this.mem_status_free = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.advancedToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveLogToolStripMenuItem,
            this.clearLogToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveLogToolStripMenuItem
            // 
            this.saveLogToolStripMenuItem.Name = "saveLogToolStripMenuItem";
            this.saveLogToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveLogToolStripMenuItem.Text = "&Save Log";
            this.saveLogToolStripMenuItem.Click += new System.EventHandler(this.saveLogToolStripMenuItem_Click);
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.clearLogToolStripMenuItem.Text = "&Clear Log";
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.advancedToolStripMenuItem.Text = "&Advanced";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "&Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // log_msgbox
            // 
            this.log_msgbox.Location = new System.Drawing.Point(13, 28);
            this.log_msgbox.Name = "log_msgbox";
            this.log_msgbox.ReadOnly = true;
            this.log_msgbox.Size = new System.Drawing.Size(466, 278);
            this.log_msgbox.TabIndex = 1;
            this.log_msgbox.Text = "";
            // 
            // but_analyse
            // 
            this.but_analyse.Location = new System.Drawing.Point(13, 313);
            this.but_analyse.Name = "but_analyse";
            this.but_analyse.Size = new System.Drawing.Size(98, 86);
            this.but_analyse.TabIndex = 2;
            this.but_analyse.Text = "Analyse";
            this.but_analyse.UseVisualStyleBackColor = true;
            this.but_analyse.Click += new System.EventHandler(this.but_analyze_Click);
            // 
            // but_clean
            // 
            this.but_clean.Location = new System.Drawing.Point(117, 313);
            this.but_clean.Name = "but_clean";
            this.but_clean.Size = new System.Drawing.Size(98, 86);
            this.but_clean.TabIndex = 3;
            this.but_clean.Text = "Clean";
            this.but_clean.UseVisualStyleBackColor = true;
            this.but_clean.Click += new System.EventHandler(this.but_clean_Click);
            // 
            // but_log_clean
            // 
            this.but_log_clean.Location = new System.Drawing.Point(404, 313);
            this.but_log_clean.Name = "but_log_clean";
            this.but_log_clean.Size = new System.Drawing.Size(75, 42);
            this.but_log_clean.TabIndex = 4;
            this.but_log_clean.Text = "Clear Log";
            this.but_log_clean.UseVisualStyleBackColor = true;
            this.but_log_clean.Click += new System.EventHandler(this.but_log_clean_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Copyright  2014-2020 Harsh Panchal";
            // 
            // mem_status
            // 
            this.mem_status.AutoSize = true;
            this.mem_status.Location = new System.Drawing.Point(221, 313);
            this.mem_status.Name = "mem_status";
            this.mem_status.Size = new System.Drawing.Size(0, 13);
            this.mem_status.TabIndex = 6;
            this.mem_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mem_status_free
            // 
            this.mem_status_free.AutoSize = true;
            this.mem_status_free.Location = new System.Drawing.Point(221, 328);
            this.mem_status_free.Name = "mem_status_free";
            this.mem_status_free.Size = new System.Drawing.Size(0, 13);
            this.mem_status_free.TabIndex = 7;
            this.mem_status_free.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 411);
            this.Controls.Add(this.mem_status_free);
            this.Controls.Add(this.mem_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_log_clean);
            this.Controls.Add(this.but_clean);
            this.Controls.Add(this.but_analyse);
            this.Controls.Add(this.log_msgbox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "RAM Cleaner";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.RichTextBox log_msgbox;
        private System.Windows.Forms.Button but_analyse;
        private System.Windows.Forms.Button but_clean;
        private System.Windows.Forms.Button but_log_clean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveLog;
        private System.Windows.Forms.Label mem_status;
        private System.Windows.Forms.Label mem_status_free;
    }
}

