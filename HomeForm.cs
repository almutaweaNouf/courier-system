using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            CustomerLoginForm customerLoginForm = new CustomerLoginForm();
            customerLoginForm.ShowDialog();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            EmployeeLogInForm employeeLogInForm = new EmployeeLogInForm();
            employeeLogInForm.ShowDialog();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult myResponse;
            myResponse = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if(myResponse == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
                
        }
    }
}
