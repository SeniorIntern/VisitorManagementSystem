
namespace CourseWork1
{
    partial class EntryForm
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
            this.BtnAddStudent = new System.Windows.Forms.Button();
            this.VisitorType = new System.Windows.Forms.ComboBox();
            this.VisitorCount = new System.Windows.Forms.NumericUpDown();
            this.VisitorId = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VisitorsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddStudent
            // 
            this.BtnAddStudent.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAddStudent.Location = new System.Drawing.Point(83, 237);
            this.BtnAddStudent.Name = "BtnAddStudent";
            this.BtnAddStudent.Size = new System.Drawing.Size(87, 27);
            this.BtnAddStudent.TabIndex = 15;
            this.BtnAddStudent.Text = "Add";
            this.BtnAddStudent.UseVisualStyleBackColor = true;
            this.BtnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click_1);
            // 
            // VisitorType
            // 
            this.VisitorType.FormattingEnabled = true;
            this.VisitorType.Items.AddRange(new object[] {
            "Adult",
            "Child",
            "Group"});
            this.VisitorType.Location = new System.Drawing.Point(135, 101);
            this.VisitorType.Name = "VisitorType";
            this.VisitorType.Size = new System.Drawing.Size(87, 21);
            this.VisitorType.TabIndex = 14;
            // 
            // VisitorCount
            // 
            this.VisitorCount.Location = new System.Drawing.Point(135, 157);
            this.VisitorCount.Name = "VisitorCount";
            this.VisitorCount.Size = new System.Drawing.Size(87, 20);
            this.VisitorCount.TabIndex = 13;
            // 
            // VisitorId
            // 
            this.VisitorId.Location = new System.Drawing.Point(135, 47);
            this.VisitorId.Name = "VisitorId";
            this.VisitorId.Size = new System.Drawing.Size(87, 20);
            this.VisitorId.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            // 
            // VisitorsGridView
            // 
            this.VisitorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitorsGridView.Location = new System.Drawing.Point(297, 47);
            this.VisitorsGridView.Name = "VisitorsGridView";
            this.VisitorsGridView.Size = new System.Drawing.Size(443, 348);
            this.VisitorsGridView.TabIndex = 16;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.VisitorsGridView);
            this.Controls.Add(this.BtnAddStudent);
            this.Controls.Add(this.VisitorType);
            this.Controls.Add(this.VisitorCount);
            this.Controls.Add(this.VisitorId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntryForm";
            this.Text = "EntryForm";
            this.Load += new System.EventHandler(this.EntryForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.VisitorCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAddStudent;
        private System.Windows.Forms.ComboBox VisitorType;
        private System.Windows.Forms.NumericUpDown VisitorCount;
        private System.Windows.Forms.NumericUpDown VisitorId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView VisitorsGridView;
    }
}