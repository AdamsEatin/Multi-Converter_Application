using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Adam Eaton
//C00179859
//21/09/2016

namespace MultiConvMenu
{
    public partial class MultiConvMenu : Form
    {
        //Creating Variables
        String x;
        double a, output;

        public MultiConvMenu()
        {
            InitializeComponent();
        }

        //Printing the value into the textbox
        private void B0_Click_1(object sender, EventArgs e)
        {
            tBox.Text += "0";
        }

        private void B1_Click(object sender, EventArgs e)
        {
            tBox.Text += "1";
        }

        private void B2_Click_1(object sender, EventArgs e)
        {
            tBox.Text += "2";
        }

        private void B3_Click_1(object sender, EventArgs e)
        {
            tBox.Text += "3";
        }

        private void B4_Click(object sender, EventArgs e)
        {
            tBox.Text += "4";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            tBox.Text += "5";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            tBox.Text += "6";
        }

        private void B7_Click(object sender, EventArgs e)
        {
            tBox.Text += "7";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            tBox.Text += "8";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            tBox.Text += "9";
        }

        //Insterting a dot
        private void bDot_Click(object sender, EventArgs e)
        {
            //Checking if the box already contains a dot
            //If it does, it prints nothing
            if (tBox.Text.Contains("."))
            {

            }
            //if it doesnt, it prints a dot
            else
            {
                tBox.Text += ".";
            }
        }

        //Clearing textbox
        private void clearB_Click(object sender, EventArgs e)
        {
            tBox.Text = String.Empty;
        }

        //Menu Functions
        //Length
        private void inchesToFeetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prints a message box if the TextBox is empty or just a dot
            //preventing a crash
            if (tBox.Text == "" || tBox.Text == ".")
            {
                MessageBox.Show("Make sure you have a usable number");
            }
            //If it contains something, the following will excecute
            else
            {
                //Setting the value of x and changing it to an Integer
                x = tBox.Text;
                a = Double.Parse(x);

                output = a * 0.0833333;
                tBox.Text = output.ToString();

            }
        }

        private void feetToInchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prints a message box if the TextBox is empty or just a dot
            //preventing a crash
            if (tBox.Text == "" || tBox.Text == ".")
            {
                MessageBox.Show("Make sure you have a usable number");
            }
            //If it contains something, the following will excecute
            else
            {
                //Setting the value of x and changing it to an Integer
                x = tBox.Text;
                a = Double.Parse(x);

                output = a * 12;
                tBox.Text = output.ToString();

            }
        }

        //Currency
        private void gBPToEURToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prints a message box if the TextBox is empty or just a dot
            //preventing a crash
            if (tBox.Text == "" || tBox.Text == ".")
            {
                MessageBox.Show("Make sure you have a usable number");
            }
            //If it contains something, the following will excecute
            else
            {
                //Setting the value of x and changing it to an Integer
                x = tBox.Text;
                a = Double.Parse(x);

                output = a * 1.16;
                tBox.Text = output.ToString();

            }
        }

        private void eURToGBPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prints a message box if the TextBox is empty or just a dot
            //preventing a crash
            if (tBox.Text == "" || tBox.Text == ".")
            {
                MessageBox.Show("Make sure you have a usable number");
            }
            //If it contains something, the following will excecute
            else
            {
                //Setting the value of x and changing it to an Integer
                x = tBox.Text;
                a = Double.Parse(x);

                output = a * 0.79;
                tBox.Text = output.ToString();

            }
        }

        //Temperature
        private void celToFarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prints a message box if the TextBox is empty or just a dot
            //preventing a crash
            if (tBox.Text == "" || tBox.Text == ".")
            {
                MessageBox.Show("Make sure you have a usable number");
            }
            //If it contains something, the following will excecute
            else
            {
                //Setting the value of x and changing it to an Integer
                x = tBox.Text;
                a = Double.Parse(x);

                output = 32 + (a * 9 / 5);
                tBox.Text = output.ToString();

            }
        }

        private void farToCelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prints a message box if the TextBox is empty or just a dot
            //preventing a crash
            if (tBox.Text == "" || tBox.Text == ".")
            {
                MessageBox.Show("Make sure you have a usable number");
            }
            //If it contains something, the following will excecute
            else
            {
                //Setting the value of x and changing it to an Integer
                x = tBox.Text;
                a = Double.Parse(x);

                output = ((a - 32) * 5) / 9;
                tBox.Text = output.ToString();

            }
        }



    }
}
