
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TktGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.VisitorId = new System.Windows.Forms.Label();
            this.EntryGridView = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButtonWeekEnd = new System.Windows.Forms.RadioButton();
            this.radioButtonWeekDay = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TktGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddStudent
            // 
            this.BtnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAddStudent.Location = new System.Drawing.Point(25, 218);
            this.BtnAddStudent.Name = "BtnAddStudent";
            this.BtnAddStudent.Size = new System.Drawing.Size(87, 27);
            this.BtnAddStudent.TabIndex = 3;
            this.BtnAddStudent.Text = "Add";
            this.BtnAddStudent.UseVisualStyleBackColor = true;
            this.BtnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // VisitorType
            // 
            this.VisitorType.FormattingEnabled = true;
            this.VisitorType.Items.AddRange(new object[] {
            "Adult",
            "Child",
            "Group"});
            this.VisitorType.Location = new System.Drawing.Point(115, 102);
            this.VisitorType.Name = "VisitorType";
            this.VisitorType.Size = new System.Drawing.Size(87, 21);
            this.VisitorType.TabIndex = 1;
            // 
            // VisitorCount
            // 
            this.VisitorCount.Location = new System.Drawing.Point(115, 158);
            this.VisitorCount.Name = "VisitorCount";
            this.VisitorCount.Size = new System.Drawing.Size(87, 20);
            this.VisitorCount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(36, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(36, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            // 
            // TktGridView
            // 
            this.TktGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TktGridView.Location = new System.Drawing.Point(314, 269);
            this.TktGridView.Name = "TktGridView";
            this.TktGridView.Size = new System.Drawing.Size(545, 235);
            this.TktGridView.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(137, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // VisitorId
            // 
            this.VisitorId.AutoSize = true;
            this.VisitorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitorId.Location = new System.Drawing.Point(111, 47);
            this.VisitorId.Name = "VisitorId";
            this.VisitorId.Size = new System.Drawing.Size(51, 20);
            this.VisitorId.TabIndex = 22;
            this.VisitorId.Text = "label5";
            // 
            // EntryGridView
            // 
            this.EntryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EntryGridView.Location = new System.Drawing.Point(314, 22);
            this.EntryGridView.Name = "EntryGridView";
            this.EntryGridView.Size = new System.Drawing.Size(545, 223);
            this.EntryGridView.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Show Rates";
            // 
            // radioButtonWeekEnd
            // 
            this.radioButtonWeekEnd.AutoSize = true;
            this.radioButtonWeekEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonWeekEnd.Location = new System.Drawing.Point(104, 367);
            this.radioButtonWeekEnd.Name = "radioButtonWeekEnd";
            this.radioButtonWeekEnd.Size = new System.Drawing.Size(97, 24);
            this.radioButtonWeekEnd.TabIndex = 26;
            this.radioButtonWeekEnd.TabStop = true;
            this.radioButtonWeekEnd.Text = "WeekEnd";
            this.radioButtonWeekEnd.UseVisualStyleBackColor = true;
            this.radioButtonWeekEnd.CheckedChanged += new System.EventHandler(this.radioButtonWeekEnd_CheckedChanged);
            // 
            // radioButtonWeekDay
            // 
            this.radioButtonWeekDay.AutoSize = true;
            this.radioButtonWeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWeekDay.Location = new System.Drawing.Point(105, 325);
            this.radioButtonWeekDay.Name = "radioButtonWeekDay";
            this.radioButtonWeekDay.Size = new System.Drawing.Size(96, 24);
            this.radioButtonWeekDay.TabIndex = 25;
            this.radioButtonWeekDay.TabStop = true;
            this.radioButtonWeekDay.Text = "WeekDay";
            this.radioButtonWeekDay.UseVisualStyleBackColor = true;
            this.radioButtonWeekDay.CheckedChanged += new System.EventHandler(this.radioButtonWeekDay_CheckedChanged);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radioButtonWeekEnd);
            this.Controls.Add(this.radioButtonWeekDay);
            this.Controls.Add(this.EntryGridView);
            this.Controls.Add(this.VisitorId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TktGridView);
            this.Controls.Add(this.BtnAddStudent);
            this.Controls.Add(this.VisitorType);
            this.Controls.Add(this.VisitorCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EntryForm";
            this.Text = "EntryForm";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisitorCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TktGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAddStudent;
        private System.Windows.Forms.ComboBox VisitorType;
        private System.Windows.Forms.NumericUpDown VisitorCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TktGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label VisitorId;
        private System.Windows.Forms.DataGridView EntryGridView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButtonWeekEnd;
        private System.Windows.Forms.RadioButton radioButtonWeekDay;
    }
}