using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace RoadHouse
{
    public partial class Form1 : Form
    {
        int bA;
        int fA;
        int dA;
        double subT;
        const double TAX = 0.13;    // declares the variables
        double subTT;
        double total;
        double tendered;
        double change;


        public Form1()
        {
            InitializeComponent();
        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            try
            {
                bA = Convert.ToInt16(burgerBox.Text);
                fA = Convert.ToInt16(fryBox.Text);               // Reads the numbers in the textboxes 
                dA = Convert.ToInt16(drinkBox.Text);
            }
            catch
            {
                subTitleLabel.Text = "You're driving me mad, do it right!";
                Refresh();
                Thread.Sleep(1500);                                         // If they aren't numbers, or are greater/less
                subTitleLabel.Text = "Our prices'll drive you mad!";        // than 32767 (standard integer/double), play this
                Refresh();
                return;
            }
            double bPrice = bA * 3.50;
            double fPrice = fA * 1.50;
            double dPrice = dA * 1.00;

            subT = bPrice + fPrice + dPrice;
            subPLabel.Text = "" + subT;

            subTT = subT * TAX;                     // Price Calculations.
            taxLabel.Text = "" + subTT;

            total = subTT + subT;
            priceLabel.Text = "" + total;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToInt16(payBox.Text);        // Calculates the tendered.
            }
            catch
            {
                subTitleLabel.Text = "You're driving me mad, do it right!";
                Refresh();
                Thread.Sleep(1500);
                subTitleLabel.Text = "Our prices'll drive you mad!";        // If not a number, or too big/small, do this
                Refresh();
                return;
            }
            change = tendered - total;
            if (change < 0)
            {
                subTitleLabel.Text = "You don't have enough!";
                Refresh();
                Thread.Sleep(3000);
                subTitleLabel.Text = "Our prices'll drive you mad!";    // If you're too poor, don't display anything
                Refresh();
            }
            else
            {
                changeLabel.Text = "" + change;            // Otherwise, display the change
            }
        }

        private void reciptButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sPlay = new SoundPlayer(Properties.Resources.Dial_up_Internet);
            Graphics roadG = colorLabel.CreateGraphics();
            Brush textBrush = new SolidBrush(Color.Black);
            Font textFont = new Font("road rage", 10);
            if (change < 0)
            {
                subTitleLabel.Text = "You don't have enough!";    // Refuses to print a recipt if you can't afford
                Refresh();
                Thread.Sleep(3000);
                subTitleLabel.Text = "Our prices'll drive you mad!";
                Refresh();
            }
            else
            {
                sPlay.Play();
                roadG.DrawString("Ragin' Andy's Ragin' Angry Roadhouse", textFont, textBrush, 25, 10);
                Thread.Sleep(500);
                roadG.DrawString("Order Number 42", textFont, textBrush, 50, 40);
                Thread.Sleep(500);
                roadG.DrawString("XX/XX/20XX", textFont, textBrush, 50, 60);

                roadG.DrawString("Burgers @ $3.50 = " + bA, textFont, textBrush, 25, 100); // Slowly prints the recipt.
                Thread.Sleep(500);                                                         // Uses Font "Road Rage. Not sure how to keep it with the file.
                roadG.DrawString("Fries @ $1.50 = " + fA, textFont, textBrush, 25, 120);
                Thread.Sleep(500);
                roadG.DrawString("Drinks @ $1.00 = " + dA, textFont, textBrush, 25, 140);
                Thread.Sleep(500);

                roadG.DrawString("SubTotal = " + subT, textFont, textBrush, 25, 180);
                Thread.Sleep(500);
                roadG.DrawString("Tax @ 13% = " + subTT, textFont, textBrush, 25, 200);
                Thread.Sleep(500);
                roadG.DrawString("Total = " + total, textFont, textBrush, 25, 220);
                Thread.Sleep(500);

                roadG.DrawString("Tendered = " + tendered, textFont, textBrush, 25, 260);
                Thread.Sleep(500);
                roadG.DrawString("Change = " + change, textFont, textBrush, 25, 280);
                Thread.Sleep(500);

                roadG.DrawString("Thank you for eating with us!", textFont, textBrush, 50, 320);
                Thread.Sleep(500);
                roadG.DrawString("Now get out!", textFont, textBrush, 50, 340);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics roadG = colorLabel.CreateGraphics();
            roadG.Clear(Color.SaddleBrown);
            bA = 0;
            fA = 0;
            dA = 0;
            subT = 0;
            subTT = 0;
            total = 0;                  // Clears out everything, literally everything.
            tendered = 0;
            change = 0;
            burgerBox.Text = "";
            fryBox.Text = "";
            drinkBox.Text = "";
            subPLabel.Text = "";
            taxLabel.Text = "";
            priceLabel.Text = "";
            payBox.Text = "";
            changeLabel.Text = "";
        }
    }
}