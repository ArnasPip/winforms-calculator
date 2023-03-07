namespace Calculator
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }
        private void Calc_Load(object sender, EventArgs e)
        {
            userInput.Text = "";
        }
        public char Function = '0';
        public double first = 0.0;
        public double second = 0.0;
        public double result = 0.0;
        public bool resultOnScreen = false;
        public bool isLocked = false;
        private void numZero_Click(object sender, EventArgs e)
        {
            num_click("0");
        }
        private void numOne_Click(object sender, EventArgs e)
        {
            num_click("1");
        }
        private void numTwo_Click(object sender, EventArgs e)
        {
            num_click("2");
        }
        private void numThree_Click(object sender, EventArgs e)
        {
            num_click("3");
        }
        private void numFour_Click(object sender, EventArgs e)
        {
            num_click("4");
        }
        private void numFive_Click(object sender, EventArgs e)
        {
            num_click("5");
        }
        private void numSix_Click(object sender, EventArgs e)
        {
            num_click("6");
        }
        private void numSeven_Click(object sender, EventArgs e)
        {
            num_click("7");
        }
        private void numEight_Click(object sender, EventArgs e)
        {
            num_click("8");
        }
        private void numNine_Click(object sender, EventArgs e)
        {
            num_click("9");
        }
        private void funcNegate_Click(object sender, EventArgs e)
        {
            if (isLocked) return;
            if (!resultOnScreen && userInput.Text.StartsWith('-'))
            {
                userInput.Text = userInput.Text.Substring(1); 
            }
            else if (!resultOnScreen)
            {
                userInput.Text = "-" + userInput.Text;
            }
            else if (userInput.Text == "")
            {
                userInput.Text = "-";
            }
            else
            {
                result *= -1;
                userInput.Text = Convert.ToString(result);
            }
        }
        private void numDot_Click(object sender, EventArgs e)
        {
            num_click(",");
        }
        private void funcClear_Click(object sender, EventArgs e)
        {
            first = 0.0;
            second = 0.0;
            result = 0.0;
            userInput.Text = "";
            Function = '0';
            isLocked = false;
            resultOnScreen = false;
        }
        private void funcMultiply_Click(object sender, EventArgs e)
        {
            operation_click('*');
        }
        private void funcDivide_Click(object sender, EventArgs e)
        {
            operation_click('/');
        }
        private void funcPlus_Click(object sender, EventArgs e)
        {
            operation_click('+');
        }
        private void funcMinus_Click(object sender, EventArgs e)
        {
            operation_click('-');
        }
        private void funcEquals_Click(object sender, EventArgs e)
        {
            if (isLocked == true) return;
            else if (resultOnScreen)
            {
                switch (Function)
                {
                    case '*':
                        result = second * result;
                        break;
                    case '/':
                        result = result / second;
                        break;
                    case '+':
                        result = second + result;
                        break;
                    case '-':
                        result = result - second;
                        break;
                    case '0':
                        break;
                }
                first = result;
                resultOnScreen = true;
                userInput.Text = Convert.ToString(result);
            }
            else if (userInput.Text != "")
            {
                second = double.Parse(userInput.Text);
                switch (Function)
                {
                    case '*':
                        result = first * second;
                        break;
                    case '/':
                        result = first / second;
                        break;
                    case '+':
                        result = first + second;
                        break;
                    case '-':
                        result = first - second;
                        break;
                    case '0':
                        result = second;
                        break;
                }
                first = result;
                resultOnScreen = true;
                userInput.Text = Convert.ToString(result);
            }
            if (double.IsInfinity(result))
            {
                isLocked = true;
            }
        }
        private void num_click(string num)
        {

            if (isLocked) return;
            if (resultOnScreen && num != "0" && num != ",") 
            {
                userInput.Text = num;
                resultOnScreen = false;
                return;
            }
            else if (num != "0" && num != ",")
            {
                userInput.Text += num;
                return;
            }
            if (resultOnScreen && num == "0") 
            {
                userInput.Text = "0";
                resultOnScreen = false;
                return;
            }
            else if (userInput.Text == "0" && num == "0")
            {
                userInput.Text = "0";
                return;
            }
            else if (num == "0")
            {
                userInput.Text += "0";
                return;
            }
            if (userInput.Text == "" && num == ",")
            {
                userInput.Text = "0";
            }
            if (resultOnScreen)
            {
                userInput.Text = "0,";
                resultOnScreen = false;
            }
            else if (!userInput.Text.EndsWith(',') && !userInput.Text.Contains(','))
            {
                userInput.Text += ",";
            }
        }
        private void operation_click(char func)
        {
            if (isLocked) return;
            if (userInput.Text != "")
            {
                first = double.Parse(userInput.Text);
                userInput.Text = "";
                Function = func;
                resultOnScreen = false;
            }
            else
            {
                Function = func;

            }
        }
    }
}