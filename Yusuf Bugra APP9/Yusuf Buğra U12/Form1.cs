namespace Yusuf_Buğra_U12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int merhaba;
            merhaba = Convert.ToInt32(textBox1.Text);
            if (merhaba < 0)
            { MessageBox.Show("Sınıfı Geçemiyorsunuz."); }
            else if (merhaba < 25)
            {
                MessageBox.Show("Notunuz 0");
            }
            else if (merhaba < 45)
            {
                MessageBox.Show("Notunuz 1");
            }
            else if (merhaba < 55)
            {
                MessageBox.Show("Notunuz 2");
            }
            else if (merhaba < 70)
            {
                MessageBox.Show("Notunuz 3");
            }
            else if (merhaba < 85)
            {
                MessageBox.Show("Notunuz 4");
            }
            else if (merhaba <= 100)
            {
                MessageBox.Show("Notunuz 5");
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }

                    
        }
    }
}
