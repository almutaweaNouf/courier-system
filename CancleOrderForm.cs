using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class CancleOrderForm : Form
    {
        public CancleOrderForm()
        {
            InitializeComponent();
        }

        private void CancleOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cancleOrderDatabaseDataSet.Orders' table. You can move, or remove it, as needed.
           // this.ordersTableAdapter.Fill(this.cancleOrderDatabaseDataSet.Orders);
        }

        public string customerCPR; 

        private void cancelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (agreeCheckBox.Checked)
                {
                        cancleOrderDatabaseDataSet.OrdersRow rw;
                        string ID = order_IDTextBox.Text;
                        rw = cancleOrderDatabaseDataSet.Orders.FindByOrder_ID(int.Parse(ID));

                        if (rw != null)
                        {
                            rw.Delete();
                            MessageBox.Show("This order is deleted :) ", "Information ",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            ordersBindingSource.EndEdit();
                            MessageBox.Show("This order can not be deleted ", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                else
                {
                        MessageBox.Show("You must agree to cancle your order ", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showMyOrdersButton_Click(object sender, EventArgs e)
        {
            string Reason;
            try
            {
                if (customerCPRTextBox.Text != "")
                {
                    customerCPR = customerCPRTextBox.Text;
                    if (reasonsComboBox.SelectedIndex != -1)
                    {
                        Reason = reasonsComboBox.SelectedItem.ToString();
                        ordersTableAdapter.FillByCustomerCPR(cancleOrderDatabaseDataSet.Orders, customerCPR);
                    }
                    else
                    {
                        MessageBox.Show("Please a reason of cancelation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reasonsComboBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your CPR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    customerCPRTextBox.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
