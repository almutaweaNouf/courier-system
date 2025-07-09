using Project.ProjectDatabaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class CustomerSignUpForm : Form
    {
        public CustomerSignUpForm()
        {
            InitializeComponent();
        }

        public static string customerCPR;

        private void createButton_Click(object sender, EventArgs e)
        {
            string  address, email, password;
            int phoneNumber;
            try
            {
                if (customerCPRTextBox.Text != "")
                {
                    customerCPR = customerCPRTextBox.Text;

                    if (passwordTextBox.Text != "")
                    {
                        password = passwordTextBox.Text;

                        if (int.TryParse(phoneNumberTextBox.Text, out phoneNumber))
                        {
                            if (emailTextBox.Text != "")
                            {
                                email = emailTextBox.Text;
                                if (addressTextBox.Text != "")
                                {
                                    address = addressTextBox.Text;
                                    if (agreeCheckBox.Checked)
                                    {
                                        customerTableAdapter.Insert(customerCPR, password, phoneNumber.ToString(), email , address );
                                        customerTableAdapter.Fill(CustomerTableDatabaseDataSet.Customer);

                                        customerBindingSource.EndEdit();
                                        customerTableAdapter.Update(CustomerTableDatabaseDataSet.Customer);

                                        MessageBox.Show("You have successfully created an account :) ", "Inform", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                        CustomerServicesForm servicesForm = new CustomerServicesForm();
                                        servicesForm.ShowDialog();
                                    }
                                    else
                                    {
                                        MessageBox.Show("You must agree on the terms and conditions to countine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        agreeCheckBox.Focus();
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Please enter Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    addressTextBox.Focus();
                                }

                            }
                            else
                            {

                                MessageBox.Show("Please enter an email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                emailTextBox.Focus();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a Phone Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            phoneNumberTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        passwordTextBox.Focus();
                    }


                }
                else
                {
                    MessageBox.Show("Enter a valid custmer ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    customerCPRTextBox.Focus();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void CustomerSignUpForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDatabaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.CustomerTableDatabaseDataSet.Customer);

        }

        private void customerBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }
    }
}
