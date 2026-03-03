using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace Otel_otomasyonu_YusufBugra
{
    public partial class FormMusteriler : Form
    {
        public FormMusteriler()
        {
            InitializeComponent();
            VerileriListele();
        }
        MySqlConnection baglanti = new MySqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                string sorgu = "INSERT INTO musteriler (ad_soyad, telefon, email, oda_no, giris_tarihi, cikis_tarihi) VALUES (@adsoyad, @telefon, @email, @odano, @giris, @cikis)";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@adsoyad", txtAd.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@email", txtEposta.Text);
                komut.Parameters.AddWithValue("@odano", int.TryParse(txtOdaNo.Text, out int odaNo) ? odaNo : 0);
                komut.Parameters.AddWithValue("@giris", dateGiris.Value.ToString("yyyy-MM-dd"));
                komut.Parameters.AddWithValue("@cikis", dateCikis.Value.ToString("yyyy-MM-dd"));



                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                VerileriListele();
                MessageBox.Show("Müşteri Kaydı Eklendi.");
            }

        }

        void VerileriListele()
        {
            MySqlDataAdapter adaptermusteri = new MySqlDataAdapter("SELECT * FROM musteriler", baglanti);
            DataTable datamusteri = new DataTable();
            adaptermusteri.Fill(datamusteri);
            GridMusteriler.DataSource = datamusteri;


            GridMusteriler.Columns["ad_soyad"].HeaderText = "Ad Soyad";
            GridMusteriler.Columns["telefon"].HeaderText = "Telefon";
            GridMusteriler.Columns["email"].HeaderText = "E-Posta";
            GridMusteriler.Columns["oda_no"].HeaderText = "Oda No";
            GridMusteriler.Columns["giris_tarihi"].HeaderText = "Giriş Tarihi";
            GridMusteriler.Columns["cikis_tarihi"].HeaderText = "Çıkış Tarihi";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GridMusteriler.CurrentRow != null)
            {
                string? secilenID = GridMusteriler.CurrentRow.Cells["id"].Value.ToString();

                string sorgu = "DELETE FROM musteriler WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@id", secilenID);

                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();

                VerileriListele();
                MessageBox.Show("Müşteri Kaydı Silindi.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (GridMusteriler.CurrentRow != null)
            {
                int id = Convert.ToInt32(GridMusteriler.CurrentRow.Cells["id"].Value);
                string adsoyad = txtAd.Text;
                string telefon = txtTelefon.Text;
                string eposta = txtEposta.Text;
                string odano = txtOdaNo.Text;
                DateTime giristarihi = dateGiris.Value;
                DateTime cikistarihi = dateCikis.Value;

                string sorgu = "UPDATE musteriler SET ad_soyad=@adsoyad, telefon=@telefon, email=@email, oda_no=@odano, giris_tarihi=@giris, cikis_tarihi=@cikis WHERE id=@id";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@adsoyad", adsoyad);
                komut.Parameters.AddWithValue("@telefon", telefon);
                komut.Parameters.AddWithValue("@email", eposta);
                komut.Parameters.AddWithValue("@odano", odano);
                komut.Parameters.AddWithValue("@giris", giristarihi);
                komut.Parameters.AddWithValue("@cikis", cikistarihi);
                komut.Parameters.AddWithValue("@id", id);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Müşteri Güncellendi.");
                VerileriListele();


            }
        }

        private void FormMusteriler_Load(object sender, EventArgs e)
        {

        }
    }
}
