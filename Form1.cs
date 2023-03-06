namespace modul2_1302190044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void isiangka()
        {
            string angka1 = "1";
            string angka2 = "2";
            string angka3 = "3";
            string angka4 = "4";
            string angka5 = "5";
            string angka6 = "6";
            string angka7 = "7";
            string angka8 = "8";
            string angka9 = "9";
            string angka0 = "0";
        }
        private void btnangka1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) != 0)
            {
                textBox1.Text += "1";
            }
            else
            {
                textBox1.Text = "1";
            }

        }
        private void btnangka2_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) != 0)
            {
                textBox1.Text += "2";
            }
            else
            {
                textBox1.Text = "2";
            }
        }

        private void btnangka3_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) != 0)
            {
                textBox1.Text += "3";
            }
            else
            {
                textBox1.Text = "3";
            }
        }

        private void btnangka4_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) != 0)
            {
                textBox1.Text += "4";
            }
            else
            {
                textBox1.Text = "4";
            }
        }

        private void btnangka5_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) != 0)
            {
                textBox1.Text += "5";
            }
            else
            {
                textBox1.Text = "5";
            }
        }

        private void btnangka6_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) != 0)
            {
                textBox1.Text += "6";
            }
            else
            {
                textBox1.Text = "6";
            }
        }

        private void btnangka7_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) != 0)
            {
                textBox1.Text += "7";
            }
            else
            {
                textBox1.Text = "7";
            }
        }

        private void btnangka8_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) != 0)
            {
                textBox1.Text += "8";
            }
            else
            {
                textBox1.Text = "8";
            }
        }

        private void btnangka0_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) != 0)
            {
                textBox1.Text += "9";
            }
            else
            {
                textBox1.Text = "9";
            }
        }
    }
}