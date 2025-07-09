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
    public partial class NewOrderForm : Form
    {
        public NewOrderForm()
        {
            InitializeComponent();
        }

        const decimal KgPRate = 10m, GOLDENAIR = 35, SILVEROCEAN = 25, BRONZEROAD = 10, International = 15, Domestic = 3;
       //  private static readonly string custoCPR;
        public decimal  delP, PackageP, price, Weight;
        public string custCPR;


        private decimal TotalPrice(decimal delP, decimal PackageP, decimal Weight)
        {
            decimal totalPrice = 0;
            totalPrice = (Weight * KgPRate) + delP + PackageP;
            return totalPrice;
        }

        private void continueButton_Click_1(object sender, EventArgs e)
        {
            string DeliveryType, Destantion, content, Date = "", selectedPackage = "", msg;

            try
            {
                if (customerCPRtextBox.Text != "")
                {
                    custCPR = customerCPRtextBox.Text;

                    if (DeliveryTypeComboBox.SelectedIndex != -1)
                    {
                        DeliveryType = DeliveryTypeComboBox.SelectedItem.ToString();
                        switch (DeliveryType)
                        {
                            case "International":
                                delP = International;
                                break;
                            case "Domestic":
                                delP = Domestic;
                                break;
                        }
                        if (DestinationTextBox.Text != "")
                        {
                            Destantion = DestinationTextBox.Text;
                            if (contentComboBox.SelectedIndex != -1)
                            {
                                content = contentComboBox.SelectedItem.ToString();
                                if (decimal.TryParse(weightTextBox.Text, out Weight))
                                {

                                    if (ArriveDateTimePicker.Text != "")
                                    {
                                        Date = ArriveDateTimePicker.Text;

                                        if (goldenAirRadioButton.Checked || silverOceanRadioButton.Checked || bronzeRoadRadioButton.Checked)
                                        {

                                            if (goldenAirRadioButton.Checked)
                                            {
                                                selectedPackage = "Golden Air";
                                                PackageP = GOLDENAIR;
                                            }
                                            else if (silverOceanRadioButton.Checked)
                                            {
                                                selectedPackage = "Silver Ocean";
                                                PackageP = SILVEROCEAN;
                                            }
                                            else if (bronzeRoadRadioButton.Checked)
                                            {
                                                selectedPackage = bronzeRoadRadioButton.Text;
                                                PackageP = BRONZEROAD;
                                            }


                                            price = TotalPrice(delP, PackageP, Weight);

                                            msg = " The total price is " + price.ToString("C");
                                            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            // CustomerLoginForm customerLoginForm = new CustomerLoginForm();
                                            //error in customer id 
                                            ordersTableAdapter.Insert(custCPR, DeliveryType, Destantion, content, Weight, Date, selectedPackage, price);
                                            ordersTableAdapter.Fill(ordersNewDatabaseDataSet.Orders);

                                            ordersBindingSource.EndEdit();
                                            ordersTableAdapter.Update(ordersNewDatabaseDataSet.Orders);


                                        }
                                        else
                                        {
                                            MessageBox.Show("Please select a package", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            PackagingPanel.Focus();

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please select the desired arrival date ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        ArriveDateTimePicker.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please enter a valid weight ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    weightTextBox.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please select the content of your order ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                contentComboBox.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a destantion ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            DestinationTextBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please  select a delivery type ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DeliveryTypeComboBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the CPR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PackagingPanel.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ordersNewDatabaseDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.ordersNewDatabaseDataSet.Orders);
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            CustomerServicesForm customerServicesForm = new CustomerServicesForm();
            customerServicesForm.ShowDialog();
            this.Close();
        }
    }
}
