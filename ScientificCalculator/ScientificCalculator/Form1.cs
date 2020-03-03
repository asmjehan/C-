using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class Form1 : Form
    {

        double firstNumber;
        double secondNumber;
        double result;
        string opa = null;
        string s;
        
        double ans;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            Display.Text+="1";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            Display.Text += "2";
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            Display.Text += "3";
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            Display.Text += "4";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            Display.Text += "5";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            Display.Text += "6";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            Display.Text += "7";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            Display.Text += "8";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            Display.Text += "9";
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            Display.Text += "0";
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            Display.Text = null;
            result = 0;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
           
            firstNumber = Convert.ToDouble(Display.Text);
            Display.Text = null;
            opa = "+";
        }

        private void buttonMinas_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(Display.Text);
            Display.Text = null;
            opa = "-";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(Display.Text);
            Display.Text = null;
            opa = "X";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(Display.Text);
            Display.Text = null;
            opa = "/";
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            s = Display.Text;
            firstNumber = Convert.ToDouble(s);
            Display.Text =  s +"!";
            opa = "!";
        }

        private void buttonSqr_Click(object sender, EventArgs e)
        {
            s = Display.Text;
            firstNumber = Convert.ToDouble(s);
            Display.Text = null;
            opa = "^";
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            s = Display.Text;
            firstNumber = Convert.ToDouble(s);
            Display.Text = "√" + s ;
            opa = "√";
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            s = Display.Text;
            firstNumber = Convert.ToDouble(s);
            Display.Text = "Sin(" + s + ")";
            opa = "sin";
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            s = Display.Text;
            firstNumber = Convert.ToDouble(s);
            Display.Text = "Cos(" + s + ")";
            opa = "cos";
        }

        private void buttonTen_Click(object sender, EventArgs e)
        {
            s = Display.Text;
            firstNumber = Convert.ToDouble(s);
            Display.Text = "Tan(" + s + ")";
            opa = "ten";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {

            switch (opa)
            {
                case "+":
                    string sf = Convert.ToString(firstNumber);
                    string ss = Display.Text;
                    secondNumber =Convert.ToDouble(Display.Text);
                    result = firstNumber + secondNumber;
                    Display.Text = sf + "+" + ss+"="  + result.ToString();
                    break;
                case "-":
                    string mf = Convert.ToString(firstNumber);
                    string ms = Display.Text;
                    secondNumber = Convert.ToDouble(Display.Text);
                    result = firstNumber - secondNumber;
                    Display.Text =mf+"-"+ms+ "=" + result.ToString();
                    break;
                case "/":
                    string df = Convert.ToString(firstNumber);
                    string ds = Display.Text;
                    secondNumber = Convert.ToDouble(Display.Text);
                    result = firstNumber / secondNumber;
                    Display.Text =df+"/"+ds+ "=" + result.ToString();
                    break;
                case "X":
                    string muf = Convert.ToString(firstNumber);
                    string mus = Display.Text;
                    secondNumber = Convert.ToDouble(Display.Text);
                    result = firstNumber * secondNumber;
                    Display.Text =muf+"X"+mus+ "=" + result.ToString();
                    break;
                case "sin":
                    string sins = Display.Text;
                    result = Math.Sin(firstNumber);
                    Display.Text =sins+ "=" + result.ToString();
                    break;
                case "cos":
                    string coss = Display.Text;
                    result = Math.Cos(firstNumber);
                    Display.Text =coss+ "=" + result.ToString();
                    break;
                case "ten":
                    string tens = Display.Text;
                    result = Math.Tan(firstNumber);
                    Display.Text =tens+ "=" + result.ToString();
                    break;
                case "!":
                    string fes = Display.Text;
                    double factor = 1;
                    for (double i = firstNumber; i > 0;i-- )
                    {
                        factor = factor * i;
                        
                    }
                    result=factor;
                    
                    
                    Display.Text = fes+"=" + result.ToString();
                    break;
                case "^":
                    string fi = Convert.ToString(firstNumber);
                    string se = Display.Text;
                    secondNumber = Convert.ToDouble(se);
                    result = 1;

                    for (double i = secondNumber; i > 0; i--)
                    {

                        result = result * firstNumber;
                    }

                       
                    Display.Text =fi+"^"+se+ "=" + result.ToString();
                    break;
                case "√":
                    string sr = Convert.ToString(firstNumber);

                    result = Math.Sqrt(firstNumber);


                    Display.Text = "√" + sr +"=" + result.ToString();
                    break;
                   
            }
          ans = result;
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            string var;
            var = Display.Text;
            int n = var.Length;
            var = var.Substring(0, n - 1);
            Display.Text = var;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display.Text = Convert.ToString(ans);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BinaryButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                BinaryDisplay.Text += 1;
            }
            else
            {
                BinaryDisplay.Text += 0;
            }
            if (checkBox2.Checked == true)
            {
                BinaryDisplay.Text += 1;
            }
            else
            {
                BinaryDisplay.Text += 0;
            }
            if (checkBox3.Checked == true)
            {
                BinaryDisplay.Text += 1;
            }
            else
            {
                BinaryDisplay.Text += 0;
            }
            if (checkBox4.Checked == true)
            {
                BinaryDisplay.Text += 1;
            }
            else
            {
                BinaryDisplay.Text += 0;
            }
            if (checkBox5.Checked == true)
            {
                BinaryDisplay.Text += 1;
            }
            else
            {
                BinaryDisplay.Text += 0;
            }
            if (checkBox6.Checked == true)
            {
                BinaryDisplay.Text += 1;
            }
            else
            {
                BinaryDisplay.Text += 0;
            }
            if (checkBox7.Checked == true)
            {
                BinaryDisplay.Text += 1;
            }
            else
            {
                BinaryDisplay.Text += 0;
            }
            if (checkBox8.Checked == true)
            {
                BinaryDisplay.Text += 1;
            }
            else
            {
                BinaryDisplay.Text += 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str =  BinaryDisplay.Text;

            int dn = Convert.ToInt32(str,2);

            DecimalDisplay.Text = Convert.ToString(dn);
        }

        private void DecimalDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) {

                buttonSin.Hide();
                buttonCos.Hide();
                buttonTen.Hide();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            buttonSin.Show();
            buttonCos.Show();
            buttonTen.Show();
        }
    }
}
