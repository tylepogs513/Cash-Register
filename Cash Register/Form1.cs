using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        double zero;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            string burgerValue, fryValue, drinkValue, num, num1, num2;
            burgerValue = burgerCounter.Text;
            fryValue = fryCounter.Text;
            drinkValue = drinkCounter.Text;

            double numOne, numTwo, numThree, numFour, numFive, numSix, numSeven, 
                numEight, numNine, numThirteen, numFourteen;
            numOne = 2.49;
            numTwo = 1.89;
            numThree = 0.99;
            numFour = 0.13;
            numFive = 1.13;
            numSix = Convert.ToDouble(burgerCounter.Text);
            numSeven = Convert.ToDouble(fryCounter.Text);
            numEight = Convert.ToDouble(drinkCounter.Text);
            numNine = (numOne * numSix) + (numTwo * numSeven) + (numThree * numEight);
            numThirteen = numNine * numFour;
            num1 = numThirteen.ToString(".##");
            numFourteen = numNine * numFive;
            num2 = numFourteen.ToString(".##");

            subtotal.Text = "SubTotal          $" + numNine 
                + "\n\nTax                  $" + num1
                + "\n\nTotal                $" + numFourteen;
        }

        private void order_Click(object sender, EventArgs e)
        {
            double  numSeven;
            numSeven = 0;

            subtotal.Text = "SubTotal          $" + numSeven
                + "\n\nTax                  $" + numSeven
                + "\n\nTotal                $" + numSeven;

            receipt.Text = "Order Number";
        }

        private void print_Click(object sender, EventArgs e)
        {
            receipt.Text = "Order Number";
        }
    }
}
