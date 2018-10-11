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
        SoundPlayer printPlayer = new SoundPlayer(Properties.Resources.receipt);
        SoundPlayer changePlayer = new SoundPlayer(Properties.Resources.cashRegister);
        SoundPlayer errorPlayer = new SoundPlayer(Properties.Resources.errorsound);
        SoundPlayer receiptPlayer = new SoundPlayer(Properties.Resources.rip_paper);

        public burgerTown()
        {
            InitializeComponent();
        }

        private void burgerTown_Load(object sender, EventArgs e)
        {
            subtotal.Text = "Subtotal              $0.00"
                + "\n\nTax                      $0.00"
                + "\n\nTotal                    $0.00";
            burgerCounter.Text = "";
            fryCounter.Text = "";
            drinkCounter.Text = "";
            tender.Text = "";
            change.Text = "Change $0.00";
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
                errorPlayer.Play();
                checkLabel1.Text = "Check the amounts. Make\nsure it's not too much!";
                return;
            }

            try // accept a value and display it to screen
            {
                number = Convert.ToInt16(burgerCounter.Text + fryCounter.Text);
                checkLabel1.Text = "";
            }
            catch // display error message if input is not a number
            {
                errorPlayer.Play();
                checkLabel1.Text = "Check the amounts. Make\nsure it's not too much!";
                return;
            }

            try // accept a value and display it to screen
            {
                number = Convert.ToInt16(burgerCounter.Text + drinkCounter.Text);
                checkLabel1.Text = "";
            }
            catch // display error message if input is not a number
            {
                errorPlayer.Play();
                checkLabel1.Text = "Check the amounts. Make\nsure it's not too much!";
                return;
            }

            try // accept a value and display it to screen
            {
                number = Convert.ToInt16(fryCounter.Text + drinkCounter.Text);
                checkLabel1.Text = "";
            }
            catch // display error message if input is not a number
            {
                errorPlayer.Play();
                checkLabel1.Text = "Check the amounts. Make\nsure it's not too much!";
                return;
            }

            try // accept a value and display it to screen
            {
                number = Convert.ToInt16(burgerCounter.Text);
                checkLabel1.Text = "";
            }
            catch // display error message if input is not a number
            {
                errorPlayer.Play();
                checkLabel1.Text = "Check the amounts. Make\nsure it's not too much!";
                return;
            }

            try // accept a value and display it to screen
            {
                number = Convert.ToInt16(fryCounter.Text);
                checkLabel1.Text = "";
            }
            catch // display error message if input is not a number
            {
                errorPlayer.Play();
                checkLabel1.Text = "Check the amounts. Make\nsure it's not too much!";
                return;
            }

            try // accept a value and display it to screen
            {
                number = Convert.ToInt16(drinkCounter.Text);
                checkLabel1.Text = "";
            }
            catch // display error message if input is not a number
            {
                errorPlayer.Play();
                checkLabel1.Text = "Check the amounts. Make\nsure it's not too much!";
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

            subtotal.Text = "Subtotal              $" + num
                + "\n\nTax                      $" + num1
                + "\n\nTotal                    $" + num2;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            string burgerValue, fryValue, drinkValue, num1, num2, num3;
            burgerValue = burgerCounter.Text;
            fryValue = fryCounter.Text;
            drinkValue = drinkCounter.Text;
            int number;
            double burgerPrice, fryPrice, drinkPrice, HST, HSTFull, burgerText, fryText,
                drinkText, subtotalText, taxText, HSTteen, numSixteen;
            burgerPrice = 2.49;
            fryPrice = 1.89;
            drinkPrice = 0.99;
            HST = 0.13;
            HSTFull = 1.13;

            try // accept a value and display it to screen
            {
                burgerText = Convert.ToDouble(burgerCounter.Text);
                fryText = Convert.ToDouble(fryCounter.Text);
                drinkText = Convert.ToDouble(drinkCounter.Text);
                subtotalText = (burgerPrice * burgerText) + (fryPrice * fryText) + (drinkPrice * drinkText);
                taxText = subtotalText * HST;
                num1 = taxText.ToString("0.00");
                HSTteen = subtotalText * HSTFull;
                num2 = HSTteen.ToString("0.00");
                number = Convert.ToInt16(tender.Text);
                numSixteen = number - HSTteen;
                num3 = numSixteen.ToString("0.00");
                changePlayer.Play();
                checkLabel2.Text = "";
                change.Text = "Change $" + num3;
            }
            catch // display error message if input is not a number
            {
                errorPlayer.Play();
                checkLabel2.Text = "Check the amounts. Make\nsure it's enough!";
                change.Text = "Change $0.00";
                return;
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font titleFont = new Font("Microsoft Sans Serif", 15);
            Font textFont = new Font("Microsoft Sans Serif", 10);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Pen blackPen = new Pen(Color.Black, 2);

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

            try // accept a value and display it to screen
            {
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

                g.FillRectangle(whiteBrush, 206, 67, 235, 307);
                g.DrawRectangle(blackPen, 206, 67, 235, 307);

                g.DrawString("Burger Town Inc.", titleFont, blackBrush, 243, 90);
                Thread.Sleep(1000);
                g.DrawString("Order Number 1", textFont, blackBrush, 270, 117);
                Thread.Sleep(1000);
                g.DrawString("October 15, 2018", textFont, blackBrush, 270, 135);
                Thread.Sleep(1000);
                g.DrawString("Hamburgers        x" + burgerText + "  @" + burgerPrice, textFont, blackBrush, 250, 159);
                Thread.Sleep(1000);
                g.DrawString("Fries                    x" + fryText + "  @" + fryPrice, textFont, blackBrush, 250, 176);
                Thread.Sleep(900);
                g.DrawString("Drink                    x" + drinkText + "  @" + drinkPrice, textFont, blackBrush, 250, 192);
                Thread.Sleep(900);
                g.DrawString("Subtotal                     $" + num, textFont, blackBrush, 250, 216);
                Thread.Sleep(600);
                g.DrawString("Tax                            $" + num1, textFont, blackBrush, 250, 233);
                Thread.Sleep(750);
                g.DrawString("Total                          $" + num2, textFont, blackBrush, 250, 250);
                Thread.Sleep(750);
                g.DrawString("Tendered                  $" + num4, textFont, blackBrush, 250, 274);
                Thread.Sleep(750);
                g.DrawString("Change                       $" + num3, textFont, blackBrush, 250, 291);
                Thread.Sleep(1000);
                g.DrawString("Have A Nice Day!!", textFont, blackBrush, 270, 315);
            }

            catch // display error message if input is not a number
            {
                errorPlayer.Play();
                return;
            }
        }

        private void order_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            receiptPlayer.Play();
            g.Clear(Color.White);
            subtotal.Text = "Subtotal              $0.00"
                + "\n\nTax                      $0.00"
                + "\n\nTotal                    $0.00";
            burgerCounter.Text = "";
            fryCounter.Text = "";
            drinkCounter.Text = "";
            tender.Text = "";
            change.Text = "Change $0.00";
        }
    }
}