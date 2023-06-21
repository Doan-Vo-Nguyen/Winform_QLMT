using System;

namespace Winform_QLMT
{
    public partial class Home_Form : Form
    {
        public Home_Form()
        {
            InitializeComponent();
        }

        private void Home_Form_Load(object sender, EventArgs e)
        {
            DataAccess.connect();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.disconnect();
            Application.Exit();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Form product_Form = new Product_Form();
            product_Form.ShowDialog();

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Form user_Form = new User_Form();
            user_Form.ShowDialog();
        }

        private void billToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.ShowDialog();

        }

        private void billToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SearchBill_Form searchBill_Form = new SearchBill_Form();
            searchBill_Form.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }
    }
}