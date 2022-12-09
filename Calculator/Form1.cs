using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        Boolean new_calculation;

        private void clean_btn_Click(object sender, EventArgs e)
        {
            this.display_lbe.Text = "0";
            this.display2_lbe.Text = "";
            this.display3_lbe.Text = "";
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            string chk_display;
            chk_display = this.display_lbe.Text;

            //-------------------------------------
            if (new_calculation == true)
            {
                this.display_lbe.Text = "";
                new_calculation = false;
            }
            //-------------------------------------

            if (chk_display == "0")
            {
                this.display_lbe.Text = "0";
            }
            else
            {
                this.display_lbe.Text = this.display_lbe.Text + "0";
            }
        }

        private void one_btn_Click(object sender, EventArgs e)
        {
            string chk_display;
            chk_display = this.display_lbe.Text;

            //-------------------------------------
            if (new_calculation == true)
            {
                this.display_lbe.Text = "";
                new_calculation = false;
            }
            //-------------------------------------
            if (chk_display == "0")
            {
                this.display_lbe.Text = "1";
            }
            else
            {
                this.display_lbe.Text = this.display_lbe.Text + "1";
            }
        }

        private void two_btn_Click(object sender, EventArgs e)
        {
            string chk_display;
            chk_display = this.display_lbe.Text;

            //-------------------------------------
            if (new_calculation == true)
            {
                this.display_lbe.Text = "";
                new_calculation = false;
            }
            //-------------------------------------

            if (chk_display == "0")
            {
                this.display_lbe.Text = "2";
            }
            else
            {
                this.display_lbe.Text = this.display_lbe.Text + "2";
            }
        }

        private void three_btn_Click(object sender, EventArgs e)
        {
            string chk_display;
            chk_display = this.display_lbe.Text;

            //-------------------------------------
            if (new_calculation == true)
            {
                this.display_lbe.Text = "";
                new_calculation = false;
            }
            //-------------------------------------

            if (chk_display == "0")
            {
                this.display_lbe.Text = "3";
            }
            else
            {
                this.display_lbe.Text = this.display_lbe.Text + "3";
            }
        }

        private void four_btn_Click(object sender, EventArgs e)
        {
            string chk_display;
            chk_display = this.display_lbe.Text;

            //-------------------------------------
            if (new_calculation == true)
            {
                this.display_lbe.Text = "";
                new_calculation = false;
            }
            //-------------------------------------

            if (chk_display == "0")
            {
                this.display_lbe.Text = "4";
            }
            else
            {
                this.display_lbe.Text = this.display_lbe.Text + "4";
            }
        }

        private void five_btn_Click(object sender, EventArgs e)
        {
            string chk_display;
            chk_display = this.display_lbe.Text;

            //-------------------------------------
            if (new_calculation == true)
            {
                this.display_lbe.Text = "";
                new_calculation = false;
            }
            //-------------------------------------

            if (chk_display == "0")
            {
                this.display_lbe.Text = "5";
            }
            else
            {
                this.display_lbe.Text = this.display_lbe.Text + "5";
            }
        }

        private void six_btn_Click(object sender, EventArgs e)
        {
            string chk_display;
            chk_display = this.display_lbe.Text;

            //-------------------------------------
            if (new_calculation == true)
            {
                this.display_lbe.Text = "";
                new_calculation = false;
            }
            //-------------------------------------

            if (chk_display == "0")
            {
                this.display_lbe.Text = "6";
            }
            else
            {
                this.display_lbe.Text = this.display_lbe.Text + "6";
            }
        }

        private void seven_btn_Click(object sender, EventArgs e)
        {
            string chk_display;
            chk_display = this.display_lbe.Text;

            //-------------------------------------
            if (new_calculation == true)
            {
                this.display_lbe.Text = "";
                new_calculation = false;
            }
            //-------------------------------------

            if (chk_display == "0")
            {
                this.display_lbe.Text = "7";
            }
            else
            {
                this.display_lbe.Text = this.display_lbe.Text + "7";
            }
        }

        private void eight_btn_Click(object sender, EventArgs e)
        {
            string chk_display;
            chk_display = this.display_lbe.Text;

            //-------------------------------------
            if (new_calculation == true)
            {
                this.display_lbe.Text = "";
                new_calculation = false;
            }
            //-------------------------------------

            if (chk_display == "0")
            {
                this.display_lbe.Text = "8";
            }
            else
            {
                this.display_lbe.Text = this.display_lbe.Text + "8";
            }
        }

        private void nine_btn_Click(object sender, EventArgs e)
        {
            string chk_display;
            chk_display = this.display_lbe.Text;

            //-------------------------------------
            if (new_calculation == true)
            {
                this.display_lbe.Text = "";
                new_calculation = false;
            }
            //-------------------------------------

            if (chk_display == "0")
            {
                this.display_lbe.Text = "9";
            }
            else
            {
                this.display_lbe.Text = this.display_lbe.Text + "9";
            }
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            double n1, n2, r;
            r = 0;

            double.TryParse(this.display2_lbe.Text, out n1);
            double.TryParse(this.display_lbe.Text, out n2);

            this.display3_lbe.Text = "+";

            //--------------------------------------
            if(this.display_lbe.Text != "")
            {
                this.display2_lbe.Text = this.display_lbe.Text;

                if (this.display_lbe.Text != "")
                {
                    if (n2 != 0 && n1 != 0)
                    {
                        r = n1 + n2;
                        this.display2_lbe.Text = r.ToString();
                    }
                }
            }
            //--------------------------------------
            this.display_lbe.Text = "";
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            double n1, n2, r;
            r = 0;

            double.TryParse(this.display2_lbe.Text, out n1);
            double.TryParse(this.display_lbe.Text, out n2);

            this.display3_lbe.Text = "-";

            //--------------------------------------
            if (this.display_lbe.Text != "")
            {
                this.display2_lbe.Text = this.display_lbe.Text;

                if (this.display_lbe.Text != "")
                {
                    if (n2 != 0 && n1 != 0)
                    {
                        r = n1 - n2;
                        this.display2_lbe.Text = r.ToString();
                    }
                }
            }
            //--------------------------------------
            

            this.display_lbe.Text = "";
        }

        private void multiple_btn_Click(object sender, EventArgs e)
        {
            double n1, n2, r;
            r = 0;

            double.TryParse(this.display2_lbe.Text, out n1);
            double.TryParse(this.display_lbe.Text, out n2);

            this.display3_lbe.Text = "X";
            
            //--------------------------------------
            if (this.display_lbe.Text != "")
            {
                this.display2_lbe.Text = this.display_lbe.Text;

                if (this.display_lbe.Text != "")
                {
                    if (n2 != 0 && n1 != 0)
                    {
                        r = n1 * n2;
                        this.display2_lbe.Text = r.ToString();
                    }
                }
            }
            //--------------------------------------
            this.display_lbe.Text = "";
        }

        private void divide_btn_Click(object sender, EventArgs e)
        {
            double n1, n2, r;
            r = 0;

            double.TryParse(this.display2_lbe.Text, out n1);
            double.TryParse(this.display_lbe.Text, out n2);

            this.display3_lbe.Text = "/";

            //--------------------------------------
            if (this.display_lbe.Text != "")
            {
                this.display2_lbe.Text = this.display_lbe.Text;

                if (this.display_lbe.Text != "")
                {
                    if (n2 != 0 && n1 != 0)
                    {
                        r = n1 / n2;
                        this.display2_lbe.Text = r.ToString();
                    }
                }
            }
            //--------------------------------------
            this.display_lbe.Text = "";
        }

        private void equal_btn_Click(object sender, EventArgs e)
        {
            double num1, num2, result1;
            string operator_sign;


            //--------------------------------------
            double.TryParse(this.display2_lbe.Text, out num1);
            double.TryParse(this.display_lbe.Text, out num2);
            result1 = 0;
            operator_sign = this.display3_lbe.Text;
            //--------------------------------------

            if (operator_sign == "+")
            {
                result1 = num1 + num2;
            }
            //--------------------------------------
            if (operator_sign == "-")
            {
                result1 = num1 - num2;
            }
            //--------------------------------------
            if (operator_sign == "X")
            {
                result1 = num1 * num2;
            }
            //--------------------------------------
            if (operator_sign == "/")
            {
                result1 = num1 / num2;
            }
            //--------------------------------------

            this.display_lbe.Text = result1.ToString();
            this.display2_lbe.Text = "";
            this.display3_lbe.Text = "";
            new_calculation = true;

        }

        private void square_btn_Click(object sender, EventArgs e)
        {
            double n1, n2, r;
            r = 0;

            double.TryParse(this.display2_lbe.Text, out n1);
            double.TryParse(this.display_lbe.Text, out n2);

            if(this.display_lbe.Text != "")
            {
                r = Math.Sqrt(n2);
            }
            else if(this.display2_lbe.Text != "")
            {
                r = Math.Sqrt(n1);
            }

            this.display_lbe.Text = r.ToString();
            this.display2_lbe.Text = "";
            this.display3_lbe.Text = "";
            new_calculation = true;
        }

        private void dot_btn_Click(object sender, EventArgs e)
        {
            string chk_display;
            chk_display = this.display_lbe.Text;

            //-------------------------------------
            if (new_calculation == true)
            {
                this.display_lbe.Text = "";
                new_calculation = false;
            }
            //-------------------------------------
            if(this.display_lbe.Text.Contains("."))
            {
                //Do nothing
            }
            else
            {
                if (chk_display == "0")
                {
                    this.display_lbe.Text = this.display_lbe.Text + ".";
                }
                else
                {
                    this.display_lbe.Text = this.display_lbe.Text + ".";
                }
            }
        }

        private void square_btn_Click_1(object sender, EventArgs e)
        {
            double n1, n2, r;
            r = 0;

            double.TryParse(this.display2_lbe.Text, out n1);
            double.TryParse(this.display_lbe.Text, out n2);

            if (this.display_lbe.Text != "")
            {
                r = Math.Pow(n2, 2);
            }
            else if (this.display2_lbe.Text != "")
            {
                r = Math.Pow(n1, 2);
            }

            this.display_lbe.Text = r.ToString();
            this.display2_lbe.Text = "";
            this.display3_lbe.Text = "";
            new_calculation = true;
        }
    }
}
