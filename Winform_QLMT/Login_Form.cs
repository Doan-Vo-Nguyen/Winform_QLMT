using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_QLMT
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        private void Login_Form_Load(object sender, EventArgs e)
        {
            DataAccess.connect();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty || txtPassword.Text != string.Empty)
            {
                string sql = "SELECT * FROM Account WHERE login_name = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'";
                // check key
                if (DataAccess.checkKey(sql))
                {
                    MessageBox.Show("Login successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Home_Form home_Form = new Home_Form();
                    home_Form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lkbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp_Form signUp_Form = new SignUp_Form();
            signUp_Form.ShowDialog();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
