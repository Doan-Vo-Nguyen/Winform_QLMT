using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_QLMT
{
    public partial class Product_Form : Form
    {
        DataTable dtProduct; // store data of table Products
        public Product_Form()
        {
            InitializeComponent();
        }
        // PRODUCT_FORM LOAD FUNCTION
        private void Product_Form_Load(object sender, EventArgs e)
        {
            txtLaptopID.Enabled = false;
            btnCancel.Enabled = true;
            loadDataGridView(); // show the data of tabel Products
        }
        // LOAD DATA FUNCTION
        private void loadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM Products";
            dtProduct = DataAccess.getDataToTable(sql); // read data from the table Product
            dvgLapTop.DataSource = dtProduct; // source
            dvgLapTop.Columns[0].HeaderText = "LapTop ID";
            dvgLapTop.Columns[1].HeaderText = "LapTop Name";
            dvgLapTop.Columns[2].HeaderText = "LapTop Brand";
            dvgLapTop.Columns[3].HeaderText = "Price";
            dvgLapTop.Columns[0].Width = 100;
            dvgLapTop.Columns[1].Width = 300;
            dvgLapTop.Columns[2].Width = 300;
            dvgLapTop.Columns[3].Width = 100;
            // Not allow user add data directly
            dvgLapTop.AllowUserToAddRows = false;
            // Not allow user update data directly
            dvgLapTop.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        // LOAD DATA WHEN SEARCHING
        private void loadDataGridViewSearch()
        {
            dvgLapTop.DataSource = dtProduct; // source
            dvgLapTop.Columns[0].HeaderText = "LapTop ID";
            dvgLapTop.Columns[1].HeaderText = "LapTop Name";
            dvgLapTop.Columns[2].HeaderText = "LapTop Brand";
            dvgLapTop.Columns[3].HeaderText = "Price";
            dvgLapTop.Columns[0].Width = 100;
            dvgLapTop.Columns[1].Width = 300;
            dvgLapTop.Columns[2].Width = 300;
            dvgLapTop.Columns[3].Width = 100;
            // Not allow user add data directly
            dvgLapTop.AllowUserToAddRows = false;
            // Not allow user update data directly
            dvgLapTop.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        // ADD FUNCTION
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql, sql_add;
            if (dtProduct.Rows.Count == 0)
            {
                MessageBox.Show("There are no data available", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(txtLapTopName.Text))
            {
                MessageBox.Show("You have not entered the laptop name", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(cbxBrand.Text))
            {
                MessageBox.Show("You have not entered the laptop brand", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("You have not entered the laptop price", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = string.Format("SELECT count(*) from Products WHERE prod_id ='{0}'", txtLaptopID.Text);
            if (DataAccess.executeScalar(sql) == 1)
            {
                MessageBox.Show("Product have already exist, plase type another ID", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLaptopID.Focus();
                return;
            }
            else
            {
                sql_add = "INSERT INTO Products(prod_name, prod_brand, prod_price) VALUES(@name, @brand, @price)";
                string[] name = { "@name", "@brand", "@price" };
                object[] value = { txtLapTopName.Text, cbxBrand.Text, txtPrice.Text };
                DataAccess.runSQL(sql_add, name, value);
                MessageBox.Show("Product added successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataGridView();
            }
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;
            txtLaptopID.Enabled = false;
            Reset();
        }

        // RESET FUNCTION
        private void Reset()
        {
            txtLaptopID.Text = "";
            txtLapTopName.Text = "";
            cbxBrand.Text = "";
            txtPrice.Text = "";
            txtSearch.Text = "";
            txtLaptopID.Enabled = false;
            loadDataGridView();
        }
        // EXIT FUNCTION
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // UPDATE FUNCTION
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtProduct.Rows.Count == 0)
            {
                MessageBox.Show("There are no data available", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtLapTopName.Text.Trim().Length == 0)
            {
                MessageBox.Show("You have not entered the laptop name", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            sql = "UPDATE Products SET prod_name = @name ,prod_brand = @brand, prod_price= @price WHERE prod_id = @id";
            string[] name = { "@name", "@brand", "@price", "@id" };
            object[] value = { txtLapTopName.Text, cbxBrand.Text, txtPrice.Text, txtLaptopID.Text };
            DataAccess.runSQL(sql, name, value);
            MessageBox.Show("Product updated successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDataGridView();
            Reset();
            btnCancel.Enabled = true;
        }
        // CLICK THE DATA FROM DATAGRIDVIEW AND PRINT TO TEXTBOX
        private void dvgLapTop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dvgLapTop.CurrentRow.Index;
            txtLaptopID.Text = dvgLapTop.Rows[i].Cells[0].Value.ToString();
            txtLapTopName.Text = dvgLapTop.Rows[i].Cells[1].Value.ToString();
            cbxBrand.Text = dvgLapTop.Rows[i].Cells[2].Value.ToString();
            txtPrice.Text = dvgLapTop.Rows[i].Cells[3].Value.ToString();
        }
        // DELETE FUNCTION
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql_product, sql_bproduct;
            if (dtProduct.Rows.Count == 0) // if dtProduct don't have any data
            {
                MessageBox.Show("There are no avilable data", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtLaptopID.Text == "") // if user don't choose any field
            {
                MessageBox.Show("You have not choose any field", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Do you want to delete?", "ALERT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql_bproduct = "DELETE Bill_details WHERE prod_id = @id";
                string[] name_b = { "@id" };
                object[] value_b = { txtLaptopID.Text };
                DataAccess.runSQL(sql_bproduct, name_b, value_b);
                sql_product = "DELETE Products WHERE prod_id = @id";
                string[] name = { "@id" };
                object[] value = { txtLaptopID.Text };
                DataAccess.runSQL(sql_product, name, value);
                MessageBox.Show("Product deleted successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataGridView();
                Reset();
            }
        }
        // CANCEL THE FUNCTION
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            btnExit.Enabled = true;
            txtLaptopID.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please type a condition for searching", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM Products WHERE 1=1";
            if (txtSearch.Text != "")
            {
                sql = sql + " AND prod_name LIKE '%" + txtSearch.Text + "%'";
            }

            dtProduct = DataAccess.getDataToTable(sql);
            if (dtProduct.Rows.Count == 0)
            {
                MessageBox.Show("There are no data available", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("There are " + dtProduct.Rows.Count + "records that satisfy the condition", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dvgLapTop.DataSource = dtProduct;
            loadDataGridViewSearch();
        }
    }
}
