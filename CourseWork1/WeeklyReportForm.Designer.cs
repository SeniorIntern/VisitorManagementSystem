namespace CourseWork1
{
    partial class WeeklyReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.WeeklyReportchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DayACountTotal = new System.Windows.Forms.Label();
            this.DayATxnTotal = new System.Windows.Forms.Label();
            this.DayCCountTotal = new System.Windows.Forms.Label();
            this.DayBCountTotal = new System.Windows.Forms.Label();
            this.DayDCountTotal = new System.Windows.Forms.Label();
            this.DayECountTotal = new System.Windows.Forms.Label();
            this.DayFCountTotal = new System.Windows.Forms.Label();
            this.DayGCountTotal = new System.Windows.Forms.Label();
            this.DayGTxnTotal = new System.Windows.Forms.Label();
            this.DayFTxnTotal = new System.Windows.Forms.Label();
            this.DayETxnTotal = new System.Windows.Forms.Label();
            this.DayDTxnTotal = new System.Windows.Forms.Label();
            this.DayBTxnTotal = new System.Windows.Forms.Label();
            this.DayCTxnTotal = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.DayA = new System.Windows.Forms.Label();
            this.DayB = new System.Windows.Forms.Label();
            this.DayC = new System.Windows.Forms.Label();
            this.DayF = new System.Windows.Forms.Label();
            this.DayE = new System.Windows.Forms.Label();
            this.DayD = new System.Windows.Forms.Label();
            this.DayG = new System.Windows.Forms.Label();
            this.radioBtnSortByCount = new System.Windows.Forms.RadioButton();
            this.labelSortOpt = new System.Windows.Forms.Label();
            this.radioBtnSortByEarnings = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyReportchart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(37, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Day";
            // 
            // WeeklyReportchart
            // 
            chartArea1.Name = "ChartArea1";
            this.WeeklyReportchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.WeeklyReportchart.Legends.Add(legend1);
            this.WeeklyReportchart.Location = new System.Drawing.Point(526, 181);
            this.WeeklyReportchart.Name = "WeeklyReportchart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "TotalVisitors";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "TotalEarnings";
            this.WeeklyReportchart.Series.Add(series1);
            this.WeeklyReportchart.Series.Add(series2);
            this.WeeklyReportchart.Size = new System.Drawing.Size(402, 345);
            this.WeeklyReportchart.TabIndex = 1;
            this.WeeklyReportchart.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(105, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Visitors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(225, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Earning";
            // 
            // DayACountTotal
            // 
            this.DayACountTotal.AutoSize = true;
            this.DayACountTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayACountTotal.Location = new System.Drawing.Point(131, 169);
            this.DayACountTotal.Name = "DayACountTotal";
            this.DayACountTotal.Size = new System.Drawing.Size(60, 20);
            this.DayACountTotal.TabIndex = 11;
            this.DayACountTotal.Text = "label11";
            // 
            // DayATxnTotal
            // 
            this.DayATxnTotal.AutoSize = true;
            this.DayATxnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayATxnTotal.Location = new System.Drawing.Point(245, 169);
            this.DayATxnTotal.Name = "DayATxnTotal";
            this.DayATxnTotal.Size = new System.Drawing.Size(60, 20);
            this.DayATxnTotal.TabIndex = 12;
            this.DayATxnTotal.Text = "label12";
            // 
            // DayCCountTotal
            // 
            this.DayCCountTotal.AutoSize = true;
            this.DayCCountTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayCCountTotal.Location = new System.Drawing.Point(131, 251);
            this.DayCCountTotal.Name = "DayCCountTotal";
            this.DayCCountTotal.Size = new System.Drawing.Size(60, 20);
            this.DayCCountTotal.TabIndex = 13;
            this.DayCCountTotal.Text = "label13";
            // 
            // DayBCountTotal
            // 
            this.DayBCountTotal.AutoSize = true;
            this.DayBCountTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayBCountTotal.Location = new System.Drawing.Point(131, 210);
            this.DayBCountTotal.Name = "DayBCountTotal";
            this.DayBCountTotal.Size = new System.Drawing.Size(60, 20);
            this.DayBCountTotal.TabIndex = 13;
            this.DayBCountTotal.Text = "label13";
            // 
            // DayDCountTotal
            // 
            this.DayDCountTotal.AutoSize = true;
            this.DayDCountTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayDCountTotal.Location = new System.Drawing.Point(131, 291);
            this.DayDCountTotal.Name = "DayDCountTotal";
            this.DayDCountTotal.Size = new System.Drawing.Size(60, 20);
            this.DayDCountTotal.TabIndex = 14;
            this.DayDCountTotal.Text = "label13";
            // 
            // DayECountTotal
            // 
            this.DayECountTotal.AutoSize = true;
            this.DayECountTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayECountTotal.Location = new System.Drawing.Point(131, 335);
            this.DayECountTotal.Name = "DayECountTotal";
            this.DayECountTotal.Size = new System.Drawing.Size(60, 20);
            this.DayECountTotal.TabIndex = 15;
            this.DayECountTotal.Text = "label13";
            // 
            // DayFCountTotal
            // 
            this.DayFCountTotal.AutoSize = true;
            this.DayFCountTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayFCountTotal.Location = new System.Drawing.Point(131, 374);
            this.DayFCountTotal.Name = "DayFCountTotal";
            this.DayFCountTotal.Size = new System.Drawing.Size(60, 20);
            this.DayFCountTotal.TabIndex = 16;
            this.DayFCountTotal.Text = "label13";
            // 
            // DayGCountTotal
            // 
            this.DayGCountTotal.AutoSize = true;
            this.DayGCountTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayGCountTotal.Location = new System.Drawing.Point(131, 417);
            this.DayGCountTotal.Name = "DayGCountTotal";
            this.DayGCountTotal.Size = new System.Drawing.Size(60, 20);
            this.DayGCountTotal.TabIndex = 17;
            this.DayGCountTotal.Text = "label13";
            // 
            // DayGTxnTotal
            // 
            this.DayGTxnTotal.AutoSize = true;
            this.DayGTxnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayGTxnTotal.Location = new System.Drawing.Point(245, 417);
            this.DayGTxnTotal.Name = "DayGTxnTotal";
            this.DayGTxnTotal.Size = new System.Drawing.Size(60, 20);
            this.DayGTxnTotal.TabIndex = 23;
            this.DayGTxnTotal.Text = "label13";
            // 
            // DayFTxnTotal
            // 
            this.DayFTxnTotal.AutoSize = true;
            this.DayFTxnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayFTxnTotal.Location = new System.Drawing.Point(245, 374);
            this.DayFTxnTotal.Name = "DayFTxnTotal";
            this.DayFTxnTotal.Size = new System.Drawing.Size(60, 20);
            this.DayFTxnTotal.TabIndex = 22;
            this.DayFTxnTotal.Text = "label13";
            // 
            // DayETxnTotal
            // 
            this.DayETxnTotal.AutoSize = true;
            this.DayETxnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayETxnTotal.Location = new System.Drawing.Point(245, 335);
            this.DayETxnTotal.Name = "DayETxnTotal";
            this.DayETxnTotal.Size = new System.Drawing.Size(60, 20);
            this.DayETxnTotal.TabIndex = 21;
            this.DayETxnTotal.Text = "label13";
            // 
            // DayDTxnTotal
            // 
            this.DayDTxnTotal.AutoSize = true;
            this.DayDTxnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayDTxnTotal.Location = new System.Drawing.Point(245, 291);
            this.DayDTxnTotal.Name = "DayDTxnTotal";
            this.DayDTxnTotal.Size = new System.Drawing.Size(60, 20);
            this.DayDTxnTotal.TabIndex = 20;
            this.DayDTxnTotal.Text = "label13";
            // 
            // DayBTxnTotal
            // 
            this.DayBTxnTotal.AutoSize = true;
            this.DayBTxnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayBTxnTotal.Location = new System.Drawing.Point(245, 210);
            this.DayBTxnTotal.Name = "DayBTxnTotal";
            this.DayBTxnTotal.Size = new System.Drawing.Size(60, 20);
            this.DayBTxnTotal.TabIndex = 18;
            this.DayBTxnTotal.Text = "label13";
            // 
            // DayCTxnTotal
            // 
            this.DayCTxnTotal.AutoSize = true;
            this.DayCTxnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayCTxnTotal.Location = new System.Drawing.Point(245, 251);
            this.DayCTxnTotal.Name = "DayCTxnTotal";
            this.DayCTxnTotal.Size = new System.Drawing.Size(60, 20);
            this.DayCTxnTotal.TabIndex = 19;
            this.DayCTxnTotal.Text = "label24";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(316, 9);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(312, 24);
            this.label25.TabIndex = 24;
            this.label25.Text = "Weekly Report From Last 7 Days";
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(125, 469);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(75, 23);
            this.btnGetReport.TabIndex = 26;
            this.btnGetReport.Text = "Get Report";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // DayA
            // 
            this.DayA.AutoSize = true;
            this.DayA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayA.Location = new System.Drawing.Point(37, 169);
            this.DayA.Name = "DayA";
            this.DayA.Size = new System.Drawing.Size(51, 20);
            this.DayA.TabIndex = 28;
            this.DayA.Text = "label3";
            // 
            // DayB
            // 
            this.DayB.AutoSize = true;
            this.DayB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayB.Location = new System.Drawing.Point(38, 210);
            this.DayB.Name = "DayB";
            this.DayB.Size = new System.Drawing.Size(51, 20);
            this.DayB.TabIndex = 29;
            this.DayB.Text = "label5";
            // 
            // DayC
            // 
            this.DayC.AutoSize = true;
            this.DayC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayC.Location = new System.Drawing.Point(38, 251);
            this.DayC.Name = "DayC";
            this.DayC.Size = new System.Drawing.Size(51, 20);
            this.DayC.TabIndex = 30;
            this.DayC.Text = "label6";
            // 
            // DayF
            // 
            this.DayF.AutoSize = true;
            this.DayF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayF.Location = new System.Drawing.Point(39, 373);
            this.DayF.Name = "DayF";
            this.DayF.Size = new System.Drawing.Size(51, 20);
            this.DayF.TabIndex = 33;
            this.DayF.Text = "label7";
            // 
            // DayE
            // 
            this.DayE.AutoSize = true;
            this.DayE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayE.Location = new System.Drawing.Point(39, 332);
            this.DayE.Name = "DayE";
            this.DayE.Size = new System.Drawing.Size(51, 20);
            this.DayE.TabIndex = 32;
            this.DayE.Text = "label8";
            // 
            // DayD
            // 
            this.DayD.AutoSize = true;
            this.DayD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayD.Location = new System.Drawing.Point(38, 291);
            this.DayD.Name = "DayD";
            this.DayD.Size = new System.Drawing.Size(51, 20);
            this.DayD.TabIndex = 31;
            this.DayD.Text = "label9";
            // 
            // DayG
            // 
            this.DayG.AutoSize = true;
            this.DayG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DayG.Location = new System.Drawing.Point(37, 417);
            this.DayG.Name = "DayG";
            this.DayG.Size = new System.Drawing.Size(60, 20);
            this.DayG.TabIndex = 34;
            this.DayG.Text = "label10";
            // 
            // radioBtnSortByCount
            // 
            this.radioBtnSortByCount.AutoSize = true;
            this.radioBtnSortByCount.Location = new System.Drawing.Point(116, 55);
            this.radioBtnSortByCount.Name = "radioBtnSortByCount";
            this.radioBtnSortByCount.Size = new System.Drawing.Size(53, 17);
            this.radioBtnSortByCount.TabIndex = 35;
            this.radioBtnSortByCount.TabStop = true;
            this.radioBtnSortByCount.Text = "Count";
            this.radioBtnSortByCount.UseVisualStyleBackColor = true;
            this.radioBtnSortByCount.Visible = false;
            this.radioBtnSortByCount.CheckedChanged += new System.EventHandler(this.radioBtnSortByCount_CheckedChanged);
            // 
            // labelSortOpt
            // 
            this.labelSortOpt.AutoSize = true;
            this.labelSortOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSortOpt.Location = new System.Drawing.Point(39, 31);
            this.labelSortOpt.Name = "labelSortOpt";
            this.labelSortOpt.Size = new System.Drawing.Size(65, 20);
            this.labelSortOpt.TabIndex = 36;
            this.labelSortOpt.Text = "Sort By:";
            this.labelSortOpt.Visible = false;
            // 
            // radioBtnSortByEarnings
            // 
            this.radioBtnSortByEarnings.AutoSize = true;
            this.radioBtnSortByEarnings.Location = new System.Drawing.Point(116, 87);
            this.radioBtnSortByEarnings.Name = "radioBtnSortByEarnings";
            this.radioBtnSortByEarnings.Size = new System.Drawing.Size(66, 17);
            this.radioBtnSortByEarnings.TabIndex = 37;
            this.radioBtnSortByEarnings.TabStop = true;
            this.radioBtnSortByEarnings.Text = "Earnings";
            this.radioBtnSortByEarnings.UseVisualStyleBackColor = true;
            this.radioBtnSortByEarnings.Visible = false;
            this.radioBtnSortByEarnings.CheckedChanged += new System.EventHandler(this.radioBtnSortByEarnings_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(367, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(367, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(367, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(367, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(367, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(367, 419);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "label11";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(364, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 45;
            this.label13.Text = "Series Order";
            // 
            // WeeklyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 561);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioBtnSortByEarnings);
            this.Controls.Add(this.labelSortOpt);
            this.Controls.Add(this.radioBtnSortByCount);
            this.Controls.Add(this.DayG);
            this.Controls.Add(this.DayF);
            this.Controls.Add(this.DayE);
            this.Controls.Add(this.DayD);
            this.Controls.Add(this.DayC);
            this.Controls.Add(this.DayB);
            this.Controls.Add(this.DayA);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.DayGTxnTotal);
            this.Controls.Add(this.DayFTxnTotal);
            this.Controls.Add(this.DayETxnTotal);
            this.Controls.Add(this.DayDTxnTotal);
            this.Controls.Add(this.DayBTxnTotal);
            this.Controls.Add(this.DayCTxnTotal);
            this.Controls.Add(this.DayGCountTotal);
            this.Controls.Add(this.DayFCountTotal);
            this.Controls.Add(this.DayECountTotal);
            this.Controls.Add(this.DayDCountTotal);
            this.Controls.Add(this.DayBCountTotal);
            this.Controls.Add(this.DayCCountTotal);
            this.Controls.Add(this.DayATxnTotal);
            this.Controls.Add(this.DayACountTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WeeklyReportchart);
            this.Controls.Add(this.label1);
            this.Name = "WeeklyReportForm";
            this.Text = "WeeklyReportForm";
            this.Load += new System.EventHandler(this.WeeklyReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyReportchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart WeeklyReportchart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DayACountTotal;
        private System.Windows.Forms.Label DayATxnTotal;
        private System.Windows.Forms.Label DayCCountTotal;
        private System.Windows.Forms.Label DayBCountTotal;
        private System.Windows.Forms.Label DayDCountTotal;
        private System.Windows.Forms.Label DayECountTotal;
        private System.Windows.Forms.Label DayFCountTotal;
        private System.Windows.Forms.Label DayGCountTotal;
        private System.Windows.Forms.Label DayGTxnTotal;
        private System.Windows.Forms.Label DayFTxnTotal;
        private System.Windows.Forms.Label DayETxnTotal;
        private System.Windows.Forms.Label DayDTxnTotal;
        private System.Windows.Forms.Label DayBTxnTotal;
        private System.Windows.Forms.Label DayCTxnTotal;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.Label DayA;
        private System.Windows.Forms.Label DayB;
        private System.Windows.Forms.Label DayC;
        private System.Windows.Forms.Label DayF;
        private System.Windows.Forms.Label DayE;
        private System.Windows.Forms.Label DayD;
        private System.Windows.Forms.Label DayG;
        private System.Windows.Forms.RadioButton radioBtnSortByCount;
        private System.Windows.Forms.Label labelSortOpt;
        private System.Windows.Forms.RadioButton radioBtnSortByEarnings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}