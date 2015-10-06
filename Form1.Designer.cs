namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Enter1 = new System.Windows.Forms.Button();
            this.fname = new System.Windows.Forms.TextBox();
            this.pass1 = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Logged = new System.Windows.Forms.Panel();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.UsernameLog = new System.Windows.Forms.TextBox();
            this.PasswordLog = new System.Windows.Forms.TextBox();
            this.LoginBtnL = new System.Windows.Forms.Button();
            this.Logged.SuspendLayout();
            this.Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enter1
            // 
            this.Enter1.Location = new System.Drawing.Point(261, 318);
            this.Enter1.Name = "Enter1";
            this.Enter1.Size = new System.Drawing.Size(95, 28);
            this.Enter1.TabIndex = 0;
            this.Enter1.Text = "Enter";
            this.Enter1.UseVisualStyleBackColor = true;
            this.Enter1.Click += new System.EventHandler(this.Enter_Click);
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(75, 63);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(234, 20);
            this.fname.TabIndex = 1;
            // 
            // pass1
            // 
            this.pass1.Location = new System.Drawing.Point(75, 141);
            this.pass1.Name = "pass1";
            this.pass1.Size = new System.Drawing.Size(234, 20);
            this.pass1.TabIndex = 2;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(75, 115);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(234, 20);
            this.username.TabIndex = 3;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(75, 89);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(234, 20);
            this.lname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(75, 167);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(234, 20);
            this.pass2.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Signup";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(12, 318);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(56, 28);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(120, 318);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(95, 28);
            this.LoginBtn.TabIndex = 13;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Confirm:";
            // 
            // Logged
            // 
            this.Logged.BackColor = System.Drawing.Color.IndianRed;
            this.Logged.Controls.Add(this.Login);
            this.Logged.Controls.Add(this.LogOutBtn);
            this.Logged.Controls.Add(this.label7);
            this.Logged.Location = new System.Drawing.Point(2, 1);
            this.Logged.Name = "Logged";
            this.Logged.Size = new System.Drawing.Size(364, 357);
            this.Logged.TabIndex = 15;
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(278, 321);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogOutBtn.TabIndex = 1;
            this.LogOutBtn.Text = "Logout";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "Success!";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.LightGray;
            this.Login.Controls.Add(this.LoginBtnL);
            this.Login.Controls.Add(this.PasswordLog);
            this.Login.Controls.Add(this.UsernameLog);
            this.Login.Controls.Add(this.label10);
            this.Login.Controls.Add(this.label9);
            this.Login.Controls.Add(this.label8);
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(364, 357);
            this.Login.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(129, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 33);
            this.label8.TabIndex = 0;
            this.label8.Text = "Login:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Username:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Password:";
            // 
            // UsernameLog
            // 
            this.UsernameLog.Location = new System.Drawing.Point(73, 86);
            this.UsernameLog.Name = "UsernameLog";
            this.UsernameLog.Size = new System.Drawing.Size(211, 20);
            this.UsernameLog.TabIndex = 3;
            // 
            // PasswordLog
            // 
            this.PasswordLog.Location = new System.Drawing.Point(73, 118);
            this.PasswordLog.Name = "PasswordLog";
            this.PasswordLog.Size = new System.Drawing.Size(211, 20);
            this.PasswordLog.TabIndex = 4;
            // 
            // LoginBtnL
            // 
            this.LoginBtnL.Location = new System.Drawing.Point(278, 317);
            this.LoginBtnL.Name = "LoginBtnL";
            this.LoginBtnL.Size = new System.Drawing.Size(75, 23);
            this.LoginBtnL.TabIndex = 5;
            this.LoginBtnL.Text = "Login";
            this.LoginBtnL.UseVisualStyleBackColor = true;
            this.LoginBtnL.Click += new System.EventHandler(this.LoginBtnL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(368, 358);
            this.Controls.Add(this.Logged);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.Enter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(384, 396);
            this.MinimumSize = new System.Drawing.Size(384, 396);
            this.Name = "Form1";
            this.Text = "Conor\'s App";
            this.Logged.ResumeLayout(false);
            this.Logged.PerformLayout();
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter1;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox pass1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Logged;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Login;
        private System.Windows.Forms.TextBox PasswordLog;
        private System.Windows.Forms.TextBox UsernameLog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button LoginBtnL;
    }
}

