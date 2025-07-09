using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Project
{
    public partial class CustomerLoginForm : Form
    {
        public CustomerLoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string customerPass, customerCPR;

            try
            {
                if (customerIdTextBox.Text != "")
                {
                    customerCPR = customerIdTextBox.Text;
                    if (passwordTextBox.Text != "")
                    {
                        customerPass = passwordTextBox.Text;

                        var username = customerIdTextBox.Text;
                        var password = passwordTextBox.Text;
                        bool invalid = true;
                        foreach (var rows in customerDatabaseDataSet.Customer)
                        {
                            if (username.Equals(rows.Customer_CPR, StringComparison.InvariantCultureIgnoreCase) && password.Equals(rows.Password))
                            {
                                MessageBox.Show("Login successfully.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                invalid = false;

                                CustomerServicesForm servicesForm = new CustomerServicesForm();
                                servicesForm.ShowDialog();

                                servicesForm.newOrderRadioButton.Checked = true;
                                servicesForm.orderDetailsRadioButton.Checked = false;
                                servicesForm.rescheduleOrderRadioButton.Checked = false;
                                servicesForm.cancelRadioButton.Checked = false;
                                servicesForm.packagingRadioButton.Checked = false;
                                break;
                            }


                        }
                        if (invalid)
                        {
                            foreach (var rows in customerDatabaseDataSet.Customer)
                            {
                                if (!(username.Equals(rows.Customer_CPR, StringComparison.InvariantCultureIgnoreCase)) || !(password.Equals(rows.Password)))
                                {
                                    MessageBox.Show("Invalid username or password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }

                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("Please enter the Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        passwordTextBox.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Please enter a valid CPR ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    customerIdTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }        

        private void InstructionLabel_Click(object sender, EventArgs e)
        {
            CustomerSignUpForm singUpForm = new CustomerSignUpForm();
            singUpForm.ShowDialog();
            this.Hide();
        }

        private void checkBoxHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHide.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void CustomerLoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDatabaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerDatabaseDataSet.Customer);

        }
    }
}
