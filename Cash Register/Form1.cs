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

        private void calculateButton_Click(object sender, EventArgs e)
        {
            /*double numberOne, numberTwo, numberThree, numberFour, numberFive, numberSix;
            numberOne = 2.49;
            numberTwo = 1.89;
            numberThree = 0.99;
            numberFour = 0.13;
            numberFive = * numberOne +  * numberTwo +  * numberThree;
            numberSix = numberFour * numberFive; 
            
            subtotal.Text = "Sub Total          " + numberFive 
                + "\n\nTax              " + numberSix
                + "\n\nTotal            " + (numberFive + numberSix);*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double orderNumber, orderNumber2;
            orderNumber = 0;
            orderNumber2 = orderNumber + 1;

            receipt.Text = "                   Burger Town Inc." +
                "\n\nOrder Number" + ( + 1);
        }
    }
}
