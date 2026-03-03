using MySql.Data.MySqlClient;
using System.Configuration;

namespace Otel_otomasyonu_YusufBugra
{
    public partial class Form1 : Form
    {
        MySqlConnection baglanti;
        public Form1()
        {
            InitializeComponent();
            baglanti = new MySqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        }

        private void btnOda_Click(object sender, EventArgs e)
        {
            FormOdalar oda = new FormOdalar();
            oda.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                MessageBox.Show("Baðlantý baþarýlý!");
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baðlantý hatasý: " + ex.Message);
            }
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            FormMusteriler musteri = new FormMusteriler();
            musteri.ShowDialog();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            FormPersonel personel = new FormPersonel();
            personel.ShowDialog();
        }
    }
}
