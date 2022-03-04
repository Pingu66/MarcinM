namespace MarcinM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text=(float.Parse(textBox2.Text) *float.Parse(textBox2.Text) -4 * float.Parse(textBox1.Text) * float.Parse(textBox3.Text)).ToString();
            float delta = float.Parse(textBox4.Text);
            if (delta > 0)
            {
                textBox7.Text = "dodatnia";
            }else if (delta < 0)
            {
                textBox7.Text = "ujemna";
            }
            else if (delta == 0)
            {
                textBox7.Text = "zero";
            }
           textBox5.Text = (((float.Parse(textBox2.Text) * (-1)) + (float)Math.Sqrt(delta)) / 2 * float.Parse(textBox1.Text)).ToString();
           textBox6.Text = (((float.Parse(textBox2.Text) * (-1)) - (float)Math.Sqrt(delta)) / 2 * float.Parse(textBox1.Text)).ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}