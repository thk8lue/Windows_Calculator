using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_calculator
{
    public partial class Form1 : Form
    {
        private double prevNum = 0;
        private string oprtr = null;
        private double currNum = 0;
        private double result = 0;
        private bool inputting = false;
        
        public void InputNum (int num)
        {
            if (inputting == false)
            {
                tbResult.Text = "";
                //입력이 시작되지 않았을 때는 0을 지우고 숫자를 입력
            }

            inputting = true;
            tbResult.Text += num.ToString();
            //result = double.Parse(tbResult.Text);
            
        }
        public void Calculate ()
        {
            switch (oprtr)
            {
                case "+":
                    result = prevNum + currNum;
                    tbResult.Text = result.ToString();
                    break;
                case "-":
                    result = prevNum - currNum;
                    tbResult.Text = result.ToString();
                    break;
                case "×":
                    result = prevNum * currNum;
                    tbResult.Text = result.ToString();
                    break;
                case "÷":
                    result = prevNum / currNum;
                    tbResult.Text = result.ToString();
                    break;
                default:
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            inputting = false;
            tbResult.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            inputting = false;
            tbProcess.Text = "";
            tbResult.Text = "0";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(inputting == false)
            {
                return;
            }
            if (tbResult.Text.Length == 1)
            {
                tbResult.Text = "0";
            }
            else
            {
                tbResult.Text = tbResult.Text.Substring(0, tbResult.Text.Length - 1);
            }
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            result = 1 / double.Parse(tbResult.Text);
            tbResult.Text = result.ToString();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            prevNum = double.Parse(tbResult.Text);
            currNum = double.Parse(tbResult.Text);
            oprtr = "×";
            Calculate();
            tbResult.Text = result.ToString();
            tbProcess.Text = "sqr( " + prevNum + " )";
            inputting = false;

        }

        private void btnRoot_Click(object sender, EventArgs e)
        {   
            currNum = double.Parse(tbResult.Text);
            result = Math.Sqrt(double.Parse(tbResult.Text));
            tbResult.Text = result.ToString();
            tbProcess.Text = "√( " + currNum + " )";
            inputting = false;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            prevNum = double.Parse(tbResult.Text);
            tbProcess.Text = prevNum.ToString() + " ÷ ";
            inputting = false;
            oprtr = "÷";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            prevNum = double.Parse(tbResult.Text);
            tbProcess.Text = prevNum.ToString() + " × ";
            inputting = false;
            oprtr = "×";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            prevNum = double.Parse(tbResult.Text);
            tbProcess.Text = prevNum.ToString() + " - ";
            inputting = false;
            oprtr = "-";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            
            prevNum = double.Parse(tbResult.Text);
            tbProcess.Text = prevNum.ToString()+ " + ";
            inputting = false;
            oprtr = "+";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            currNum = double.Parse(tbResult.Text);
            tbProcess.Text += currNum.ToString() + " = ";
            Calculate();
            tbResult.Text = result.ToString();
            inputting = false;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            prevNum = (-1);
            currNum = double.Parse(tbResult.Text);
            oprtr = "×";
            Calculate();
            tbResult.Text = result.ToString();
            tbProcess.Text = result.ToString();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            inputting = true;
            bool isDouble = tbResult.Text.Contains(".");
            if (!isDouble)
            {
                tbResult.Text += '.';
            }
            
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (double.Parse(tbResult.Text) != 0);
            {
                InputNum(0);
                //tbResult.Text += 0;
            }
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            InputNum(1);
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            InputNum(2);
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            InputNum(3);
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            InputNum(4);
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            InputNum(5);
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            InputNum(6);
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            InputNum(7);
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            InputNum(8);
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            InputNum(9);
        }
    }
}
