namespace CourseWork1
{
    partial class TicketOptionForm
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
            this.btnWeekdaysTicket = new System.Windows.Forms.Button();
            this.btnHolidaysTicket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWeekdaysTicket
            // 
            this.btnWeekdaysTicket.Location = new System.Drawing.Point(75, 87);
            this.btnWeekdaysTicket.Name = "btnWeekdaysTicket";
            this.btnWeekdaysTicket.Size = new System.Drawing.Size(104, 39);
            this.btnWeekdaysTicket.TabIndex = 0;
            this.btnWeekdaysTicket.Text = "Update Weekdays Rate";
            this.btnWeekdaysTicket.UseVisualStyleBackColor = true;
            this.btnWeekdaysTicket.Click += new System.EventHandler(this.btnWeekdaysTicket_Click);
            // 
            // btnHolidaysTicket
            // 
            this.btnHolidaysTicket.Location = new System.Drawing.Point(242, 87);
            this.btnHolidaysTicket.Name = "btnHolidaysTicket";
            this.btnHolidaysTicket.Size = new System.Drawing.Size(104, 39);
            this.btnHolidaysTicket.TabIndex = 1;
            this.btnHolidaysTicket.Text = "Update Weekend Rate";
            this.btnHolidaysTicket.UseVisualStyleBackColor = true;
            this.btnHolidaysTicket.Click += new System.EventHandler(this.btnHolidaysTicket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Ticket Action";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Weekdays Rate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add Weekend Rate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TicketOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 218);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHolidaysTicket);
            this.Controls.Add(this.btnWeekdaysTicket);
            this.Name = "TicketOptionForm";
            this.Text = "TicketOptions";
            this.Load += new System.EventHandler(this.TicketOptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWeekdaysTicket;
        private System.Windows.Forms.Button btnHolidaysTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}