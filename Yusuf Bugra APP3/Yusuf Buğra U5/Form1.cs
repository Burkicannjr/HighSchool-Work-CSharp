namespace Yusuf_Buğra_U5
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

        private void button3_Click(object sender, EventArgs e)
        {
            decimal s1, s2, bol;
            s1 = Convert.ToDecimal(textBox1.Text);
            s2 = Convert.ToDecimal(textBox2.Text);
            bol = s1 / s2;
            label4.Text = bol.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1, s2, topla;
            s1 = Convert.ToInt16(textBox1.Text);
            s2 = Convert.ToInt16(textBox2.Text);
            topla = s1 - s2;
            label4.Text = topla.ToString();
        }
    }
}
