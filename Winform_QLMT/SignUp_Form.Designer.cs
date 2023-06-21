namespace Winform_QLMT
{
    partial class SignUp_Form
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
            txtName = new TextBox();
            cbxGender = new ComboBox();
            cbxAddress = new ComboBox();
            txtPhoneNum = new TextBox();
            btnSignUp = new Button();
            label2 = new Label();
            llbLogin = new LinkLabel();
            txtLoginName = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(278, 19);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Control;
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(277, 152);
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 30);
            txtName.TabIndex = 4;
            txtName.Text = "Fullname";
            // 
            // cbxGender
            // 
            cbxGender.BackColor = SystemColors.Control;
            cbxGender.FlatStyle = FlatStyle.Flat;
            cbxGender.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbxGender.ForeColor = Color.Black;
            cbxGender.FormattingEnabled = true;
            cbxGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cbxGender.Location = new Point(277, 198);
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(284, 31);
            cbxGender.TabIndex = 5;
            cbxGender.Text = "Gender";
            // 
            // cbxAddress
            // 
            cbxAddress.BackColor = SystemColors.Control;
            cbxAddress.FlatStyle = FlatStyle.Popup;
            cbxAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbxAddress.ForeColor = Color.Black;
            cbxAddress.FormattingEnabled = true;
            cbxAddress.Items.AddRange(new object[] { "An Giang", "Ba Ria-Vung Tau", "Bac Giang", "Bac Kan", "Bac Lieu", "Bac Ninh", "Ben Tre", "Binh Dinh", "Binh Duong", "Binh Phuoc", "Binh Thuan", "Ca Mau", "Cao Bang", "Dak Lak", "Dak Nong", "Dien Bien", "Dong Nai", "Dong Thap", "Gia Lai", "Ha Giang", "Ha Nam", "Ha Tinh", "Hai Duong", "Hai Phong", "Hanoi (capital)", "Hau Giang", "Hoa Binh", "Hung Yen", "Khanh Hoa", "Kien Giang", "Kon Tum", "Lai Chau", "Lam Dong", "Lang Son", "Lao Cai", "Long An", "Nam Dinh", "Nghe An", "Ninh Binh", "Ninh Thuan", "Phu Tho", "Phu Yen", "Quang Binh", "Quang Nam", "Quang Ngai", "Quang Ninh", "Quang Tri", "Soc Trang", "Son La", "Tay Ninh", "Thai Binh", "Thai Nguyen", "Thanh Hoa", "Thua Thien-Hue", "Tien Giang", "Tra Vinh", "Tuyen Quang", "Vinh Long", "Vinh Phuc", "Yen Bai", "Can Tho (city)", "Da Nang (city)", "TP.HCM(city)" });
            cbxAddress.Location = new Point(278, 244);
            cbxAddress.Name = "cbxAddress";
            cbxAddress.Size = new Size(283, 31);
            cbxAddress.TabIndex = 6;
            cbxAddress.Text = "Address";
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.BackColor = SystemColors.Control;
            txtPhoneNum.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNum.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNum.ForeColor = Color.Black;
            txtPhoneNum.Location = new Point(278, 290);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(283, 30);
            txtPhoneNum.TabIndex = 7;
            txtPhoneNum.Text = "Phone number";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(3, 123, 238);
            btnSignUp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignUp.ForeColor = Color.Black;
            btnSignUp.Location = new Point(278, 381);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(283, 37);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(103, 120, 128);
            label2.Location = new Point(318, 421);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 9;
            label2.Text = "Have an account";
            // 
            // llbLogin
            // 
            llbLogin.AutoSize = true;
            llbLogin.LinkColor = Color.Blue;
            llbLogin.Location = new Point(443, 421);
            llbLogin.Name = "llbLogin";
            llbLogin.Size = new Size(46, 20);
            llbLogin.TabIndex = 10;
            llbLogin.TabStop = true;
            llbLogin.Text = "Login";
            llbLogin.LinkClicked += llbLogin_LinkClicked;
            // 
            // txtLoginName
            // 
            txtLoginName.BackColor = SystemColors.Control;
            txtLoginName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoginName.ForeColor = Color.Black;
            txtLoginName.Location = new Point(278, 65);
            txtLoginName.Name = "txtLoginName";
            txtLoginName.Size = new Size(283, 30);
            txtLoginName.TabIndex = 11;
            txtLoginName.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(277, 108);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(283, 27);
            txtPassword.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Control;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(278, 335);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(283, 30);
            txtEmail.TabIndex = 13;
            txtEmail.Text = "Email";
            // 
            // SignUp_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtLoginName);
            Controls.Add(llbLogin);
            Controls.Add(label2);
            Controls.Add(btnSignUp);
            Controls.Add(txtPhoneNum);
            Controls.Add(cbxAddress);
            Controls.Add(cbxGender);
            Controls.Add(txtName);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(50, 50, 50);
            Name = "SignUp_Form";
            Text = "SignUp";
            Load += SignUp_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private ComboBox cbxGender;
        private ComboBox cbxAddress;
        private TextBox txtPhoneNum;
        private Button btnSignUp;
        private Label label2;
        private LinkLabel llbLogin;
        private TextBox txtLoginName;
        private TextBox txtPassword;
        private TextBox txtEmail;
    }
}