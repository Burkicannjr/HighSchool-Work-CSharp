namespace Yusuf_Buğra_U8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal fiyat, sonuc;
            fiyat = Convert.ToDecimal(textBox1.Text);
            sonuc = fiyat - ((fiyat * 10) / 100);
            label2.Text = sonuc.ToString() + "TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal fiyat, sonuc;
            fiyat = Convert.ToDecimal(textBox1.Text);
            sonuc = fiyat - ((fiyat * 25) / 100);
            label3.Text = sonuc.ToString() + "TL";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal fiyat, sonuc;
            fiyat = Convert.ToDecimal(textBox1.Text);
            sonuc = fiyat - ((fiyat * 50) / 100);
            label2.Text = sonuc.ToString() + "TL";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal fiyat, sonuc;
            fiyat = Convert.ToDecimal(textBox1.Text);
            sonuc = fiyat - ((fiyat * 75) / 100);
            label2.Text = sonuc.ToString() + "TL";
        }
    }
}
