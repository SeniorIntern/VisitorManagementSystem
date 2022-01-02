namespace CourseWork1
{
    partial class WeekendTicketForm
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
            this.WeekendTicketsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateWERate = new System.Windows.Forms.Button();
            this.tbWeRate1hr = new System.Windows.Forms.TextBox();
            this.weekendTicketType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbWeRate2hr = new System.Windows.Forms.TextBox();
            this.tbWeRate3hr = new System.Windows.Forms.TextBox();
            this.tbWeRateXhr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.weekendTicketId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.WeekendTicketsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekendTicketId)).BeginInit();
            this.SuspendLayout();
            // 
            // WeekendTicketsGridView
            // 
            this.WeekendTicketsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeekendTicketsGridView.Location = new System.Drawing.Point(260, 31);
            this.WeekendTicketsGridView.Name = "WeekendTicketsGridView";
            this.WeekendTicketsGridView.Size = new System.Drawing.Size(500, 293);
            this.WeekendTicketsGridView.StandardTab = true;
            this.WeekendTicketsGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ticket Type";
            // 
            // btnUpdateWERate
            // 
            this.btnUpdateWERate.Location = new System.Drawing.Point(82, 358);
            this.btnUpdateWERate.Name = "btnUpdateWERate";
            this.btnUpdateWERate.Size = new System.Drawing.Size(92, 37);
            this.btnUpdateWERate.TabIndex = 6;
            this.btnUpdateWERate.Text = "Update";
            this.btnUpdateWERate.UseVisualStyleBackColor = true;
            this.btnUpdateWERate.Click += new System.EventHandler(this.btnUpdateWERate_Click);
            // 
            // tbWeRate1hr
            // 
            this.tbWeRate1hr.Location = new System.Drawing.Point(164, 128);
            this.tbWeRate1hr.Name = "tbWeRate1hr";
            this.tbWeRate1hr.Size = new System.Drawing.Size(78, 20);
            this.tbWeRate1hr.TabIndex = 2;
            // 
            // weekendTicketType
            // 
            this.weekendTicketType.FormattingEnabled = true;
            this.weekendTicketType.Items.AddRange(new object[] {
            "Adult",
            "Child",
            "Group5",
            "Group10",
            "Group15"});
            this.weekendTicketType.Location = new System.Drawing.Point(147, 78);
            this.weekendTicketType.Name = "weekendTicketType";
            this.weekendTicketType.Size = new System.Drawing.Size(95, 21);
            this.weekendTicketType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rate 1 Hour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rate 2 Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rate 3 Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rate Whole Day";
            // 
            // tbWeRate2hr
            // 
            this.tbWeRate2hr.Location = new System.Drawing.Point(164, 181);
            this.tbWeRate2hr.Name = "tbWeRate2hr";
            this.tbWeRate2hr.Size = new System.Drawing.Size(78, 20);
            this.tbWeRate2hr.TabIndex = 3;
            // 
            // tbWeRate3hr
            // 
            this.tbWeRate3hr.Location = new System.Drawing.Point(164, 236);
            this.tbWeRate3hr.Name = "tbWeRate3hr";
            this.tbWeRate3hr.Size = new System.Drawing.Size(78, 20);
            this.tbWeRate3hr.TabIndex = 4;
            // 
            // tbWeRateXhr
            // 
            this.tbWeRateXhr.Location = new System.Drawing.Point(164, 293);
            this.tbWeRateXhr.Name = "tbWeRateXhr";
            this.tbWeRateXhr.Size = new System.Drawing.Size(78, 20);
            this.tbWeRateXhr.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ticket Id";
            // 
            // weekendTicketId
            // 
            this.weekendTicketId.Location = new System.Drawing.Point(156, 34);
            this.weekendTicketId.Name = "weekendTicketId";
            this.weekendTicketId.Size = new System.Drawing.Size(86, 20);
            this.weekendTicketId.TabIndex = 0;
            // 
            // WeekendTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.weekendTicketId);
            this.Controls.Add(this.tbWeRateXhr);
            this.Controls.Add(this.tbWeRate3hr);
            this.Controls.Add(this.tbWeRate2hr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weekendTicketType);
            this.Controls.Add(this.tbWeRate1hr);
            this.Controls.Add(this.btnUpdateWERate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeekendTicketsGridView);
            this.Name = "WeekendTicketForm";
            this.Text = "WeekendTicketForm";
            this.Load += new System.EventHandler(this.WeekendTicketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeekendTicketsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekendTicketId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView WeekendTicketsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateWERate;
        private System.Windows.Forms.TextBox tbWeRate1hr;
        private System.Windows.Forms.ComboBox weekendTicketType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbWeRate2hr;
        private System.Windows.Forms.TextBox tbWeRate3hr;
        private System.Windows.Forms.TextBox tbWeRateXhr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown weekendTicketId;
    }
}