using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Cash_Register
{
    public partial class burgerTown : Form
    {
        SoundPlayer printPlayer = new SoundPlayer(Properties.Resources.print);
        SoundPlayer changePlayer = new SoundPlayer(Properties.Resources.cashRegister);

        public burgerTown()
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

            double burgerPrice, fryPrice, drinkPrice, HST, HSTFull, burgerText, fryText, 
                drinkText, subtotalText, taxText, HSTteen;
            burgerPrice = 2.49;
            fryPrice = 1.89;
            drinkPrice = 0.99;
            HST = 0.13;
            HSTFull = 1.13;
            burgerText = Convert.ToDouble(burgerCounter.Text);
            fryText = Convert.ToDouble(fryCounter.Text);
            drinkText = Convert.ToDouble(drinkCounter.Text);
            subtotalText = (burgerPrice * burgerText) + (fryPrice * fryText) + (drinkPrice * drinkText);
            taxText = subtotalText * HST;
            num1 = taxText.ToString("0.00");
            HSTteen = subtotalText * HSTFull;
            num2 = HSTteen.ToString("0.00");
            num = subtotalText.ToString("0.00");

            subtotal.Text = "Subtotal          $" + num 
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
            double burgerPrice, fryPrice, drinkPrice, HST, HSTFull, burgerText, fryText,
                drinkText, subtotalText, taxText, HSTteen, numFifteen, numSixteen;
            burgerPrice = 2.49;
            fryPrice = 1.89;
            drinkPrice = 0.99;
            HST = 0.13;
            HSTFull = 1.13;
            burgerText = Convert.ToDouble(burgerCounter.Text);
            fryText = Convert.ToDouble(fryCounter.Text);
            drinkText = Convert.ToDouble(drinkCounter.Text);
            subtotalText = (burgerPrice * burgerText) + (fryPrice * fryText) + (drinkPrice * drinkText);
            taxText = subtotalText * HST;
            num1 = taxText.ToString("0.00");
            HSTteen = subtotalText * HSTFull;
            num2 = HSTteen.ToString("0.00");
           // numFifteen = Convert.ToDouble(tender.Text);


            try // accept a value and display it to screen
            {
                number = Convert.ToInt16(tender.Text);
                numSixteen = number - HSTteen;
                num3 = numSixteen.ToString("0.00");
                changePlayer.Play();
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
            string burgerValue, fryValue, drinkValue, num, num1, num2, num3, num4;
            burgerValue = burgerCounter.Text;
            fryValue = fryCounter.Text;
            drinkValue = drinkCounter.Text;

            double burgerPrice, fryPrice, drinkPrice, HST, HSTFull, burgerText, fryText, drinkText,                 
                subtotalText, taxText, HSTteen, numFifteen, numSixteen, numSeventeen;
            burgerPrice = 2.49;
            fryPrice = 1.89;
            drinkPrice = 0.99;
            HST = 0.13;
            HSTFull = 1.13;
            burgerText = Convert.ToDouble(burgerCounter.Text);
            fryText = Convert.ToDouble(fryCounter.Text);
            drinkText = Convert.ToDouble(drinkCounter.Text);
            subtotalText = (burgerPrice * burgerText) + (fryPrice * fryText) + (drinkPrice * drinkText);
            taxText = subtotalText * HST;
            num1 = taxText.ToString("0.00");
            HSTteen = subtotalText * HSTFull;
            num2 = HSTteen.ToString("0.00");
            numFifteen = Convert.ToDouble(tender.Text);
            numSixteen = numFifteen - HSTteen;
            num3 = numSixteen.ToString("0.00");
            num4 = numFifteen.ToString("0.00");
            numSeventeen = 1;
            num = subtotalText.ToString("0.00");

            printPlayer.Play();
            Thread.Sleep(5250);

            receiptName.Visible = true;
            receipt.Visible = true;

            receiptName.Text = "Burger Town Inc.";
            receipt.Text = "Order Number " + numSeventeen;

            

            try // accept a value and display it to screen
            {
                number = Convert.ToInt16(tender.Text);
                numSixteen = number - HSTteen;
                num3 = numSixteen.ToString("0.00");
                changePlayer.Play();
                final.Text = "October 12, 2018" +
                "\n\nHamburgers   x" + burgerText + "  @" + burgerPrice +
                "\nFries                 x" + fryText + "   @" + fryPrice +
                "\nDrink                 x" + drinkText + "   @" + drinkPrice +
                "\n\nSubtotal                    $" + num
                + "\nTax                             $" + num1
                + "\nTotal                          $" + num2
                + "\n\nTendered                 $" + num4
                + "\nChange                     $" + num3
                + "\n(*u*)Have A Nice Day!(*u*)";
            }
            catch // display error message if input is not a number
            {
                final.Text = "October 12, 2018" +
                "\n\nHamburgers   x0" + "  @" + burgerPrice +
                "\nFries                 x0" + "   @" + fryPrice +
                "\nDrink                 x0" + "   @" + drinkPrice +
                "\n\nSubtotal                    $0.00"
                + "\nTax                             $0.00"
                + "\nTotal                          $0.00"
                + "\n\nTendered                 $0.00"
                + "\nChange                     $0.00"
                + "\n(*u*)Have A Nice Day!(*u*)";
                return;
            }
        }

        private void order_Click(object sender, EventArgs e)
        {
            double burgerPrice, fryPrice, drinkPrice;
            burgerPrice = 2.49;
            fryPrice = 1.89;
            drinkPrice = 0.99;

            subtotal.Text = "Subtotal           $0.00"
                + "\n\nTax                      $0.00"
                + "\n\nTotal                    $0.00";
            burgerCounter.Text = "";
            fryCounter.Text = "";
            drinkCounter.Text = "";
            tender.Text = "";
            change.Text = "Change $0.00";
            receiptName.Text = "";
            receipt.Text = "";
            final.Text = "";
        }
    }
}
