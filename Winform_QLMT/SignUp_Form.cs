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
    public partial class SignUp_Form : Form
    {
        public SignUp_Form()
        {
            InitializeComponent();
        }

        private void SignUp_Form_Load(object sender, EventArgs e)
        {
            DataAccess.connect();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT count(*) from Users WHERE name ='{0}'", txtName.Text);
            if (txtName.Text != "" && cbxGender.Text != "" && cbxAddress.Text != "")
            {

                if (DataAccess.executeScalar(sql) == 0)
                {
                    string sql_add = "INSERT INTO Users(name,user_gender,address,phone_num) VALUES(@name, @gender, @address, @phoneNum)";
                    string[] name = { "@name", "@gender", "@address", "@phoneNum" };
                    object[] value = { txtName.Text, cbxGender.Text, cbxAddress.Text, txtPhoneNum.Text };
                    DataAccess.runSQL(sql_add, name, value);
                    // get id from the user just added
                    string sql_getId = string.Format("SELECT user_id FROM Users WHERE name ='{0}'", txtName.Text);
                    int id = (int)DataAccess.executeScalar(sql_getId);
                    string sql_addAccount = "INSERT INTO Account(user_id, login_name, email, password) VALUES(@user_id, @login_name, @email, @password)";
                    string[] nameAccount = { "@user_id", "@login_name", "@email", "@password" };
                    object[] valueAccount = { id, txtLoginName.Text, txtEmail.Text, txtPassword.Text };
                    DataAccess.runSQL(sql_addAccount, nameAccount, valueAccount);
                    MessageBox.Show("Signup successfully", "ALERT!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login_Form login_Form = new Login_Form();
                    login_Form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("User have already existed!Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.ShowDialog();
        }
    }
}
