using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool resulted;
        decimal num1 = -1, num2 = -1, dottimes = 1;
        bool _2mode = false,dotmode = false;
        private void GetNumber(Button btn)
        {
            if (resulted)
            {
                MessageBox.Show("Choose the calculation method", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            decimal im = decimal.Parse(btn.Text);
            if (num1 == -1)
            {
                if(dotmode) MessageBox.Show("You can't input a dot before the first number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dottimes = 1;
                num1 = im;
                textBox1.Text = num1.ToString();
                
            }
            else if (_2mode == false)
            {
                if (dotmode)
                {

                    num1 += im * 0.1m * dottimes;
                    dottimes/=10;
                    textBox1.Text = num1.ToString();
                }
                else
                {
                    dottimes = 1;
                    num1 *= 10;
                    num1 += im;
                    textBox1.Text = num1.ToString();
                }
                
            }
            else if (num2 == -1)
            {
                num2 = im;
                textBox1.Text = num2.ToString();
            }
            else
            {
                if (dotmode)
                {
                    num2 += im * 0.1m * dottimes;
                    dottimes/=10;
                    textBox1.Text = num2.ToString();
                }
                else
                {
                    dottimes = 1;
                    num2 *= 10;
                    num2 += im;
                    textBox1.Text = num2.ToString();
                }
            }
            
        }
        short calcmode = 0;
        private void exe()
        {
            decimal res;
            switch (calcmode)
            {
                case 1:
                    res = num1 + num2;
                    break;
                case 2:
                    res = num1 - num2;
                    break;
                case 3:
                    res = num1 * num2;
                    break;
                case 4:
                    if(num2 == 0)
                    {
                        MessageBox.Show("You can't divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }   
                    res = num1 / num2;
                    break;
                default:
                    MessageBox.Show("you need to choose calculator's mode");
                    return;
            }
            label1.Text = res.ToString();
            Debug.WriteLine(res.ToString());
            num1 = res;
            num2 = -1;
            _2mode = false;
            resulted = true;
            dotmode = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GetNumber((Button)sender);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GetNumber((Button)sender);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            GetNumber((Button)sender);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            GetNumber((Button)sender);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            GetNumber((Button)sender);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            GetNumber((Button)sender);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            GetNumber((Button)sender);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            GetNumber((Button)sender);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            GetNumber((Button)sender);
        }
        private void button0_Click(object sender, EventArgs e)
        {
            GetNumber((Button)sender);
        }
        
        private void MethodChooose(short i)
        {
            if (num1 == -1)
            {
                MessageBox.Show("You haven't input the first number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);//filed
            }
            else
            {
                calcmode = i;
                dottimes = 1;
                if (_2mode = true && num2 != -1)
                {
                    exe();
                }
                _2mode = true;
            }
            resulted = false;
            dotmode = false;
            dottimes = 1;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            MethodChooose(1);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            MethodChooose(2);
        }
        private void Mul_Click(object sender, EventArgs e)
        {
            MethodChooose(3);
        }
        private void Dev_Click(object sender, EventArgs e)
        {
            MethodChooose(4);
        }
        
        private void button12_Click(object sender, EventArgs e)
        {

            exe();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "Answer";
            num1 = -1;
            num2 = -1;
            _2mode = false;
            calcmode = 0;
            resulted = false;
            textBox1.Text = "";
            dottimes = 1;
        }
        
        private void dotclick(object sender, EventArgs e)
        {
            dotmode= true;
            textBox1.Text = textBox1.Text + ".";
        }

        
    }
}
