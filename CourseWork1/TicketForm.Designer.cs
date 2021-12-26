﻿namespace CourseWork1
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
            this.TicketsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddRate = new System.Windows.Forms.Button();
            this.TicketFirstRate = new System.Windows.Forms.NumericUpDown();
            this.TicketSecondRate = new System.Windows.Forms.NumericUpDown();
            this.TicketType = new System.Windows.Forms.ComboBox();
            this.TicketThirdRate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TicketId = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Terms = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketFirstRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketSecondRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketThirdRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketId)).BeginInit();
            this.SuspendLayout();
            // 
            // TicketsGridView
            // 
            this.TicketsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketsGridView.Location = new System.Drawing.Point(271, 42);
            this.TicketsGridView.Name = "TicketsGridView";
            this.TicketsGridView.Size = new System.Drawing.Size(484, 293);
            this.TicketsGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1 Hour Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "2 Hour Rate";
            // 
            // btnAddRate
            // 
            this.btnAddRate.Location = new System.Drawing.Point(75, 306);
            this.btnAddRate.Name = "btnAddRate";
            this.btnAddRate.Size = new System.Drawing.Size(107, 29);
            this.btnAddRate.TabIndex = 4;
            this.btnAddRate.Text = "Add";
            this.btnAddRate.UseVisualStyleBackColor = true;
            this.btnAddRate.Click += new System.EventHandler(this.btnAddRate_Click);
            // 
            // TicketFirstRate
            // 
            this.TicketFirstRate.Location = new System.Drawing.Point(147, 157);
            this.TicketFirstRate.Name = "TicketFirstRate";
            this.TicketFirstRate.Size = new System.Drawing.Size(84, 20);
            this.TicketFirstRate.TabIndex = 1;
            // 
            // TicketSecondRate
            // 
            this.TicketSecondRate.Location = new System.Drawing.Point(147, 209);
            this.TicketSecondRate.Name = "TicketSecondRate";
            this.TicketSecondRate.Size = new System.Drawing.Size(84, 20);
            this.TicketSecondRate.TabIndex = 2;
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
            this.TicketType.Location = new System.Drawing.Point(147, 103);
            this.TicketType.Name = "TicketType";
            this.TicketType.Size = new System.Drawing.Size(84, 21);
            this.TicketType.TabIndex = 0;
            // 
            // TicketThirdRate
            // 
            this.TicketThirdRate.Location = new System.Drawing.Point(147, 256);
            this.TicketThirdRate.Name = "TicketThirdRate";
            this.TicketThirdRate.Size = new System.Drawing.Size(84, 20);
            this.TicketThirdRate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "3 Hour Rate";
            // 
            // TicketId
            // 
            this.TicketId.Location = new System.Drawing.Point(145, 55);
            this.TicketId.Name = "TicketId";
            this.TicketId.Size = new System.Drawing.Size(86, 20);
            this.TicketId.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ticket Id";
            // 
            // Terms
            // 
            this.Terms.AutoSize = true;
            this.Terms.Location = new System.Drawing.Point(268, 406);
            this.Terms.Name = "Terms";
            this.Terms.Size = new System.Drawing.Size(193, 13);
            this.Terms.TabIndex = 12;
            this.Terms.Text = "Terms and condictions Apply for groups";
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Terms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TicketId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TicketThirdRate);
            this.Controls.Add(this.TicketType);
            this.Controls.Add(this.TicketSecondRate);
            this.Controls.Add(this.TicketFirstRate);
            this.Controls.Add(this.btnAddRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TicketsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.Load += new System.EventHandler(this.TicketForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.TicketsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketFirstRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketSecondRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketThirdRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TicketId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TicketsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddRate;
        private System.Windows.Forms.NumericUpDown TicketFirstRate;
        private System.Windows.Forms.NumericUpDown TicketSecondRate;
        private System.Windows.Forms.ComboBox TicketType;
        private System.Windows.Forms.NumericUpDown TicketThirdRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TicketId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Terms;
    }
}