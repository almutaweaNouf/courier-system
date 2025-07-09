using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class OrderDeatailsForm : Form
    {
        public OrderDeatailsForm()
        {
            InitializeComponent();
        }

        private void continuetrackOrder_Click(object sender, EventArgs e)
        {
            string CustomerCPR;
            try
            {
                if (customerIDTextBox.Text != "")
                {
                    CustomerCPR = customerIDTextBox.Text;
                    // ordersTableAdapter.FillByCustomerCPR(ordersQuieriesDatabaseDataSet.Orders, CPR);

                    ordersTableAdapter.FillByCustomerCPRDetails(orderDeatailsDatabaseDataSet.Orders, CustomerCPR);

                }
                else
                {

                    MessageBox.Show("Please choose a customer CPR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    customerIDTextBox.Focus();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customerIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderDeatailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderDeatailsDatabaseDataSet.Orders' table. You can move, or remove it, as needed.
            //this.ordersTableAdapter.Fill(this.orderDeatailsDatabaseDataSet.Orders);

        }
    }
}
