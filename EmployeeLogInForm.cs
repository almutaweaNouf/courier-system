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
    public partial class EmployeeLogInForm : Form
    {
        public EmployeeLogInForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {   int employeeCPR;
            String password;
            try
            { 
                if(int.TryParse(employeeCPRTextBox.Text, out employeeCPR))
                {  if (employeePasswordTextBox.Text != "")
                    { password=employeeCPRTextBox.Text;

                        var username = employeeCPRTextBox.Text;
                        var pass = employeePasswordTextBox.Text;
                        bool invalid = true;
                        foreach (var rows in employeeDatabaseDataSet.Employee)
                        {
                            if (username.Equals(rows.Employee_CPR, StringComparison.InvariantCultureIgnoreCase) && pass.Equals(rows.Password))
                            {
                                MessageBox.Show("Login successfully.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                invalid = false;
                                QuiriesForm quiriesForm = new QuiriesForm();
                                quiriesForm.ShowDialog();
                                this.Hide();
                                break;
                            }}
                        if (invalid)
                        {
                            foreach (var rows in employeeDatabaseDataSet.Employee)
                            {
                                if (!(username.Equals(rows.Employee_CPR, StringComparison.InvariantCultureIgnoreCase)) || !(pass.Equals(rows.Password)))
                                {
                                    MessageBox.Show("Invalid username or password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            }  } }
                    else
                    {
                        MessageBox.Show("Please enter employee password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        employeePasswordTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter employee CPR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    employeeCPRTextBox.Focus();
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        }

        private void checkBoxHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHide.Checked )
            {
                employeePasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                employeePasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void EmployeeLogInForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDatabaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDatabaseDataSet.Employee);

        }
    }
}
