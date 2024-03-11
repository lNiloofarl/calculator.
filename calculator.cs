namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        int num1;
        int num2;
        int result;
        string str;
        private void button10_Click(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            textBox1.Text += c.Text;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "+";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "-";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "*";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
            str = "/";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox1.Text);

            switch (str)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }
            textBox1.Text = result.ToString();
        }
    }
}