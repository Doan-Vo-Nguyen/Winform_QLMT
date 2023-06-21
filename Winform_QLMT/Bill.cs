using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace Winform_QLMT
{
    public partial class Bill : Form
    {
        DataTable dtBill;
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            // this due to the error loading the second combobox while the first combobox is selected and filled data.
            // detach event
            cbxUserID.SelectedIndexChanged -= cbxUserID_SelectedIndexChanged;
            cbxProID.SelectedIndexChanged -= cbxProID_SelectedIndexChanged;
            btnAdd.Enabled = true;
            btnPrint.Enabled = true;
            btnCancel.Enabled = true;
            txtBillID.Enabled = false;
            txtUserName.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtPhoneNum.ReadOnly = true;
            txtProName.ReadOnly = true;
            txtUnit.ReadOnly = true;
            txtPrice.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtDiscount.Text = "0";
            txtTotal.Text = "0";
            DataAccess.fillDataCombo("SELECT * FROM Users", cbxUserID, "user_id", "user_id");
            cbxUserID.SelectedIndex = 0;
            DataAccess.fillDataCombo("SELECT * FROM Products", cbxProID, "prod_id", "prod_id");
            cbxProID.SelectedIndex = 0;

            // attach event
            cbxUserID.SelectedIndexChanged += cbxUserID_SelectedIndexChanged;
            cbxProID.SelectedIndexChanged += cbxProID_SelectedIndexChanged;
            // print bill
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM Bill_details";
            dtBill = DataAccess.getDataToTable(sql);
            dgvBill.DataSource = dtBill;
            dgvBill.Columns[0].HeaderText = "Bill ID";
            dgvBill.Columns[1].HeaderText = "Product ID";
            dgvBill.Columns[2].HeaderText = "User ID";
            dgvBill.Columns[3].HeaderText = "Date sale";
            dgvBill.Columns[4].HeaderText = "Quantity";
            dgvBill.Columns[5].HeaderText = "Discount";
            dgvBill.Columns[6].HeaderText = "Price";
            dgvBill.Columns[7].HeaderText = "Total";
            dgvBill.Columns[0].Width = 100;
            dgvBill.Columns[1].Width = 100;
            dgvBill.Columns[2].Width = 100;
            dgvBill.Columns[3].Width = 100;
            dgvBill.Columns[4].Width = 100;
            dgvBill.Columns[5].Width = 100;
            dgvBill.Columns[6].Width = 100;
            dgvBill.Columns[7].Width = 100;
            dgvBill.AllowUserToAddRows = false;
            dgvBill.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
        // CANCEL
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBillID.Text = "";
            dtpDateSale.Text = DateTime.Now.ToShortDateString();
            cbxUserID.Text = "";
            txtUserName.Text = "";
            txtAddress.Text = "";
            txtPhoneNum.Text = "";
            cbxProID.Text = "";
            txtQuantity.Text = "0";
            txtProName.Text = "";
            txtUnit.Text = "";
            txtPrice.Text = "0";
            txtDiscount.Text = "0";
            txtTotal.Text = "0";
        }

        private void Reset()
        {
            txtBillID.Text = "";
            dtpDateSale.Text = DateTime.Now.ToShortDateString();
            cbxUserID.Text = "";
            cbxProID.Text = "";
            txtPrice.Text = "0";
            txtDiscount.Text = "0";
            txtTotal.Text = "0";
        }
        // ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql, sql_add;
            // Format date time from dd/mm/yyyy to yyyy-mm-dd
            DateTime selectedDateTime = dtpDateSale.Value;
            string formattedDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            if (string.IsNullOrEmpty(dtpDateSale.Text))
            {
                MessageBox.Show("You have not entered the date sale", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpDateSale.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cbxUserID.Text))
            {
                MessageBox.Show("You have not entered the user ID", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxUserID.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cbxProID.Text))
            {
                MessageBox.Show("You have not entered the product ID", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxProID.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("You have not entered the quantity", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantity.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDiscount.Text))
            {
                MessageBox.Show("You have not entered the discount", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiscount.Focus();
                return;
            }
            sql = string.Format("SELECT count(*) from Bill_details WHERE bill_id ='{0}'", txtBillID.Text);
            if (DataAccess.executeScalar(sql) == 1)
            {
                MessageBox.Show("Bill have already exist, plase type another ID", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBillID.Focus();
            }
            else
            {
                sql_add = "INSERT INTO Bill_details VALUES(@prodID, @userID, @datesale, @quantity, @discount, @price, @total)";
                string[] name = { "@prodID", "@userID", "@datesale", "@quantity", "@discount", "@price", "@total" };
                object[] value = { cbxProID.Text, cbxUserID.Text, formattedDateTime, txtQuantity.Text, txtDiscount.Text, txtPrice.Text, txtTotal.Text };
                DataAccess.runSQL(sql_add, name, value);
                MessageBox.Show("Bill added successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
        }
        // DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this?", "ALERT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Delte bill
                string sql = "DELETE Bill_details WHERE bill_id = @id";
                string[] name = { "@id" };
                object[] value = { txtBillID.Text };
                DataAccess.runSQL(sql, name, value);
                MessageBox.Show("Bill deleted successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                LoadDataGridView();
            }
        }
        private void cbxUserID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbxUserID.Text == "")
            {
                txtUserName.Text = "";
                txtAddress.Text = "";
                txtPhoneNum.Text = "";
            }

            // When choose user ID , all field of User information will fill
            str = "SELECT name FROM Users WHERE user_id = " + cbxUserID.SelectedValue.ToString();
            txtUserName.Text = DataAccess.getFieldValues(str);
            str = "SELECT address FROM Users WHERE user_id = " + cbxUserID.SelectedValue.ToString();
            txtAddress.Text = DataAccess.getFieldValues(str);
            str = "SELECT phone_num FROM Users WHERE user_id = " + cbxUserID.SelectedValue.ToString();
            txtPhoneNum.Text = DataAccess.getFieldValues(str);
        }

        private void cbxProID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbxProID.Text == "")
            {
                txtProName.Text = "";
                txtPrice.Text = "";
            }

            // When choose Product ID , all field of Product information will fill
            str = "SELECT prod_name FROM Products WHERE prod_id = " + cbxProID.SelectedValue.ToString();
            txtProName.Text = DataAccess.getFieldValues(str);
            str = "SELECT prod_price FROM Products WHERE prod_id = " + cbxProID.SelectedValue.ToString();
            txtUnit.Text = DataAccess.getFieldValues(str);
        }

        // change the value of total price if quantity change
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            //When quanitity change, update Total
            double sumPrice, sumTotal, num, unitPrice, discount;
            if (txtQuantity.Text == "")
                num = 0;
            else
                num = Convert.ToDouble(txtQuantity.Text);
            if (txtDiscount.Text == "")
                discount = 0;
            else
                discount = Convert.ToDouble(txtDiscount.Text);
            if (txtUnit.Text == "")
                unitPrice = 0;
            else
                unitPrice = Convert.ToDouble(txtUnit.Text);
            sumPrice = num * unitPrice;
            sumTotal = num * unitPrice - ((num * unitPrice) * discount / 100);
            txtPrice.Text = sumPrice.ToString();
            txtTotal.Text = sumTotal.ToString();
        }

        // change the value of total price if discount change
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            //When discount change, update Total
            double sumPrice, sumTotal, num, unitPrice, discount;
            if (txtQuantity.Text == "")
                num = 0;
            else
                num = Convert.ToDouble(txtQuantity.Text);
            if (txtDiscount.Text == "")
                discount = 0;
            else
                discount = Convert.ToDouble(txtDiscount.Text);
            if (txtUnit.Text == "")
                unitPrice = 0;
            else
                unitPrice = Convert.ToDouble(txtUnit.Text);
            sumPrice = num * unitPrice;
            sumTotal = num * unitPrice - ((num * unitPrice) * discount / 100);
            txtPrice.Text = sumPrice.ToString();
            txtTotal.Text = sumTotal.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvBill.CurrentRow.Index;
            txtBillID.Text = dgvBill.Rows[i].Cells[0].Value.ToString();
            cbxProID.Text = dgvBill.Rows[i].Cells[1].Value.ToString();
            cbxUserID.Text = dgvBill.Rows[i].Cells[2].Value.ToString();
            dtpDateSale.Text = dgvBill.Rows[i].Cells[3].Value.ToString();
            txtQuantity.Text = dgvBill.Rows[i].Cells[4].Value.ToString();
            txtDiscount.Text = dgvBill.Rows[i].Cells[5].Value.ToString();
            txtPrice.Text = dgvBill.Rows[i].Cells[6].Value.ToString();
            txtTotal.Text = dgvBill.Rows[i].Cells[7].Value.ToString();

        }
        // Print bill to excel
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Start Excel and get Application object.
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //One excel application can have many workbook
            COMExcel.Worksheet exSheet; // One workbook can have many worksheet
            COMExcel.Range exRange;
            string sql_cus, sql_pro;
            int column = 0, row = 0;
            DataTable dtBillInfor, dtProductInfo;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // General format
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Blue
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "LapTop King"; // name of shop
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Binh Dinh"; // address of shop
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (08)7211086"; // phone number of shop
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Red
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "BILL";
            // Performs the general information of the bill
            sql_cus = "SELECT a.bill_id, a.datesale,a.total_all, b.name, b.address, b.phone_num FROM Bill_details as a, Users as b WHERE a.bill_id = " + txtBillID.Text + " AND a.user_id = b.user_id";
            dtBillInfor = DataAccess.getDataToTable(sql_cus);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Bill ID:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = dtBillInfor.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Customer name:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = dtBillInfor.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Address:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = dtBillInfor.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Phone num:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = dtBillInfor.Rows[0][5].ToString();
            // Get value from Product table
            sql_pro = "SELECT b.prod_name,a.quantity,b.prod_price,a.promotion,a.price FROM Products as b, Bill_details as a WHERE a.bill_id = " + txtBillID.Text + " AND a.prod_id = b.prod_id";
            dtProductInfo = DataAccess.getDataToTable(sql_pro);
            // Create a title line
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "Ordinal number";
            exRange.Range["B11:B11"].Value = "Product name";
            exRange.Range["C11:C11"].Value = "Quantity";
            exRange.Range["D11:D11"].Value = "Price";
            exRange.Range["E11:E11"].Value = "Discount";
            exRange.Range["F11:F11"].Value = "Total";
            for (column = 0; column < dtProductInfo.Rows.Count; column++)
            {
                // Fill STT into column 1, from row 12
                exSheet.Cells[1][column + 12] = column + 1;
                for (row = 0; row < dtProductInfo.Columns.Count; row++)
                // Fill information of each row, from column 2, row 12
                {
                    exSheet.Cells[row + 2][column + 12] = dtProductInfo.Rows[column][row].ToString();
                    if (row == 3) exSheet.Cells[row + 2][column + 12] = dtProductInfo.Rows[column][row].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[row][column + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Total all:";
            exRange = exSheet.Cells[row + 1][column + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = dtBillInfor.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][column + 15]; // A1  
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(dtBillInfor.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Binh Dinh, date " + d.Day + " month " + d.Month + " year " + d.Year;
            exSheet.Name = "Bill in";
            exApp.Visible = true;
        }
    }
}
