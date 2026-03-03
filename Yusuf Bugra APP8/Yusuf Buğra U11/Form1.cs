namespace Yusuf_Buğra_U11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yusuf;
            yusuf = textBox1.Text;
            if (yusuf == "YUSUFBUGRA")
            {
                MessageBox.Show("Kullanıcı Adı Sistemde Kayıtlıdır.");
                    }
            else {
                MessageBox.Show("Kullanıcı Adı Sistemde Kayıtlı Değildir.");
            }

        }
    }
}
