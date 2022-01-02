
namespace CourseWork1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginUserInput = new System.Windows.Forms.TextBox();
            this.LoginPasswordInput = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGuest = new System.Windows.Forms.Button();
            this.PasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEmpLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginUserInput
            // 
            this.LoginUserInput.Location = new System.Drawing.Point(241, 290);
            this.LoginUserInput.Name = "LoginUserInput";
            this.LoginUserInput.Size = new System.Drawing.Size(113, 20);
            this.LoginUserInput.TabIndex = 0;
            // 
            // LoginPasswordInput
            // 
            this.LoginPasswordInput.Location = new System.Drawing.Point(241, 337);
            this.LoginPasswordInput.Name = "LoginPasswordInput";
            this.LoginPasswordInput.Size = new System.Drawing.Size(113, 20);
            this.LoginPasswordInput.TabIndex = 1;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(250, 381);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(80, 26);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(110, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(110, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // BtnGuest
            // 
            this.BtnGuest.Location = new System.Drawing.Point(255, 481);
            this.BtnGuest.Name = "BtnGuest";
            this.BtnGuest.Size = new System.Drawing.Size(75, 23);
            this.BtnGuest.TabIndex = 5;
            this.BtnGuest.Text = "Exit";
            this.BtnGuest.UseVisualStyleBackColor = true;
            this.BtnGuest.Click += new System.EventHandler(this.BtnGuest_Click);
            // 
            // PasswordCheckBox
            // 
            this.PasswordCheckBox.AutoSize = true;
            this.PasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordCheckBox.Location = new System.Drawing.Point(373, 337);
            this.PasswordCheckBox.Name = "PasswordCheckBox";
            this.PasswordCheckBox.Size = new System.Drawing.Size(126, 21);
            this.PasswordCheckBox.TabIndex = 2;
            this.PasswordCheckBox.Text = "Show Password";
            this.PasswordCheckBox.UseVisualStyleBackColor = true;
            this.PasswordCheckBox.CheckedChanged += new System.EventHandler(this.PasswordCheckBox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 248);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnEmpLogin
            // 
            this.btnEmpLogin.Location = new System.Drawing.Point(250, 427);
            this.btnEmpLogin.Name = "btnEmpLogin";
            this.btnEmpLogin.Size = new System.Drawing.Size(80, 23);
            this.btnEmpLogin.TabIndex = 4;
            this.btnEmpLogin.Text = "Employee";
            this.btnEmpLogin.UseVisualStyleBackColor = true;
            this.btnEmpLogin.Click += new System.EventHandler(this.btnEmpLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Not Admin? Login as:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 516);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEmpLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PasswordCheckBox);
            this.Controls.Add(this.BtnGuest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LoginPasswordInput);
            this.Controls.Add(this.LoginUserInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginUserInput;
        private System.Windows.Forms.TextBox LoginPasswordInput;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGuest;
        private System.Windows.Forms.CheckBox PasswordCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEmpLogin;
        private System.Windows.Forms.Label label3;
    }
}