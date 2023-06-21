namespace Winform_QLMT
{
    partial class Product_Form
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
            txtLaptopID = new TextBox();
            txtLapTopName = new TextBox();
            dvgLapTop = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            label4 = new Label();
            label5 = new Label();
            cbxBrand = new ComboBox();
            txtPrice = new TextBox();
            label6 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgLapTop).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(404, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 37);
            label1.TabIndex = 0;
            label1.Text = "Laptop Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 87);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Laptop ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 147);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Laptop Name";
            // 
            // txtLaptopID
            // 
            txtLaptopID.Location = new Point(179, 84);
            txtLaptopID.Name = "txtLaptopID";
            txtLaptopID.Size = new Size(236, 27);
            txtLaptopID.TabIndex = 3;
            // 
            // txtLapTopName
            // 
            txtLapTopName.Location = new Point(179, 144);
            txtLapTopName.Name = "txtLapTopName";
            txtLapTopName.Size = new Size(236, 27);
            txtLapTopName.TabIndex = 4;
            // 
            // dvgLapTop
            // 
            dvgLapTop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgLapTop.Location = new Point(24, 202);
            dvgLapTop.Name = "dvgLapTop";
            dvgLapTop.RowHeadersWidth = 51;
            dvgLapTop.RowTemplate.Height = 29;
            dvgLapTop.Size = new Size(1102, 213);
            dvgLapTop.TabIndex = 5;
            dvgLapTop.CellContentClick += dvgLapTop_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(24, 527);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(213, 527);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(404, 527);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(593, 527);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1032, 527);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(656, 90);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 11;
            label4.Text = "Brand";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(656, 147);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 12;
            label5.Text = "Price";
            // 
            // cbxBrand
            // 
            cbxBrand.FormattingEnabled = true;
            cbxBrand.Items.AddRange(new object[] { "Acer", "Apple", "Asus", "Dell", "HP (Hewlett-Packard)", "Lenovo", "Microsoft", "MSI (Micro-Star International)", "Razer", "Samsung", "Sony", "Toshiba", "LG", "Fujitsu", "Panasonic", "Huawei", "Xiaomi", "Google (Pixelbook)", "Alienware (owned by Dell)", "IBM (Lenovo acquired IBM's PC division)" });
            cbxBrand.Location = new Point(734, 87);
            cbxBrand.Name = "cbxBrand";
            cbxBrand.Size = new Size(195, 28);
            cbxBrand.TabIndex = 13;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(734, 144);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(195, 27);
            txtPrice.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 451);
            label6.Name = "label6";
            label6.Size = new Size(150, 20);
            label6.TabIndex = 15;
            label6.Text = "Search product name";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(182, 451);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(233, 27);
            txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(435, 451);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Product_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 568);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label6);
            Controls.Add(txtPrice);
            Controls.Add(cbxBrand);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dvgLapTop);
            Controls.Add(txtLapTopName);
            Controls.Add(txtLaptopID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Product_Form";
            Text = "Product";
            Load += Product_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dvgLapTop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtLaptopID;
        private TextBox txtLapTopName;
        private DataGridView dvgLapTop;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCancel;
        private Button btnExit;
        private Label label4;
        private Label label5;
        private ComboBox cbxBrand;
        private TextBox txtPrice;
        private Label label6;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}