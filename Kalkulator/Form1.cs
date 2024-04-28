using System;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class kalkulator : Form
    {
        private float ans;
        private string last_char;
        private float number;
        private bool equals_clicked = false;
        private bool plus_clicked = false;
        private bool minus_clicked = false;
        private bool multiply_clicked = false;
        private bool divide_clicked = false;

        public kalkulator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        // button11 = n2 
        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "2";
            if (equals_clicked == true)
            {
                textBox1.Text = "";
                history.Text = "";
                equals_clicked = false;
            }
        }

        private void percent_Click(object sender, EventArgs e)
        {
            float percent;

            if (equals_clicked == true)
            {
                textBox1.Text = "";
                history.Text = "";
                equals_clicked = false;
            }

            if (textBox1.Text != "" && history.Text != "")
            {
                percent = Convert.ToInt32(textBox1.Text);
                percent = (ans * percent) / 100;
                ans += percent;
                textBox1.Text = Convert.ToString(0);
                history.Text += percent;

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Podaj liczbę");
            }

        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (equals_clicked == true)
            {
                textBox1.Text = "";
                history.Text = "";
                equals_clicked = false;
            }
            if (textBox1.Text.Length == 0)
            {
                return;
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void C_clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            if (equals_clicked == true)
            {
                textBox1.Text = "";
                history.Text = "";
                equals_clicked = false;
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (equals_clicked == true)
            {
                history.Text = textBox1.Text;
                textBox1.Text = "";
                equals_clicked = false;
            }
            if (textBox1.Text != "" && divide_clicked == false)
            {
                history.Text += textBox1.Text + " ÷ ";
                ans = float.Parse(textBox1.Text);

            }
            else
            {
                history.Text += textBox1.Text + " ÷ ";
            }
            calculations();
            divide_clicked = true;
            last_char = "/";
            textBox1.Text = "";
        }

        private void multiplie_Click(object sender, EventArgs e)
        {
            if (equals_clicked == true)
            {
                history.Text = textBox1.Text;
                textBox1.Text = "";
                equals_clicked = false;
            }

            if (textBox1.Text != "" && multiply_clicked == false)
            {
                history.Text += textBox1.Text + " × ";
                ans = float.Parse(textBox1.Text);

            }
            else
            {
                history.Text += textBox1.Text + " × ";
            }

            if (multiply_clicked == true)
            {
                number = float.Parse(textBox1.Text);
                ans *= number;
            }
            calculations();
            multiply_clicked = true;
            last_char = "x";
            textBox1.Text = "";
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (equals_clicked == true)
            {
                textBox1.Text = "";
                history.Text = "";
                equals_clicked = false;
            }
            this.textBox1.Text += "9";
        }

        private void n8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "8";
            if (equals_clicked == true)
            {
                textBox1.Text = "";
                history.Text = "";
                equals_clicked = false;
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "7";
            if (equals_clicked == true)
            {
                textBox1.Text = "";
                history.Text = "";
                equals_clicked = false;
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "4";
            if (equals_clicked == true)
            {
                textBox1.Text = "";
                history.Text = "";
                equals_clicked = false;
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "5";
            if (equals_clicked == true)
            {
                textBox1.Text = "";
                history.Text = "";
                equals_clicked = false;
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "6";
            if (equals_clicked == true)
            {
                textBox1.Text = "";
                history.Text = "";
                equals_clicked = false;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (equals_clicked == true)
            {
                history.Text = textBox1.Text;
                textBox1.Text = "";
                equals_clicked = false;
            }
            if (textBox1.Text != "" && minus_clicked == false)
            {
                history.Text += textBox1.Text + " - ";
                ans = float.Parse(textBox1.Text);

            }
            else
            {
                history.Text += textBox1.Text + " - ";
            }
            calculations();
            minus_clicked = true;
            last_char = "-";
            textBox1.Text = "";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (equals_clicked == true)
            {
                history.Text = textBox1.Text;
                textBox1.Text = "";
                equals_clicked = false;
            }

            if (textBox1.Text != "" && plus_clicked == false)
            {
                history.Text += textBox1.Text + " + ";
                ans = float.Parse(textBox1.Text);
            }
            else
            {
                history.Text += textBox1.Text + " + ";
            }
            calculations();
            plus_clicked = true;
            last_char = "+";
            textBox1.Text = "";
        }


        private void n3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "3";
            if (equals_clicked == true)
            {
                textBox1.Text = "";
                history.Text = "";
                equals_clicked = false;
            }
        }

        private void n1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "1";
            if (equals_clicked == true)
            {
                textBox1.Text = "";
                history.Text = "";
                equals_clicked = false;
            }
        }

        private void AC_clear_all_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.history.Text = "";
            if (equals_clicked == true)
            {
                textBox1.Text = "";
                history.Text = "";
                equals_clicked = false;
            }
            ans = 0;
        }

        private void n0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "0";
            if (equals_clicked == true)
            {
                textBox1.Text = "";
                history.Text = "";
                equals_clicked = false;
            }
        }


        private void equals_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                history.Text += textBox1.Text + " = ";
                number = float.Parse(textBox1.Text);

                if (last_char == "+")
                {
                    plus_clicked = false;
                }

                if (last_char == "-")
                {
                    minus_clicked = false;
                }

                if (last_char == "x")
                {
                    multiply_clicked = false;
                }

                if (last_char == "/")
                {
                    divide_clicked = false;
                }

                if (ans == 0)
                {
                    textBox1.Text = Convert.ToString(number);
                }
                else
                {
                    textBox1.Text = Convert.ToString(ans);
                }
                equals_clicked = true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Nie możesz tego zrobić!\nWprowadź najpierw liczby");
            }

            if (equals_clicked == true)
            {
                history.Text = textBox1.Text;
                textBox1.Text = "";
                equals_clicked = false;
            }

            number = 0;
            last_char = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!e.KeyChar.Equals((char)Keys.Back) && !e.KeyChar.Equals((char)Keys.Delete))
            {
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculations()
        {
            if (plus_clicked == true)
            {
                number = float.Parse(textBox1.Text);
                ans += number;
            }
            if (minus_clicked == true)
            {
                number = float.Parse(textBox1.Text);
                ans -= number;
            }
            if (multiply_clicked == true)
            {
                number = float.Parse(textBox1.Text);
                ans *= number;
            }
            if (divide_clicked == true)
            {
                number = float.Parse(textBox1.Text);
                ans /= number;
            }
        }
    }
}
