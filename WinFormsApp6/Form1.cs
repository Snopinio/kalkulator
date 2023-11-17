namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        public Form1()
        {
            InitializeComponent();
        }



        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "2")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "3")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "4")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "5")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "6")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "7")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "8")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "9")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "*";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox1.Text);
            textBox1.Clear();
            operators = "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(textBox1.Text);
                    Result = valueFirst - valueSecond;
                    textBox1.Text = Result.ToString();
                    break;
                case "+":
                    valueSecond = decimal.Parse(textBox1.Text);
                    Result = valueFirst + valueSecond;
                    textBox1.Text = Result.ToString();
                    break;
                case "*":
                    valueSecond = decimal.Parse(textBox1.Text);
                    Result = valueFirst * valueSecond;
                    textBox1.Text = Result.ToString();
                    break;
                case "/":
                    valueSecond = decimal.Parse(textBox1.Text);
                    Result = valueFirst / valueSecond;
                    textBox1.Text = Result.ToString();
                    break;
            }
        }
    }
}