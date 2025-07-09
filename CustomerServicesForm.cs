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
    public partial class CustomerServicesForm : Form
    {
        public CustomerServicesForm()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (newOrderRadioButton.Checked || orderDetailsRadioButton.Checked || rescheduleOrderRadioButton.Checked ||
                    cancelRadioButton.Checked || packagingRadioButton.Checked)
                {

                    if (newOrderRadioButton.Checked)
                    {
                        NewOrderForm newOrderForm = new NewOrderForm();
                        newOrderForm.ShowDialog();
                    }
                    else if (orderDetailsRadioButton.Checked)
                    {
                        OrderDeatailsForm orderDetailsForm = new OrderDeatailsForm();
                        orderDetailsForm.ShowDialog();
                    }
                    else if (rescheduleOrderRadioButton.Checked)
                    {
                        RescheduleANDUpdateForm rescheduleANDUpdateForm = new RescheduleANDUpdateForm();
                        rescheduleANDUpdateForm.ShowDialog();
                    }
                    else if (cancelRadioButton.Checked)
                    {
                        CancleOrderForm cancelOrderForm = new CancleOrderForm();
                        cancelOrderForm.ShowDialog();
                    }
                    else if (packagingRadioButton.Checked)
                    {
                        PackagingForm packagingForm = new PackagingForm();
                        packagingForm.ShowDialog();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void containerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = servicesGroupBox.BackColor;
            colorDialog1.ShowDialog();
            servicesGroupBox.BackColor = colorDialog1.Color;
        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = this.BackColor;
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void returnToMainFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.ShowDialog();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog();
        }

        private void learnMoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LearnMoreForm learnMoreForm = new LearnMoreForm();
            learnMoreForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
