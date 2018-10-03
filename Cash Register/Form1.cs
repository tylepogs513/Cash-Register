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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            receiptName.Visible = false;
            receipt.Visible = false;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int number; // will store value entered by user

            try // accept a value and display it to screen
            {
                number = Convert.ToInt16(burgerCounter.Text + fryCounter.Text + drinkCounter.Text);
                checkLabel1.Text = "";
            }
            catch // display error message if input is not a number
            {
                checkLabel1.Text = "Check the amounts.";
                return;
            }

            try // accept a value and display it to screen
            {
                number = Convert.ToInt16(burgerCounter.Text + fryCounter.Text);
                checkLabel1.Text = "";
            }
            catch // display error message if input is not a number
            {
                checkLabel1.Text = "Check the amounts.";
                return;
            }

            try // accept a value and display it to screen
            {
                number = Convert.ToInt16(burgerCounter.Text + drinkCounter.Text);
                checkLabel1.Text = "";
            }
            catch // display error message if input is not a number
            {
                checkLabel1.Text = "Check the amounts.";
                return;
            }

            try // accept a value and display it to screen
            {
                number = Convert.ToInt16(fryCounter.Text + drinkCounter.Text);
                checkLabel1.Text = "";
            }
            catch // display error message if input is not a number
            {
                checkLabel1.Text = "Check the amounts.";
                return;
            }

            try // accept a value and display it to screen
            {
                number = Convert.ToInt16(burgerCounter.Text);
                checkLabel1.Text = "";
            }
            catch // display error message if input is not a number
            {
                checkLabel1.Text = "Check the amounts.";
                return;
            }

            try // accept a value and display it to screen
            {
                number = Convert.ToInt16(fryCounter.Text);
                checkLabel1.Text = "";
            }
            catch // display error message if input is not a number
            {
                checkLabel1.Text = "Check the amounts.";
                return;
            }

            try // accept a value and display it to screen
            {
                number = Convert.ToInt16(drinkCounter.Text);
                checkLabel1.Text = "";
            }
            catch // display error message if input is not a number
            {
                checkLabel1.Text = "Check the amounts.";
                return;
            }
            
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
            num1 = numThirteen.ToString("0.00");
            numFourteen = numNine * numFive;
            num2 = numFourteen.ToString("0.00");

            subtotal.Text = "Subtotal          $" + numNine 
                + "\n\nTax                    $" + num1
                + "\n\nTotal                 $" + num2;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            string burgerValue, fryValue, drinkValue, num1, num2, num3;
            burgerValue = burgerCounter.Text;
            fryValue = fryCounter.Text;
            drinkValue = drinkCounter.Text;
            int number;
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
            num1 = numThirteen.ToString("0.00");
            numFourteen = numNine * numFive;
            num2 = numFourteen.ToString("0.00");
            numFifteen = Convert.ToDouble(tender.Text);
            numSixteen = numFifteen - numFourteen;
            num3 = numSixteen.ToString("0.00");

            try // accept a value and display it to screen
            {
                number = Convert.ToInt16(tender.Text);
                checkLabel2.Text = "";
                change.Text = "Change $" + num3;
            }
            catch // display error message if input is not a number
            {
                checkLabel2.Text = "Check the amount tendered.";
                change.Text = "Change $0.00";
                return;
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            string burgerValue, fryValue, drinkValue, num1, num2, num3, num4;
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
            num1 = numThirteen.ToString("0.00");
            numFourteen = numNine * numFive;
            num2 = numFourteen.ToString("0.00");
            numFifteen = Convert.ToDouble(tender.Text);
            numSixteen = numFifteen - numFourteen;
            num3 = numSixteen.ToString("0.00");
            num4 = numFifteen.ToString("0.00");
            numSeventeen = 1;
            
            receiptName.Visible = true;
            receipt.Visible = true;
            receipt.Text = "Order Number " + numSeventeen;

            final.Text = "October 12, 2018" +
                "\n\nHamburgers   x" + numSix + "  @" + numOne +
                "\nFries                 x" + numSeven + "   @" + numTwo +
                "\nDrink                 x" + numEight + "   @" + numThree +
                "\n\nSubtotal                    $" + numNine
                + "\nTax                             $" + num1
                + "\nTotal                          $" + num2 
                + "\n\nTendered                 $" + num4
                + "\nChange                     $" + num3
                + "\n       Have A Nice Day!";
        }

        private void order_Click(object sender, EventArgs e)
        {
            double numOne, numTwo, numThree;
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
            receipt.Text = "Order Number 0";
            final.Text = "October 11, 2018" +
                "\n\nHamburgers   x0" + "  @" + numOne +
                "\nFries                 x0" + "   @" + numTwo +
                "\nDrink                 x0" + "   @" + numThree + 
                "\n\nSubtotal                    $0.00"
                + "\nTax                             $0.00"
                + "\nTotal                          $0.00" +
                "\n\nTendered                 $0.00" +
                "\nChange                     $0.00" +
                "\n       Have A Nice Day!";
        }
    }
}
