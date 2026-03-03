using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Configuration;

namespace Otel_otomasyonu_YusufBugra
{
    public partial class FormPersonel : Form
    {
        public FormPersonel()
        {
            InitializeComponent();
            PersonelListele();
        }
        MySqlConnection baglanti = new MySqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO personel (ad_soyad, konum, telefon, maas) VALUES (@ad, @konum, @tel, @maas)";
            MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@konum", txtKonum.Text);
            cmd.Parameters.AddWithValue("@tel", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@maas", txtMaas.Text);

            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Personel Eklendi.");
            PersonelListele();
        }

        void PersonelListele()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM personel", baglanti);
            DataTable personeldatatable = new DataTable();
            adapter.Fill(personeldatatable);
            gridPersonel.DataSource = personeldatatable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gridPersonel.CurrentRow != null)
            {
                int id = Convert.ToInt32(gridPersonel.CurrentRow.Cells["id"].Value);
                string sorgu = "DELETE FROM personel WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@id", id);

                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Personel Silindi.");
                PersonelListele();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (gridPersonel.CurrentRow == null || gridPersonel.CurrentRow.Cells["id"].Value == null)
            {
                MessageBox.Show("Lütfen güncellenecek satırı seçin.");
                return;
            }

            int id = Convert.ToInt32(gridPersonel.CurrentRow.Cells["id"].Value);
            List<string> setKisimlari = new List<string>();
            MySqlCommand komut = new MySqlCommand();
            komut.Parameters.AddWithValue("@id", id);

            if (!string.IsNullOrWhiteSpace(txtAdSoyad.Text))
            {
                setKisimlari.Add("ad_soyad = @ad");
                komut.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtKonum.Text))
            {
                setKisimlari.Add("konum = @konum");
                komut.Parameters.AddWithValue("@konum", txtKonum.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                setKisimlari.Add("telefon = @tel");
                komut.Parameters.AddWithValue("@tel", txtTelefon.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtMaas.Text))
            {
                if (int.TryParse(txtMaas.Text, out int maasDeger))
                {
                    setKisimlari.Add("maas = @maas");
                    komut.Parameters.AddWithValue("@maas", maasDeger);
                }
                else
                {
                    MessageBox.Show("Maaş alanı sadece sayı içermelidir.");
                    return;
                }
            }


            if (setKisimlari.Count == 0)
            {
                MessageBox.Show("Hiçbir alan doldurulmadı, güncellenecek veri yok.");
                return;
            }

            string sorgu = $"UPDATE personel SET {string.Join(", ", setKisimlari)} WHERE id = @id";
            komut.CommandText = sorgu;
            komut.Connection = baglanti;

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Personel bilgisi güncellendi.");
            PersonelListele();
        }

        private void FormPersonel_Load(object sender, EventArgs e)
        {

        }
    }
}

