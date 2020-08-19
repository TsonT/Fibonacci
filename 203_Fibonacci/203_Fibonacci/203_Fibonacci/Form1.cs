//Nicholas Tran
//10/7/18
//Fourth
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _203_Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //converts text into integer
            int Input = Convert.ToInt16(txtInput.Text);

            txtInput.Text = txtInput.Text + Term.Correct(Input);

            txtAnswer.Text = Convert.ToString(Fibonacci.Calculate(Input));
        }

        //Previous button click event
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //Determines the proper suffix of the number
            string strText = txtInput.Text;

            strText = strText.Remove(strText.Length - 1);
            strText = strText.Remove(strText.Length - 1);

            int Input = Convert.ToInt16(strText);

            Input = Input - 1;

            txtInput.Text = Input + Term.Correct(Input);

            txtAnswer.Text = Convert.ToString(Fibonacci.Calculate(Input));
        }

        //Next button click
        private void btnNext_Click(object sender, EventArgs e)
        {
            string strText = txtInput.Text;

            strText = strText.Remove(strText.Length - 1);
            strText = strText.Remove(strText.Length - 1);

            int Input = Convert.ToInt16(strText);

            Input = Input + 1;

            txtInput.Text = Input + Term.Correct(Input);

            txtAnswer.Text = Convert.ToString(Fibonacci.Calculate(Input));
        }

        //Fibancci class
        static class Fibonacci
        {
            public static int Calculate(int num)
            {
                if (num <= 2)
                {
                    return 1;
                }

                return Calculate(num - 1) + Calculate(num - 2);
            }
        }

        //Finds the correct suffix
        static class Term
        {
            public static string Correct(int Input)
            {
                int LastDigit = Input % 10;

                if (LastDigit == 1)
                {
                    return "st";
                }

                else if (LastDigit == 2)
                {
                    return "nd";
                }

                else if (LastDigit == 3)
                {
                    return "rd";
                }

                else
                {
                  return "th";
                }
            }
        }
    }
}
