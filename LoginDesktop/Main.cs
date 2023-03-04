using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDesktop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string dollar;
            double dollarValue;
            double copValue = 4780.18;

            dollar = txtConvert.Text;
            dollarValue = Convert.ToDouble(dollar);

            double result = dollarValue * copValue;

            MessageBox.Show("The value in COP is: $" + result + " COP");
        }

        private void btnFibo_Click(object sender, EventArgs e)
        {
            // fibonacci
            int num = Convert.ToInt32(txtFibo.Text);
            int fibo = 0;

            if (num == 2 || num == 1)
            {
                MessageBox.Show("Response: 1");
            } else
            {
                int a = 1;
                int b = 1;
                for (int i = 3; i <= num + 1; i++)
                {
                    fibo = a + b;
                    a = b;
                    b = fibo;
                }
            }

            MessageBox.Show("Response: " + fibo);
        }
    }
}
