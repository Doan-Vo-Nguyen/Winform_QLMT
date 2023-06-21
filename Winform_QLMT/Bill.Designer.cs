namespace Winform_QLMT
{
    partial class Bill
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
            grbGeneralI = new GroupBox();
            dtpDateSale = new DateTimePicker();
            cbxUserID = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            txtPhoneNum = new TextBox();
            txtAddress = new TextBox();
            txtUserName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtBillID = new TextBox();
            grbItemInfor = new GroupBox();
            btnDelete = new Button();
            cbxProID = new ComboBox();
            btnClose = new Button();
            btnPrint = new Button();
            btnCancel = new Button();
            btnAdd = new Button();
            txtTotal = new TextBox();
            label14 = new Label();
            dgvBill = new DataGridView();
            txtPrice = new TextBox();
            txtDiscount = new TextBox();
            txtQuantity = new TextBox();
            txtUnit = new TextBox();
            txtProName = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            grbGeneralI.SuspendLayout();
            grbItemInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(466, 4);
            label1.Name = "label1";
            label1.Size = new Size(184, 37);
            label1.TabIndex = 0;
            label1.Text = "Bill Category";
            // 
            // grbGeneralI
            // 
            grbGeneralI.Controls.Add(dtpDateSale);
            grbGeneralI.Controls.Add(cbxUserID);
            grbGeneralI.Controls.Add(label9);
            grbGeneralI.Controls.Add(label8);
            grbGeneralI.Controls.Add(txtPhoneNum);
            grbGeneralI.Controls.Add(txtAddress);
            grbGeneralI.Controls.Add(txtUserName);
            grbGeneralI.Controls.Add(label5);
            grbGeneralI.Controls.Add(label4);
            grbGeneralI.Controls.Add(label3);
            grbGeneralI.Controls.Add(label2);
            grbGeneralI.Controls.Add(txtBillID);
            grbGeneralI.Location = new Point(61, 44);
            grbGeneralI.Name = "grbGeneralI";
            grbGeneralI.Size = new Size(1064, 133);
            grbGeneralI.TabIndex = 1;
            grbGeneralI.TabStop = false;
            grbGeneralI.Text = "General information";
            // 
            // dtpDateSale
            // 
            dtpDateSale.CustomFormat = "YYYY-MM-DD HH:MI:SS";
            dtpDateSale.Location = new Point(109, 80);
            dtpDateSale.Name = "dtpDateSale";
            dtpDateSale.Size = new Size(196, 27);
            dtpDateSale.TabIndex = 13;
            // 
            // cbxUserID
            // 
            cbxUserID.FormattingEnabled = true;
            cbxUserID.Location = new Point(491, 28);
            cbxUserID.Name = "cbxUserID";
            cbxUserID.Size = new Size(196, 28);
            cbxUserID.TabIndex = 12;
            cbxUserID.SelectedIndexChanged += cbxUserID_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(375, 34);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 11;
            label9.Text = "User ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 85);
            label8.Name = "label8";
            label8.Size = new Size(89, 20);
            label8.TabIndex = 8;
            label8.Text = "Date of sale";
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(864, 82);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(185, 27);
            txtPhoneNum.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(864, 31);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(185, 27);
            txtAddress.TabIndex = 6;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(491, 82);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(196, 27);
            txtUserName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(738, 85);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 4;
            label5.Text = "Phone number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(738, 34);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 85);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 31);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Bill ID";
            // 
            // txtBillID
            // 
            txtBillID.Location = new Point(109, 28);
            txtBillID.Name = "txtBillID";
            txtBillID.Size = new Size(196, 27);
            txtBillID.TabIndex = 0;
            // 
            // grbItemInfor
            // 
            grbItemInfor.Controls.Add(btnDelete);
            grbItemInfor.Controls.Add(cbxProID);
            grbItemInfor.Controls.Add(btnClose);
            grbItemInfor.Controls.Add(btnPrint);
            grbItemInfor.Controls.Add(btnCancel);
            grbItemInfor.Controls.Add(btnAdd);
            grbItemInfor.Controls.Add(txtTotal);
            grbItemInfor.Controls.Add(label14);
            grbItemInfor.Controls.Add(dgvBill);
            grbItemInfor.Controls.Add(txtPrice);
            grbItemInfor.Controls.Add(txtDiscount);
            grbItemInfor.Controls.Add(txtQuantity);
            grbItemInfor.Controls.Add(txtUnit);
            grbItemInfor.Controls.Add(txtProName);
            grbItemInfor.Controls.Add(label13);
            grbItemInfor.Controls.Add(label12);
            grbItemInfor.Controls.Add(label11);
            grbItemInfor.Controls.Add(label10);
            grbItemInfor.Controls.Add(label7);
            grbItemInfor.Controls.Add(label6);
            grbItemInfor.Location = new Point(61, 183);
            grbItemInfor.Name = "grbItemInfor";
            grbItemInfor.Size = new Size(1064, 377);
            grbItemInfor.TabIndex = 2;
            grbItemInfor.TabStop = false;
            grbItemInfor.Text = "Item information";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(171, 339);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cbxProID
            // 
            cbxProID.FormattingEnabled = true;
            cbxProID.Location = new Point(105, 36);
            cbxProID.Name = "cbxProID";
            cbxProID.Size = new Size(200, 28);
            cbxProID.TabIndex = 19;
            cbxProID.SelectedIndexChanged += cbxProID_SelectedIndexChanged;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(621, 339);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(474, 339);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 17;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(318, 339);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(25, 339);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(864, 303);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(185, 27);
            txtTotal.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(738, 306);
            label14.Name = "label14";
            label14.Size = new Size(79, 20);
            label14.TabIndex = 13;
            label14.Text = "Total price";
            // 
            // dgvBill
            // 
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBill.Location = new Point(15, 127);
            dgvBill.Name = "dgvBill";
            dgvBill.RowHeadersWidth = 51;
            dgvBill.RowTemplate.Height = 29;
            dgvBill.Size = new Size(1034, 170);
            dgvBill.TabIndex = 12;
            dgvBill.CellContentClick += dgvBill_CellContentClick;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(864, 72);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(185, 27);
            txtPrice.TabIndex = 11;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(491, 76);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(178, 27);
            txtDiscount.TabIndex = 10;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(105, 76);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 27);
            txtQuantity.TabIndex = 9;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(864, 26);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(185, 27);
            txtUnit.TabIndex = 8;
            // 
            // txtProName
            // 
            txtProName.Location = new Point(492, 36);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(177, 27);
            txtProName.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(738, 76);
            label13.Name = "label13";
            label13.Size = new Size(41, 20);
            label13.TabIndex = 5;
            label13.Text = "Price";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(375, 79);
            label12.Name = "label12";
            label12.Size = new Size(67, 20);
            label12.TabIndex = 4;
            label12.Text = "Discount";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 79);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 3;
            label11.Text = "Quantity";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(738, 33);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 2;
            label10.Text = "Unit price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(375, 39);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 1;
            label7.Text = "Product name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 40);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 0;
            label6.Text = "Product ID";
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 572);
            Controls.Add(grbItemInfor);
            Controls.Add(grbGeneralI);
            Controls.Add(label1);
            Name = "Bill";
            Text = "Bill";
            Load += Bill_Load;
            grbGeneralI.ResumeLayout(false);
            grbGeneralI.PerformLayout();
            grbItemInfor.ResumeLayout(false);
            grbItemInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grbGeneralI;
        private Label label2;
        private TextBox txtBillID;
        private GroupBox grbItemInfor;
        private TextBox txtPhoneNum;
        private TextBox txtAddress;
        private TextBox txtUserName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtProName;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button btnClose;
        private Button btnPrint;
        private Button btnCancel;
        private Button btnAdd;
        private TextBox txtTotal;
        private Label label14;
        private DataGridView dgvBill;
        private TextBox txtPrice;
        private TextBox txtDiscount;
        private TextBox txtQuantity;
        private TextBox txtUnit;
        private ComboBox cbxUserID;
        private ComboBox cbxProID;
        private Button btnDelete;
        private DateTimePicker dtpDateSale;
    }
}