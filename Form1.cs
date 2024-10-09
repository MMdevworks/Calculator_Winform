namespace Calculator_Winform
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        double result;

        char operation;

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
                    this.result = math.Add(this.num1, this.num2);
                    txtOutputScreen.Text = this.result.ToString();
                    break;
                case '-':
                    this.result = math.Subtract(this.num1, this.num2);
                    txtOutputScreen.Text = this.result.ToString();
                    break;
                case '*':
                    this.result = math.Multiply(this.num1, this.num2);
                    txtOutputScreen.Text = this.result.ToString();
                    break;
                case '/':
                    this.result = math.Divide(this.num1, this.num2);
                    txtOutputScreen.Text = this.result.ToString();
                    break;
            }
        }

        private void btnNum_Click(object btn, EventArgs e)
        {
            txtOutputScreen.Text += (btn as Button).Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutputScreen.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.operation = '+';
            SaveNum1();
            txtOutputScreen.Clear();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            this.operation = '-';
            SaveNum1();
            txtOutputScreen.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            this.operation = '*';
            SaveNum1();
            txtOutputScreen.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            this.operation = '/';
            SaveNum1();
            txtOutputScreen.Clear();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            SaveNum2();
            txtOutputScreen.Clear();
            HandleOperations(this.operation);
        }
    }
}
