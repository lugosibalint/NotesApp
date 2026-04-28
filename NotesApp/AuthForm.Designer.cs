namespace NotesApp
{
    partial class AuthForm
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
            this.tb_logUsername = new System.Windows.Forms.TextBox();
            this.tb_logPassword = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.tb_regPassword = new System.Windows.Forms.TextBox();
            this.tb_regUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_regName = new System.Windows.Forms.TextBox();
            this.tb_regPassword2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_rem = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_logUsername
            // 
            this.tb_logUsername.Location = new System.Drawing.Point(134, 171);
            this.tb_logUsername.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tb_logUsername.Name = "tb_logUsername";
            this.tb_logUsername.Size = new System.Drawing.Size(292, 34);
            this.tb_logUsername.TabIndex = 0;
            // 
            // tb_logPassword
            // 
            this.tb_logPassword.Location = new System.Drawing.Point(134, 329);
            this.tb_logPassword.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tb_logPassword.Name = "tb_logPassword";
            this.tb_logPassword.PasswordChar = '*';
            this.tb_logPassword.Size = new System.Drawing.Size(292, 34);
            this.tb_logPassword.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(134, 651);
            this.btn_login.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(293, 49);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(941, 428);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(946, 651);
            this.btn_register.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(293, 49);
            this.btn_register.TabIndex = 8;
            this.btn_register.Text = "Registration";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // tb_regPassword
            // 
            this.tb_regPassword.Location = new System.Drawing.Point(946, 463);
            this.tb_regPassword.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tb_regPassword.Name = "tb_regPassword";
            this.tb_regPassword.PasswordChar = '*';
            this.tb_regPassword.Size = new System.Drawing.Size(292, 34);
            this.tb_regPassword.TabIndex = 6;
            // 
            // tb_regUsername
            // 
            this.tb_regUsername.Location = new System.Drawing.Point(946, 308);
            this.tb_regUsername.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tb_regUsername.Name = "tb_regUsername";
            this.tb_regUsername.Size = new System.Drawing.Size(292, 34);
            this.tb_regUsername.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(941, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // tb_regName
            // 
            this.tb_regName.Location = new System.Drawing.Point(946, 148);
            this.tb_regName.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tb_regName.Name = "tb_regName";
            this.tb_regName.Size = new System.Drawing.Size(292, 34);
            this.tb_regName.TabIndex = 4;
            // 
            // tb_regPassword2
            // 
            this.tb_regPassword2.Location = new System.Drawing.Point(946, 519);
            this.tb_regPassword2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tb_regPassword2.Name = "tb_regPassword2";
            this.tb_regPassword2.PasswordChar = '*';
            this.tb_regPassword2.Size = new System.Drawing.Size(292, 34);
            this.tb_regPassword2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(941, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Username";
            // 
            // cb_rem
            // 
            this.cb_rem.AutoSize = true;
            this.cb_rem.Location = new System.Drawing.Point(132, 463);
            this.cb_rem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_rem.Name = "cb_rem";
            this.cb_rem.Size = new System.Drawing.Size(164, 32);
            this.cb_rem.TabIndex = 2;
            this.cb_rem.Text = "Remember me";
            this.cb_rem.UseVisualStyleBackColor = true;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 969);
            this.Controls.Add(this.cb_rem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_regPassword2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_regName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.tb_regPassword);
            this.Controls.Add(this.tb_regUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_logPassword);
            this.Controls.Add(this.tb_logUsername);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "AuthForm";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthForm_FormClosing);
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_logUsername;
        private System.Windows.Forms.TextBox tb_logPassword;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox tb_regPassword;
        private System.Windows.Forms.TextBox tb_regUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_regName;
        private System.Windows.Forms.TextBox tb_regPassword2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_rem;
    }
}

