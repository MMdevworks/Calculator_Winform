using System;

namespace Calculator_Winform
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        double result;
        char operation;
        bool finishEquation = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void SaveNum1()
        {
            this.num1 = double.Parse(txtOutputScreen.Text);
        }
        private void SaveNum2()
        {
            this.num2 = double.Parse(txtOutputScreen.Text);
        }
        private void HandleOperations(char op)
        {
            Math math = new Math();
            switch (op)
            {
                case '+':
                    // if num 2 is not = null
                    this.result = math.Add(this.num1, this.num2);
                    break;
                case '-':
                    this.result = math.Subtract(this.num1, this.num2);
                    break;
                case '*':
                    this.result = math.Multiply(this.num1, this.num2);
                    break;
                case '/':
                    //if(this.num2 != 0)
                        this.result = math.Divide(this.num1, this.num2);
                    //else
                    //    lblEquation.Text = "Cant divide by 0 :(";
                    break;
            }
            txtOutputScreen.Text = this.result.ToString();
            this.num1 = this.result;
        }

        // click event for buttons --*
        private void btnNum_Click(object btn, EventArgs e)
        {
            txtOutputScreen.Text += (btn as Button).Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutputScreen.Clear();
            lblEquation.Text = "0";
        }

        // set the operation and num1 based on operator char from operator buttons
        private void HandleOperator(char op)
        {
            this.operation = op;
            SaveNum1();
            txtOutputScreen.Clear();
            lblEquation.Text = this.num1.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            HandleOperator('+');
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            HandleOperator('-');
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            HandleOperator('*');
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            HandleOperator('/');
        }

        // on equals, save num2, clear screen and handle operations, show output to screen
        private void btnEquals_Click(object sender, EventArgs e)
        {
            SaveNum2();
            //txtOutputScreen.Clear();
            HandleOperations(this.operation);
            lblEquation.Text = $"{this.num1} {this.operation} {this.num2} =";
            finishEquation = true;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtOutputScreen.Text.Contains('.'))
            {
                txtOutputScreen.Text += ".";
            }
        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            if (!txtOutputScreen.Text.Contains('-'))
            {
                txtOutputScreen.Text = "-" + txtOutputScreen.Text;
            }
            else
            {
                txtOutputScreen.Text = txtOutputScreen.Text.Trim('-');
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtOutputScreen.Text.Length > 0)
            {
                txtOutputScreen.Text = txtOutputScreen.Text.Remove(txtOutputScreen.Text.Length - 1);
            }
        }
    }
}
