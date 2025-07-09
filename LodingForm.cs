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
    public partial class LodingForm : Form
    {
        public LodingForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            Percentage_label.Text = progressBar1.Value + "%";
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
