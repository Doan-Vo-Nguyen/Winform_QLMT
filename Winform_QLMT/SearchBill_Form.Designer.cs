namespace Winform_QLMT
{
    partial class SearchBill_Form
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
            txtBillID = new TextBox();
            txtMonth = new TextBox();
            txtUserID = new TextBox();
            txtYear = new TextBox();
            txtTotal = new TextBox();
            dgvSearchBill = new DataGridView();
            btnSearch = new Button();
            btnReseach = new Button();
            btnClose = new Button();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSearchBill).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(400, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 37);
            label1.TabIndex = 0;
            label1.Text = "Search Bill Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 62);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Bill ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 100);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Month";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 100);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 3;
            label4.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 141);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "User ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(777, 66);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 5;
            label6.Text = "Total";
            // 
            // txtBillID
            // 
            txtBillID.Location = new Point(97, 59);
            txtBillID.Name = "txtBillID";
            txtBillID.Size = new Size(247, 27);
            txtBillID.TabIndex = 6;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(97, 97);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(89, 27);
            txtMonth.TabIndex = 7;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(97, 141);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(247, 27);
            txtUserID.TabIndex = 8;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(257, 97);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(87, 27);
            txtYear.TabIndex = 9;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(842, 62);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(220, 27);
            txtTotal.TabIndex = 10;
            // 
            // dgvSearchBill
            // 
            dgvSearchBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchBill.Location = new Point(25, 182);
            dgvSearchBill.Name = "dgvSearchBill";
            dgvSearchBill.RowHeadersWidth = 51;
            dgvSearchBill.RowTemplate.Height = 29;
            dgvSearchBill.Size = new Size(1077, 319);
            dgvSearchBill.TabIndex = 11;
            dgvSearchBill.CellContentClick += dgvSearchBill_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(157, 531);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReseach
            // 
            btnReseach.Location = new Point(381, 531);
            btnReseach.Name = "btnReseach";
            btnReseach.Size = new Size(94, 29);
            btnReseach.TabIndex = 13;
            btnReseach.Text = "Research";
            btnReseach.UseVisualStyleBackColor = true;
            btnReseach.Click += btnReseach_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(842, 531);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(623, 531);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 15;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // SearchBill_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 572);
            Controls.Add(btnPrint);
            Controls.Add(btnClose);
            Controls.Add(btnReseach);
            Controls.Add(btnSearch);
            Controls.Add(dgvSearchBill);
            Controls.Add(txtTotal);
            Controls.Add(txtYear);
            Controls.Add(txtUserID);
            Controls.Add(txtMonth);
            Controls.Add(txtBillID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SearchBill_Form";
            Text = "Search Bill";
            Load += SearchBill_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSearchBill).EndInit();
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
        private TextBox txtBillID;
        private TextBox txtMonth;
        private TextBox txtUserID;
        private TextBox txtYear;
        private TextBox txtTotal;
        private DataGridView dgvSearchBill;
        private Button btnSearch;
        private Button btnReseach;
        private Button btnClose;
        private Button btnPrint;
    }
}