﻿
namespace CourseWork1
{
    partial class ExitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.searchId = new System.Windows.Forms.NumericUpDown();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelEntry = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.labelRateType = new System.Windows.Forms.Label();
            this.radioButtonApplyWeekendRate = new System.Windows.Forms.RadioButton();
            this.radioButtonApplyWeekdayRate = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.searchId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(29, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Entry";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(29, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Exit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(29, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(29, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cost";
            // 
            // searchId
            // 
            this.searchId.Location = new System.Drawing.Point(136, 30);
            this.searchId.Name = "searchId";
            this.searchId.Size = new System.Drawing.Size(70, 20);
            this.searchId.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(232, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(63, 336);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 33);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCount.Location = new System.Drawing.Point(132, 112);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(57, 20);
            this.labelCount.TabIndex = 10;
            this.labelCount.Text = "label8";
            this.labelCount.Visible = false;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelType.Location = new System.Drawing.Point(132, 70);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(57, 20);
            this.labelType.TabIndex = 11;
            this.labelType.Text = "label9";
            this.labelType.Visible = false;
            // 
            // labelEntry
            // 
            this.labelEntry.AutoSize = true;
            this.labelEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelEntry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEntry.Location = new System.Drawing.Point(132, 154);
            this.labelEntry.Name = "labelEntry";
            this.labelEntry.Size = new System.Drawing.Size(19, 20);
            this.labelEntry.TabIndex = 12;
            this.labelEntry.Text = "e";
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelExit.Location = new System.Drawing.Point(132, 196);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(67, 20);
            this.labelExit.TabIndex = 13;
            this.labelExit.Text = "label11";
            this.labelExit.Visible = false;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelDuration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDuration.Location = new System.Drawing.Point(132, 241);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(67, 20);
            this.labelDuration.TabIndex = 14;
            this.labelDuration.Text = "label12";
            this.labelDuration.Visible = false;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.labelCost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCost.Location = new System.Drawing.Point(132, 287);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(67, 20);
            this.labelCost.TabIndex = 15;
            this.labelCost.Text = "label13";
            this.labelCost.Visible = false;
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnComplete.FlatAppearance.BorderSize = 0;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnComplete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComplete.Location = new System.Drawing.Point(63, 375);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(112, 30);
            this.btnComplete.TabIndex = 16;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Visible = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // labelRateType
            // 
            this.labelRateType.AutoSize = true;
            this.labelRateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRateType.Location = new System.Drawing.Point(487, 33);
            this.labelRateType.Name = "labelRateType";
            this.labelRateType.Size = new System.Drawing.Size(135, 20);
            this.labelRateType.TabIndex = 24;
            this.labelRateType.Text = "Apply RateType";
            // 
            // radioButtonApplyWeekendRate
            // 
            this.radioButtonApplyWeekendRate.AutoSize = true;
            this.radioButtonApplyWeekendRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonApplyWeekendRate.Location = new System.Drawing.Point(566, 109);
            this.radioButtonApplyWeekendRate.Name = "radioButtonApplyWeekendRate";
            this.radioButtonApplyWeekendRate.Size = new System.Drawing.Size(97, 24);
            this.radioButtonApplyWeekendRate.TabIndex = 23;
            this.radioButtonApplyWeekendRate.TabStop = true;
            this.radioButtonApplyWeekendRate.Text = "WeekEnd";
            this.radioButtonApplyWeekendRate.UseVisualStyleBackColor = true;
            this.radioButtonApplyWeekendRate.CheckedChanged += new System.EventHandler(this.radioButtonApplyWeekendRate_CheckedChanged);
            // 
            // radioButtonApplyWeekdayRate
            // 
            this.radioButtonApplyWeekdayRate.AutoSize = true;
            this.radioButtonApplyWeekdayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonApplyWeekdayRate.Location = new System.Drawing.Point(566, 67);
            this.radioButtonApplyWeekdayRate.Name = "radioButtonApplyWeekdayRate";
            this.radioButtonApplyWeekdayRate.Size = new System.Drawing.Size(96, 24);
            this.radioButtonApplyWeekdayRate.TabIndex = 22;
            this.radioButtonApplyWeekdayRate.TabStop = true;
            this.radioButtonApplyWeekdayRate.Text = "WeekDay";
            this.radioButtonApplyWeekdayRate.UseVisualStyleBackColor = true;
            this.radioButtonApplyWeekdayRate.CheckedChanged += new System.EventHandler(this.radioButtonApplyWeekdayRate_CheckedChanged);
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.labelRateType);
            this.Controls.Add(this.radioButtonApplyWeekendRate);
            this.Controls.Add(this.radioButtonApplyWeekdayRate);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelEntry);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.searchId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ExitForm";
            this.Text = "ExitForm";
            this.Load += new System.EventHandler(this.ExitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown searchId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelEntry;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label labelRateType;
        private System.Windows.Forms.RadioButton radioButtonApplyWeekendRate;
        private System.Windows.Forms.RadioButton radioButtonApplyWeekdayRate;
    }
}