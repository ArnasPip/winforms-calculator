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
            if (isLocked == false)
            {
                if (resultOnScreen)
                {
                    userInput.Text = "0";
                    resultOnScreen = false;
                }
                else if (userInput.Text == "0")
                {
                    userInput.Text = "0";
                }
                else
                    userInput.Text += "0";
            }
        }

        private void numOne_Click(object sender, EventArgs e)
        {
            if (isLocked == false)
            {
                if (resultOnScreen)
                {
                    userInput.Text = "1";
                    resultOnScreen = false;
                }
                else
                    userInput.Text += "1";
            }
        }

        private void numTwo_Click(object sender, EventArgs e)
        {
            if (isLocked == false)
            {
                if (resultOnScreen)
                {
                    userInput.Text = "2";
                    resultOnScreen = false;
                }
                else
                    userInput.Text += "2";
            }
        }

        private void numThree_Click(object sender, EventArgs e)
        {
            if (isLocked == false)
            {
                if (resultOnScreen)
                {
                    userInput.Text = "3";
                    resultOnScreen = false;
                }
                else
                    userInput.Text += "3";
            }
        }

        private void numFour_Click(object sender, EventArgs e)
        {
            if (isLocked == false)
            {
                if (resultOnScreen)
                {
                    userInput.Text = "4";
                    resultOnScreen = false;
                }
                else
                    userInput.Text += "4";
            }
        }

        private void numFive_Click(object sender, EventArgs e)
        {
            if (isLocked == false)
            {
                if (resultOnScreen)
                {
                    userInput.Text = "5";
                    resultOnScreen = false;
                }
                else
                    userInput.Text += "5";
            }
        }

        private void numSix_Click(object sender, EventArgs e)
        {
            if (isLocked == false)
            {
                if (resultOnScreen)
                {
                    userInput.Text = "6";
                    resultOnScreen = false;
                }
                else
                    userInput.Text += "6";
            }
        }

        private void numSeven_Click(object sender, EventArgs e)
        {
            if (isLocked == false)
            {
                if (resultOnScreen)
                {
                    userInput.Text = "7";
                    resultOnScreen = false;
                }
                else
                    userInput.Text += "7";
            }
        }

        private void numEight_Click(object sender, EventArgs e)
        {
            if (isLocked == false)
            {
                if (resultOnScreen)
                {
                    userInput.Text = "8";
                    resultOnScreen = false;
                }
                else
                    userInput.Text += "8";
            }
        }

        private void numNine_Click(object sender, EventArgs e)
        {
            if (isLocked == false)
            {
                if (resultOnScreen)
                {
                    userInput.Text = "9";
                    resultOnScreen = false;
                }
                else
                    userInput.Text += "9";
            }
        }

        private void funcNegate_Click(object sender, EventArgs e)
        {
            if (isLocked == false)
            {
                if (!resultOnScreen)
                {
                    if (userInput.Text.StartsWith('-'))
                    {
                        userInput.Text = userInput.Text.Substring(1);
                    }
                    else
                    {
                        userInput.Text = "-" + userInput.Text;
                    }
                }
                else if(userInput.Text=="")
                {
                    userInput.Text = "-";
                }
                else
                {
                    result *= -1;
                    userInput.Text = Convert.ToString(result);
                }
            }
        }

        private void numDot_Click(object sender, EventArgs e)
        {
            if (isLocked == false)
            {
                if (userInput.Text == "")
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
            if (isLocked == false)
            {
                if (userInput.Text != "")
                {
                    first = double.Parse(userInput.Text);
                    userInput.Text = "";
                    Function = '*';
                    resultOnScreen = false;
                }
                else
                {
                    Function = '*';
                }
            }
        }

        private void funcDivide_Click(object sender, EventArgs e)
        {
            if (isLocked == false)
            {
                if (userInput.Text != "")
                {
                    first = double.Parse(userInput.Text);
                    userInput.Text = "";
                    Function = '/';
                    resultOnScreen = false;
                }
                else
                {
                    Function = '/';
                }
            }
        }

        private void funcPlus_Click(object sender, EventArgs e)
        {
            if (isLocked == false)
            {
                if (userInput.Text != "")
                {
                    first = double.Parse(userInput.Text);
                    userInput.Text = "";
                    Function = '+';
                    resultOnScreen = false;
                }
                else
                {
                    Function = '+';
                }
            }
        }

        private void funcMinus_Click(object sender, EventArgs e)
        {
            if (isLocked == false)
            {
                if (userInput.Text != "")
                {
                    first = double.Parse(userInput.Text);
                    userInput.Text = "";
                    Function = '-';
                    resultOnScreen = false;
                }
                else
                {
                    Function = '-';
                }
            }
        }

        private void funcEquals_Click(object sender, EventArgs e)
        {
            if (isLocked == false)
            {
                if (resultOnScreen)
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
                else
                {
                    result = first;
                    resultOnScreen = true;
                    userInput.Text = Convert.ToString(result);
                }
                if (double.IsInfinity(result))
                {
                    isLocked = true;
                }
            }
        }
    }
}