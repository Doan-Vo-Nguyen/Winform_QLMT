namespace Winform_QLMT
{
    partial class User_Form
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtUserID = new TextBox();
            txtUserName = new TextBox();
            txtPhoneNum = new TextBox();
            cbxGender = new ComboBox();
            cbxAddress = new ComboBox();
            dgvUser = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            label7 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(431, 9);
            label1.Name = "label1";
            label1.Size = new Size(201, 37);
            label1.TabIndex = 0;
            label1.Text = "User Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 56);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "User ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 104);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 146);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(643, 56);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(643, 104);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 5;
            label6.Text = "Phone number";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(132, 53);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(216, 27);
            txtUserID.TabIndex = 6;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(132, 101);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(216, 27);
            txtUserName.TabIndex = 7;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(796, 104);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(208, 27);
            txtPhoneNum.TabIndex = 8;
            // 
            // cbxGender
            // 
            cbxGender.FormattingEnabled = true;
            cbxGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            cbxGender.Location = new Point(133, 146);
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(215, 28);
            cbxGender.TabIndex = 9;
            // 
            // cbxAddress
            // 
            cbxAddress.FormattingEnabled = true;
            cbxAddress.Items.AddRange(new object[] { "An Giang", "Ba Ria-Vung Tau", "Bac Giang", "Bac Kan", "Bac Lieu", "Bac Ninh", "Ben Tre", "Binh Dinh", "Binh Duong", "Binh Phuoc", "Binh Thuan", "Ca Mau", "Cao Bang", "Dak Lak", "Dak Nong", "Dien Bien", "Dong Nai", "Dong Thap", "Gia Lai", "Ha Giang", "Ha Nam", "Ha Tinh", "Hai Duong", "Hai Phong", "Hanoi (capital)", "Hau Giang", "Hoa Binh", "Hung Yen", "Khanh Hoa", "Kien Giang", "Kon Tum", "Lai Chau", "Lam Dong", "Lang Son", "Lao Cai", "Long An", "Nam Dinh", "Nghe An", "Ninh Binh", "Ninh Thuan", "Phu Tho", "Phu Yen", "Quang Binh", "Quang Nam", "Quang Ngai", "Quang Ninh", "Quang Tri", "Soc Trang", "Son La", "Tay Ninh", "Thai Binh", "Thai Nguyen", "Thanh Hoa", "Thua Thien-Hue", "Tien Giang", "Tra Vinh", "Tuyen Quang", "Vinh Long", "Vinh Phuc", "Yen Bai", "Can Tho (city)", "Da Nang (city)", "TP.HCM(city)" });
            cbxAddress.Location = new Point(796, 48);
            cbxAddress.Name = "cbxAddress";
            cbxAddress.Size = new Size(208, 28);
            cbxAddress.TabIndex = 10;
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(22, 206);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 51;
            dgvUser.RowTemplate.Height = 29;
            dgvUser.Size = new Size(1083, 216);
            dgvUser.TabIndex = 11;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(22, 530);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(205, 530);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(386, 530);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(580, 530);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1011, 530);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 16;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 455);
            label7.Name = "label7";
            label7.Size = new Size(123, 20);
            label7.TabIndex = 17;
            label7.Text = "Search Username";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(151, 452);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(215, 27);
            txtSearch.TabIndex = 18;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(375, 452);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // User_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 571);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label7);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvUser);
            Controls.Add(cbxAddress);
            Controls.Add(cbxGender);
            Controls.Add(txtPhoneNum);
            Controls.Add(txtUserName);
            Controls.Add(txtUserID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "User_Form";
            StartPosition = FormStartPosition.CenterParent;
            Text = "User";
            Load += User_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtUserID;
        private TextBox txtUserName;
        private TextBox txtPhoneNum;
        private ComboBox cbxGender;
        private ComboBox cbxAddress;
        private DataGridView dgvUser;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCancel;
        private Button btnExit;
        private Label label7;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}