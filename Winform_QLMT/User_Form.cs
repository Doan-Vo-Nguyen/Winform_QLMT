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

    public partial class User_Form : Form
    {
        DataTable dtUser;
        public User_Form()
        {
            InitializeComponent();
        }

        private void User_Form_Load(object sender, EventArgs e)
        {
            txtUserID.Enabled = false;
            btnCancel.Enabled = true;
            if (txtSearch.Text == "")
            {
                loadDataGridView();
            }
            else
            {
                loadDataGridViewSearch();
            }

        }

        // LOAD DATA
        private void loadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM Users";
            dtUser = DataAccess.getDataToTable(sql); // read data from the table Users
            dgvUser.DataSource = dtUser; // source
            dgvUser.Columns[0].HeaderText = "User ID";
            dgvUser.Columns[1].HeaderText = "User Name";
            dgvUser.Columns[2].HeaderText = "User Gender";
            dgvUser.Columns[3].HeaderText = "Address";
            dgvUser.Columns[4].HeaderText = "Phone Number";
            dgvUser.Columns[0].Width = 100;
            dgvUser.Columns[1].Width = 300;
            dgvUser.Columns[2].Width = 100;
            dgvUser.Columns[3].Width = 100;
            dgvUser.Columns[4].Width = 100;
            // Not allow user add data directly
            dgvUser.AllowUserToAddRows = false;
            // Not allow user update data directly
            dgvUser.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void loadDataGridViewSearch()
        {
            dgvUser.Columns[0].HeaderText = "User ID";
            dgvUser.Columns[1].HeaderText = "User Name";
            dgvUser.Columns[2].HeaderText = "User Gender";
            dgvUser.Columns[3].HeaderText = "Address";
            dgvUser.Columns[4].HeaderText = "Phone Number";
            dgvUser.Columns[0].Width = 100;
            dgvUser.Columns[1].Width = 300;
            dgvUser.Columns[2].Width = 100;
            dgvUser.Columns[3].Width = 100;
            dgvUser.Columns[4].Width = 100;
            // Not allow user add data directly
            dgvUser.AllowUserToAddRows = false;
            // Not allow user update data directly
            dgvUser.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql, sql_add;
            if (dtUser.Rows.Count == 0)
            {
                MessageBox.Show("There are no data available", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("You have not entered the user name", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(cbxGender.Text))
            {
                MessageBox.Show("You have not entered the user gender", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(cbxAddress.Text))
            {
                MessageBox.Show("You have not entered the user address", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtPhoneNum.Text))
            {
                MessageBox.Show("You have not entered the user phone number", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = string.Format("SELECT count(*) from Users WHERE user_id ='{0}'", txtUserID.Text);
            if (DataAccess.executeScalar(sql) == 1)
            {
                MessageBox.Show("User have already existed!Please try again", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserID.Focus();
                return;
            }
            else
            {
                sql_add = "INSERT INTO Users(name,user_gender,address,phone_num) VALUES(@name, @gender, @address, @phoneNum)";
                string[] name = { "@name", "@gender", "@address", "@phoneNum" };
                object[] value = { txtUserName.Text, cbxGender.Text, cbxAddress.Text, txtPhoneNum.Text };
                DataAccess.runSQL(sql_add, name, value);
                MessageBox.Show("User added successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataGridView();
            }
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;
            Reset();
            txtUserID.Enabled = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string sql;
            if (dtUser.Rows.Count == 0) // if dt User has no data
            {
                MessageBox.Show("There are no data available", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtUserID.Text == "") // If ID empty
            {
                MessageBox.Show("You have not choose any field", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(txtUserName.Text)) // if username empty
            {
                MessageBox.Show("You have not entered the user name", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(cbxGender.Text)) // if gender empty
            {
                MessageBox.Show("You have not entered the user gender", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(cbxAddress.Text)) // if address empty
            {
                MessageBox.Show("You have not entered the user address", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtPhoneNum.Text)) // if phonenum empty
            {
                MessageBox.Show("You have not entered the user phone number", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            sql = "UPDATE Users SET name = @name, user_gender = @gender,address = @address,phone_num = @phoneNum WHERE user_id = @id";
            string[] name = { "@name", "@gender", "@address", "@phoneNum", "@id" };
            object[] value = { txtUserName.Text, cbxGender.Text, cbxAddress.Text, txtPhoneNum.Text, txtUserID.Text };
            DataAccess.runSQL(sql, name, value);
            MessageBox.Show("User updated successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDataGridView();
            Reset();
            btnCancel.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql_user, sql_account;
            if (dtUser.Rows.Count == 0) // if dtUser don't have any data
            {
                MessageBox.Show("There are no avilable data", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtUserID.Text)) // if user don't choose any field
            {
                MessageBox.Show("You have not choose any field", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Do you want to delete?", "ALERT!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql_account = "DELETE Account WHERE user_id = @id";
                string[] name_acc = { "@id" };
                object[] value_acc = { txtUserID.Text };
                DataAccess.runSQL(sql_account, name_acc, value_acc);
                sql_user = "DELETE Users WHERE user_id = @id";
                string[] name = { "@id" };
                object[] value = { txtUserID.Text };
                DataAccess.runSQL(sql_user, name, value);
                MessageBox.Show("User deleted successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataGridView();
                Reset();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
            txtUserID.Text = "";
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            btnExit.Enabled = true;
            txtSearch.Text = "";
            loadDataGridView();
        }

        private void Reset()
        {
            txtUserName.Text = "";
            cbxGender.SelectedIndex = 0;
            cbxAddress.SelectedIndex = 0;
            txtPhoneNum.Text = "";
        }

        // WHEN CLICK ON THE CELL OF DATAGRIDVIEW, THE DATA WILL BE DISPLAYED ON THE TEXTBOX
        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvUser.CurrentRow.Index;
            txtUserID.Text = dgvUser.Rows[i].Cells[0].Value.ToString();
            txtUserName.Text = dgvUser.Rows[i].Cells[1].Value.ToString();
            cbxGender.Text = dgvUser.Rows[i].Cells[2].Value.ToString();
            cbxAddress.Text = dgvUser.Rows[i].Cells[3].Value.ToString();
            txtPhoneNum.Text = dgvUser.Rows[i].Cells[4].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Please type a condition for searching", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM Users WHERE 1=1";
            if (txtSearch.Text != "")
            {
                sql = sql + " AND name LIKE '%" + txtSearch.Text + "%'";
            }

            dtUser = DataAccess.getDataToTable(sql);
            if (dtUser.Rows.Count == 0)
            {
                MessageBox.Show("There are no data available", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("There are " + dtUser.Rows.Count + " records that satisfy the condition", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvUser.DataSource = dtUser;
            loadDataGridViewSearch();
        }
    }
}
