namespace Yusuf_Buğra_U6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1;
            int sayi2;
            int toplam;
            sayi1 = 5;
            sayi2 = 20;
            toplam = sayi1 + sayi2;
            MessageBox.Show(toplam.ToString());
        }
    }
}
