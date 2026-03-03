using System.Diagnostics.Eventing.Reader;

namespace Yusuf_Buğra
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

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked == true)
            {
                label4.Text = (a + b).ToString();
            }
            if (radioButton2.Checked == true)
            {
                label4.Text = (a - b).ToString();
            }
            if (radioButton3.Checked == true)
            {
                label4.Text = (a * b).ToString();
            }
            if (radioButton4.Checked == true)
            {
                label4.Text = (a / b).ToString();
            }
            if (radioButton5.Checked == true)
            {
                label4.Text = (a % b).ToString();
            }
            if (radioButton6.Checked == true)
            {
                MessageBox.Show("Anlamadım");
            }
            if (radioButton7.Checked == true)
            {
                MessageBox.Show("Anlamadım");
            }



        }
    }
}
