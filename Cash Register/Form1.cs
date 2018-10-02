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

        private void Form1_Load(object sender, EventArgs e)
        {
            receiptName.Visible = false;
            receipt.Visible = false;

            double numSeven;
            numSeven = 0.00;
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
                + "\n\nTax                    $" + num1
                + "\n\nTotal                 $" + num2;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            string burgerValue, fryValue, drinkValue, num, num1, num2, num3;
            burgerValue = burgerCounter.Text;
            fryValue = fryCounter.Text;
            drinkValue = drinkCounter.Text;

            double numOne, numTwo, numThree, numFour, numFive, numSix, numSeven,
                numEight, numNine, numThirteen, numFourteen, numFifteen, numSixteen;
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
            numFifteen = Convert.ToDouble(tender.Text);
            numSixteen = numFifteen - numFourteen;
            num3 = numSixteen.ToString(".##");

            change.Text = "Change $" + num3;
        }

        private void print_Click(object sender, EventArgs e)
        {
            string burgerValue, fryValue, drinkValue, num, num1, num2, num3;
            burgerValue = burgerCounter.Text;
            fryValue = fryCounter.Text;
            drinkValue = drinkCounter.Text;

            double numOne, numTwo, numThree, numFour, numFive, numSix, numSeven, numEight,                 
                numNine, numThirteen, numFourteen, numFifteen, numSixteen, numSeventeen;
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
            numFifteen = Convert.ToDouble(tender.Text);
            numSixteen = numFifteen - numFourteen;
            num3 = numSixteen.ToString(".##");
            numSeventeen = 1;
            
            receiptName.Visible = true;
            receipt.Visible = true;
            receipt.Text = "Order Number " + numSeventeen;

            final.Text = "October 11, 2018" +
                "\n\nHamburgers     x" + numSix + "  @$" + numOne +
                "\nFries                 x" + numSeven + "   @$" + numTwo +
                "\nDrink                x" + numEight + "    @$" + numThree +
                "\n\nSubTotal                    $" + numNine
                + "\nTax                            $" + num1
                + "\nTotal                          $" + num2;
        }

        private void order_Click(object sender, EventArgs e)
        {
            double numOne, numTwo, numThree,numFour;
            numOne = 2.49;
            numTwo = 1.89;
            numThree = 0.99;

            subtotal.Text = "Subtotal           $0.00"
                + "\n\nTax                      $0.00"
                + "\n\nTotal                    $0.00";
            burgerCounter.Text = "";
            fryCounter.Text = "";
            drinkCounter.Text = "";
            tender.Text = "";
            change.Text = "Change $0.00";
            receipt.Text = "Order Number";
            final.Text = "October 11, 2018" +
                "\n\nHamburgers     x0" + "  @" + numOne +
                "\nFries                x0" + "   @" + numTwo +
                "\nDrink                x0" + "   @" + numThree + 
                "\n\nSubtotal                    $0.00"
                + "\nTax                           $0.00"
                + "\nTotal                         $0.00";
        }
    }
}
