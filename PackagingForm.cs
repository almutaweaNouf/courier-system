using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class PackagingForm : Form
    {
        public PackagingForm()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            int orderID;
            string PackagingType;
            try
            {
                if (int.TryParse(orderIDTextBox.Text, out orderID))
                {

                    if (packagingListBox.SelectedIndex != -1)
                    {
                        PackagingType = packagingListBox.SelectedIndex.ToString();
                        // database code

                        packagingBindingSource.EndEdit();
                        packagingTableAdapter.Update(packagingDatabaseDataSet1.Packaging);

                        MessageBox.Show("you hava Selected a packaging type successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please choose a packaing type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        packagingListBox.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Please enter an order id ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    orderIDTextBox.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PackagingForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'packagingDatabaseDataSet1.Packaging' table. You can move, or remove it, as needed.
            this.packagingTableAdapter.Fill(this.packagingDatabaseDataSet1.Packaging);

        }
    }
}
