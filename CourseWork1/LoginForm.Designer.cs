
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
            this.LoginUserInput = new System.Windows.Forms.TextBox();
            this.LoginPasswordInput = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnGuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginUserInput
            // 
            this.LoginUserInput.Location = new System.Drawing.Point(308, 148);
            this.LoginUserInput.Name = "LoginUserInput";
            this.LoginUserInput.Size = new System.Drawing.Size(113, 20);
            this.LoginUserInput.TabIndex = 0;
            // 
            // LoginPasswordInput
            // 
            this.LoginPasswordInput.Location = new System.Drawing.Point(308, 222);
            this.LoginPasswordInput.Name = "LoginPasswordInput";
            this.LoginPasswordInput.Size = new System.Drawing.Size(113, 20);
            this.LoginPasswordInput.TabIndex = 1;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(322, 316);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(318, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(318, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Location = new System.Drawing.Point(256, 271);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(244, 13);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = "Please Enter Correct Username/Password";
            this.labelMessage.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Don\'t have and account? Login As";
            // 
            // BtnGuest
            // 
            this.BtnGuest.Location = new System.Drawing.Point(466, 389);
            this.BtnGuest.Name = "BtnGuest";
            this.BtnGuest.Size = new System.Drawing.Size(75, 23);
            this.BtnGuest.TabIndex = 3;
            this.BtnGuest.Text = "Guest";
            this.BtnGuest.UseVisualStyleBackColor = true;
            this.BtnGuest.Click += new System.EventHandler(this.BtnGuest_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BtnGuest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LoginPasswordInput);
            this.Controls.Add(this.LoginUserInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginUserInput;
        private System.Windows.Forms.TextBox LoginPasswordInput;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnGuest;
    }
}