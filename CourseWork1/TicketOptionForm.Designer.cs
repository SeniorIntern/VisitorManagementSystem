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
            this.SuspendLayout();
            // 
            // btnWeekdaysTicket
            // 
            this.btnWeekdaysTicket.Location = new System.Drawing.Point(70, 87);
            this.btnWeekdaysTicket.Name = "btnWeekdaysTicket";
            this.btnWeekdaysTicket.Size = new System.Drawing.Size(104, 39);
            this.btnWeekdaysTicket.TabIndex = 0;
            this.btnWeekdaysTicket.Text = "Weekdays ";
            this.btnWeekdaysTicket.UseVisualStyleBackColor = true;
            this.btnWeekdaysTicket.Click += new System.EventHandler(this.btnWeekdaysTicket_Click);
            // 
            // btnHolidaysTicket
            // 
            this.btnHolidaysTicket.Location = new System.Drawing.Point(247, 87);
            this.btnHolidaysTicket.Name = "btnHolidaysTicket";
            this.btnHolidaysTicket.Size = new System.Drawing.Size(104, 39);
            this.btnHolidaysTicket.TabIndex = 1;
            this.btnHolidaysTicket.Text = "Holidays";
            this.btnHolidaysTicket.UseVisualStyleBackColor = true;
            this.btnHolidaysTicket.Click += new System.EventHandler(this.btnHolidaysTicket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Ticket Type";
            // 
            // TicketOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 218);
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
    }
}