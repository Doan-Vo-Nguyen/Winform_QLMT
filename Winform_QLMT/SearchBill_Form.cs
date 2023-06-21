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
    public partial class SearchBill_Form : Form
    {
        DataTable dtSearchBill;
        public SearchBill_Form()
        {
            InitializeComponent();
        }

        private void SearchBill_Form_Load(object sender, EventArgs e)
        {
            Reset();
            dgvSearchBill.DataSource = null;
        }

        private void Reset()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
            txtBillID.Focus();
        }

        private void LoadDataGridView()
        {
            dgvSearchBill.Columns[0].HeaderText = "Bill ID";
            dgvSearchBill.Columns[1].HeaderText = "Product ID";
            dgvSearchBill.Columns[2].HeaderText = "User ID";
            dgvSearchBill.Columns[3].HeaderText = "Date sale";
            dgvSearchBill.Columns[4].HeaderText = "Quantity";
            dgvSearchBill.Columns[5].HeaderText = "Discount";
            dgvSearchBill.Columns[6].HeaderText = "Price";
            dgvSearchBill.Columns[7].HeaderText = "Total";
            dgvSearchBill.Columns[0].Width = 100;
            dgvSearchBill.Columns[1].Width = 100;
            dgvSearchBill.Columns[2].Width = 100;
            dgvSearchBill.Columns[3].Width = 100;
            dgvSearchBill.Columns[4].Width = 100;
            dgvSearchBill.Columns[5].Width = 100;
            dgvSearchBill.Columns[6].Width = 100;
            dgvSearchBill.Columns[7].Width = 100;
            dgvSearchBill.AllowUserToAddRows = false;
            dgvSearchBill.EditMode = DataGridViewEditMode.EditProgrammatically;

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtBillID.Text == "") && (txtMonth.Text == "") && (txtYear.Text == "") && (txtUserID.Text == "") && (txtTotal.Text == ""))
            {
                MessageBox.Show("Please type a condition for searching", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM Bill_details WHERE 1=1";
            if (txtBillID.Text != "")
            {
                sql = sql + " AND bill_id LIKE " + txtBillID.Text;
            }
            if (txtMonth.Text != "")
            {
                sql = sql + "AND MONTH(datesale) = " + txtMonth.Text;
            }

            if (txtYear.Text != "")
            {
                sql = sql + "AND YEAR(datesale) = " + txtYear.Text;
            }
            if (txtUserID.Text != "")
            {
                sql = sql + "AND user_id LIKE '" + txtUserID.Text + "'";
            }

            if (txtTotal.Text != "")
            {
                sql = sql + "AND total_all <= " + txtTotal.Text;
            }
            dtSearchBill = DataAccess.getDataToTable(sql);
            if (dtSearchBill.Rows.Count == 0)
            {
                MessageBox.Show("There are no data available", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("There are " + dtSearchBill.Rows.Count + "records that satisfy the condition", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvSearchBill.DataSource = dtSearchBill;
            LoadDataGridView();
        }

        private void btnReseach_Click(object sender, EventArgs e)
        {
            Reset();
            dgvSearchBill.DataSource = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void dgvSearchBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvSearchBill.CurrentRow.Index;
            txtBillID.Text = dgvSearchBill.Rows[i].Cells[0].Value.ToString();

        }
    }
}
