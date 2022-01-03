
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
            this.LabelDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnEntryForm = new System.Windows.Forms.Button();
            this.btnExitForm = new System.Windows.Forms.Button();
            this.btnDailyRepForm = new System.Windows.Forms.Button();
            this.btnWeeklyRepForm = new System.Windows.Forms.Button();
            this.btnTicketsForm = new System.Windows.Forms.Button();
            this.labelEmployeeMsg = new System.Windows.Forms.Label();
            this.labelGreetUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnWeekdaysRate = new System.Windows.Forms.Button();
            this.btnWeekendRate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlText;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelDate.Location = new System.Drawing.Point(306, 6);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(53, 13);
            this.LabelDate.TabIndex = 9;
            this.LabelDate.Text = "DateHere";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(599, 1);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnEntryForm
            // 
            this.btnEntryForm.Location = new System.Drawing.Point(40, 419);
            this.btnEntryForm.Name = "btnEntryForm";
            this.btnEntryForm.Size = new System.Drawing.Size(123, 40);
            this.btnEntryForm.TabIndex = 12;
            this.btnEntryForm.Text = "Visitor Entry";
            this.btnEntryForm.UseVisualStyleBackColor = true;
            this.btnEntryForm.Click += new System.EventHandler(this.btnEntryForm_Click);
            // 
            // btnExitForm
            // 
            this.btnExitForm.Location = new System.Drawing.Point(606, 419);
            this.btnExitForm.Name = "btnExitForm";
            this.btnExitForm.Size = new System.Drawing.Size(123, 40);
            this.btnExitForm.TabIndex = 13;
            this.btnExitForm.Text = "Visitor Exit";
            this.btnExitForm.UseVisualStyleBackColor = true;
            this.btnExitForm.Click += new System.EventHandler(this.btnExitForm_Click);
            // 
            // btnDailyRepForm
            // 
            this.btnDailyRepForm.Location = new System.Drawing.Point(40, 222);
            this.btnDailyRepForm.Name = "btnDailyRepForm";
            this.btnDailyRepForm.Size = new System.Drawing.Size(123, 40);
            this.btnDailyRepForm.TabIndex = 14;
            this.btnDailyRepForm.Text = "Daily Report";
            this.btnDailyRepForm.UseVisualStyleBackColor = true;
            this.btnDailyRepForm.Click += new System.EventHandler(this.btnDailyRepForm_Click);
            // 
            // btnWeeklyRepForm
            // 
            this.btnWeeklyRepForm.Location = new System.Drawing.Point(599, 222);
            this.btnWeeklyRepForm.Name = "btnWeeklyRepForm";
            this.btnWeeklyRepForm.Size = new System.Drawing.Size(123, 40);
            this.btnWeeklyRepForm.TabIndex = 15;
            this.btnWeeklyRepForm.Text = "Weekly Report";
            this.btnWeeklyRepForm.UseVisualStyleBackColor = true;
            this.btnWeeklyRepForm.Click += new System.EventHandler(this.btnWeeklyRepForm_Click);
            // 
            // btnTicketsForm
            // 
            this.btnTicketsForm.Location = new System.Drawing.Point(319, 212);
            this.btnTicketsForm.Name = "btnTicketsForm";
            this.btnTicketsForm.Size = new System.Drawing.Size(123, 40);
            this.btnTicketsForm.TabIndex = 16;
            this.btnTicketsForm.Text = "Manage Tickets";
            this.btnTicketsForm.UseVisualStyleBackColor = true;
            this.btnTicketsForm.Click += new System.EventHandler(this.btnTicketsForm_Click);
            // 
            // labelEmployeeMsg
            // 
            this.labelEmployeeMsg.AutoSize = true;
            this.labelEmployeeMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeMsg.ForeColor = System.Drawing.Color.Red;
            this.labelEmployeeMsg.Location = new System.Drawing.Point(299, 509);
            this.labelEmployeeMsg.Name = "labelEmployeeMsg";
            this.labelEmployeeMsg.Size = new System.Drawing.Size(196, 17);
            this.labelEmployeeMsg.TabIndex = 17;
            this.labelEmployeeMsg.Text = "Login as Admin for full access";
            // 
            // labelGreetUser
            // 
            this.labelGreetUser.AutoSize = true;
            this.labelGreetUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelGreetUser.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGreetUser.Location = new System.Drawing.Point(30, 6);
            this.labelGreetUser.Name = "labelGreetUser";
            this.labelGreetUser.Size = new System.Drawing.Size(35, 13);
            this.labelGreetUser.TabIndex = 18;
            this.labelGreetUser.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(599, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 93);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(33, 103);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 93);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(319, 93);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 93);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(599, 103);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 93);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Recreation Center";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 295);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 93);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // btnWeekdaysRate
            // 
            this.btnWeekdaysRate.Location = new System.Drawing.Point(199, 286);
            this.btnWeekdaysRate.Name = "btnWeekdaysRate";
            this.btnWeekdaysRate.Size = new System.Drawing.Size(123, 40);
            this.btnWeekdaysRate.TabIndex = 26;
            this.btnWeekdaysRate.Text = "Weekdays Rate";
            this.btnWeekdaysRate.UseVisualStyleBackColor = true;
            this.btnWeekdaysRate.Click += new System.EventHandler(this.btnWeekdaysRate_Click);
            // 
            // btnWeekendRate
            // 
            this.btnWeekendRate.Location = new System.Drawing.Point(446, 286);
            this.btnWeekendRate.Name = "btnWeekendRate";
            this.btnWeekendRate.Size = new System.Drawing.Size(123, 40);
            this.btnWeekendRate.TabIndex = 27;
            this.btnWeekendRate.Text = "Weekend Rate";
            this.btnWeekendRate.UseVisualStyleBackColor = true;
            this.btnWeekendRate.Click += new System.EventHandler(this.btnWeekendRate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnWeekendRate);
            this.Controls.Add(this.btnWeekdaysRate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelGreetUser);
            this.Controls.Add(this.labelEmployeeMsg);
            this.Controls.Add(this.btnTicketsForm);
            this.Controls.Add(this.btnWeeklyRepForm);
            this.Controls.Add(this.btnDailyRepForm);
            this.Controls.Add(this.btnExitForm);
            this.Controls.Add(this.btnEntryForm);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.LabelDate);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Vistor Record Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnEntryForm;
        private System.Windows.Forms.Button btnExitForm;
        private System.Windows.Forms.Button btnDailyRepForm;
        private System.Windows.Forms.Button btnWeeklyRepForm;
        private System.Windows.Forms.Button btnTicketsForm;
        private System.Windows.Forms.Label labelEmployeeMsg;
        private System.Windows.Forms.Label labelGreetUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnWeekdaysRate;
        private System.Windows.Forms.Button btnWeekendRate;
    }
}

