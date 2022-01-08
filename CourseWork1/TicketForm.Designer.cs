namespace CourseWork1
{
    partial class TicketForm
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
            this.WeekdayTicketsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TicketType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.weekdayTicketId = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Terms = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateWDRate = new System.Windows.Forms.Button();
            this.tbWdRate1hr = new System.Windows.Forms.TextBox();
            this.tbWdRate2hr = new System.Windows.Forms.TextBox();
            this.tbWdRate3hr = new System.Windows.Forms.TextBox();
            this.tbWdRateXhr = new System.Windows.Forms.TextBox();
            this.tbWdRate4hr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeekdayTicketsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekdayTicketId)).BeginInit();
            this.SuspendLayout();
            // 
            // WeekdayTicketsGridView
            // 
            this.WeekdayTicketsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeekdayTicketsGridView.Location = new System.Drawing.Point(238, 54);
            this.WeekdayTicketsGridView.Name = "WeekdayTicketsGridView";
            this.WeekdayTicketsGridView.Size = new System.Drawing.Size(518, 240);
            this.WeekdayTicketsGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "1 Hour Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "2 Hour Rate";
            // 
            // TicketType
            // 
            this.TicketType.FormattingEnabled = true;
            this.TicketType.Items.AddRange(new object[] {
            "Adult",
            "Child",
            "Group5",
            "Group10",
            "Group15"});
            this.TicketType.Location = new System.Drawing.Point(137, 90);
            this.TicketType.Name = "TicketType";
            this.TicketType.Size = new System.Drawing.Size(84, 21);
            this.TicketType.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "3 Hour Rate";
            // 
            // weekdayTicketId
            // 
            this.weekdayTicketId.Location = new System.Drawing.Point(137, 54);
            this.weekdayTicketId.Name = "weekdayTicketId";
            this.weekdayTicketId.Size = new System.Drawing.Size(86, 20);
            this.weekdayTicketId.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ticket Id";
            // 
            // Terms
            // 
            this.Terms.AutoSize = true;
            this.Terms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Terms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Terms.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Terms.Location = new System.Drawing.Point(331, 9);
            this.Terms.Name = "Terms";
            this.Terms.Size = new System.Drawing.Size(154, 24);
            this.Terms.TabIndex = 12;
            this.Terms.Text = "Weekdays Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(12, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Whole Day Rate";
            // 
            // btnUpdateWDRate
            // 
            this.btnUpdateWDRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnUpdateWDRate.FlatAppearance.BorderSize = 0;
            this.btnUpdateWDRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateWDRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateWDRate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateWDRate.Location = new System.Drawing.Point(43, 354);
            this.btnUpdateWDRate.Name = "btnUpdateWDRate";
            this.btnUpdateWDRate.Size = new System.Drawing.Size(109, 39);
            this.btnUpdateWDRate.TabIndex = 16;
            this.btnUpdateWDRate.Text = "Update";
            this.btnUpdateWDRate.UseVisualStyleBackColor = false;
            this.btnUpdateWDRate.Click += new System.EventHandler(this.btnUpdateRate_Click);
            // 
            // tbWdRate1hr
            // 
            this.tbWdRate1hr.Location = new System.Drawing.Point(137, 135);
            this.tbWdRate1hr.Name = "tbWdRate1hr";
            this.tbWdRate1hr.Size = new System.Drawing.Size(84, 20);
            this.tbWdRate1hr.TabIndex = 2;
            // 
            // tbWdRate2hr
            // 
            this.tbWdRate2hr.Location = new System.Drawing.Point(137, 187);
            this.tbWdRate2hr.Name = "tbWdRate2hr";
            this.tbWdRate2hr.Size = new System.Drawing.Size(84, 20);
            this.tbWdRate2hr.TabIndex = 3;
            // 
            // tbWdRate3hr
            // 
            this.tbWdRate3hr.Location = new System.Drawing.Point(137, 239);
            this.tbWdRate3hr.Name = "tbWdRate3hr";
            this.tbWdRate3hr.Size = new System.Drawing.Size(84, 20);
            this.tbWdRate3hr.TabIndex = 4;
            // 
            // tbWdRateXhr
            // 
            this.tbWdRateXhr.Location = new System.Drawing.Point(137, 311);
            this.tbWdRateXhr.Name = "tbWdRateXhr";
            this.tbWdRateXhr.Size = new System.Drawing.Size(84, 20);
            this.tbWdRateXhr.TabIndex = 6;
            // 
            // tbWdRate4hr
            // 
            this.tbWdRate4hr.Location = new System.Drawing.Point(137, 274);
            this.tbWdRate4hr.Name = "tbWdRate4hr";
            this.tbWdRate4hr.Size = new System.Drawing.Size(84, 20);
            this.tbWdRate4hr.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(12, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "4 Hour Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Use Type for updating the rate values";
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbWdRate4hr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbWdRateXhr);
            this.Controls.Add(this.tbWdRate3hr);
            this.Controls.Add(this.tbWdRate2hr);
            this.Controls.Add(this.tbWdRate1hr);
            this.Controls.Add(this.btnUpdateWDRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Terms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.weekdayTicketId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TicketType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeekdayTicketsGridView);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeekdayTicketsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekdayTicketId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WeekdayTicketsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TicketType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown weekdayTicketId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Terms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdateWDRate;
        private System.Windows.Forms.TextBox tbWdRate1hr;
        private System.Windows.Forms.TextBox tbWdRate2hr;
        private System.Windows.Forms.TextBox tbWdRate3hr;
        private System.Windows.Forms.TextBox tbWdRateXhr;
        private System.Windows.Forms.TextBox tbWdRate4hr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}