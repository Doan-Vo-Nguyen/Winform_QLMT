namespace Winform_QLMT
{
    partial class Login_Form
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
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lkbSignUp = new LinkLabel();
            btnLogin = new Button();
            label2 = new Label();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(267, 59);
            label1.Name = "label1";
            label1.Size = new Size(71, 31);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI Historic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(267, 123);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(326, 37);
            txtUsername.TabIndex = 1;
            txtUsername.Text = "Username\r\n\r\n";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI Historic", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(267, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(326, 37);
            txtPassword.TabIndex = 2;
            // 
            // lkbSignUp
            // 
            lkbSignUp.AutoSize = true;
            lkbSignUp.ForeColor = Color.White;
            lkbSignUp.LinkColor = Color.Blue;
            lkbSignUp.Location = new Point(478, 419);
            lkbSignUp.Name = "lkbSignUp";
            lkbSignUp.Size = new Size(61, 20);
            lkbSignUp.TabIndex = 5;
            lkbSignUp.TabStop = true;
            lkbSignUp.Text = "Sign Up";
            lkbSignUp.LinkClicked += lkbSignUp_LinkClicked;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(3, 123, 238);
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(267, 277);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(152, 42);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN NOW";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(103, 120, 128);
            label2.Location = new Point(316, 419);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 7;
            label2.Text = "Don't have an account";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(3, 123, 238);
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(442, 277);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(151, 42);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "EXIT";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(lkbSignUp);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "Login_Form";
            Text = "Login";
            Load += Login_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private LinkLabel lkbSignUp;
        private Button btnLogin;
        private Label label2;
        private Button btnThoat;
    }
}