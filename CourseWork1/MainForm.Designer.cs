
namespace CourseWork1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EntryFormMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitFormMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportFormMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TicketFormMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.VisitorFormMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.TicketFormMenu,
            this.VisitorFormMenu,
            this.uSERToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntryFormMenu,
            this.ExitFormMenu,
            this.ReportFormMenu});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // EntryFormMenu
            // 
            this.EntryFormMenu.Name = "EntryFormMenu";
            this.EntryFormMenu.Size = new System.Drawing.Size(109, 22);
            this.EntryFormMenu.Text = "Entry";
            this.EntryFormMenu.Click += new System.EventHandler(this.EntryFormMenu_Click);
            // 
            // ExitFormMenu
            // 
            this.ExitFormMenu.Name = "ExitFormMenu";
            this.ExitFormMenu.Size = new System.Drawing.Size(109, 22);
            this.ExitFormMenu.Text = "Exit";
            this.ExitFormMenu.Click += new System.EventHandler(this.ExitFormMenu_Click);
            // 
            // ReportFormMenu
            // 
            this.ReportFormMenu.Name = "ReportFormMenu";
            this.ReportFormMenu.Size = new System.Drawing.Size(109, 22);
            this.ReportFormMenu.Text = "Report";
            this.ReportFormMenu.Click += new System.EventHandler(this.ReportFormMenu_Click);
            // 
            // TicketFormMenu
            // 
            this.TicketFormMenu.Name = "TicketFormMenu";
            this.TicketFormMenu.Size = new System.Drawing.Size(50, 20);
            this.TicketFormMenu.Text = "Ticket";
            this.TicketFormMenu.Click += new System.EventHandler(this.TicketFormMenu_Click);
            // 
            // VisitorFormMenu
            // 
            this.VisitorFormMenu.Name = "VisitorFormMenu";
            this.VisitorFormMenu.Size = new System.Drawing.Size(57, 20);
            this.VisitorFormMenu.Text = "Visitors";
            this.VisitorFormMenu.Click += new System.EventHandler(this.VisitorFormMenu_Click);
            // 
            // uSERToolStripMenuItem
            // 
            this.uSERToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.uSERToolStripMenuItem.Name = "uSERToolStripMenuItem";
            this.uSERToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.uSERToolStripMenuItem.Text = "USER";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(567, 9);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(53, 13);
            this.LabelDate.TabIndex = 9;
            this.LabelDate.Text = "DateHere";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Vistor Record Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EntryFormMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitFormMenu;
        private System.Windows.Forms.ToolStripMenuItem ReportFormMenu;
        private System.Windows.Forms.ToolStripMenuItem TicketFormMenu;
        private System.Windows.Forms.ToolStripMenuItem VisitorFormMenu;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.ToolStripMenuItem uSERToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

