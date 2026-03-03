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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;


namespace Otel_otomasyonu_YusufBugra
{
    public partial class FormOdalar : Form
    {
        public FormOdalar()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        private void FormOdalar_Load(object sender, EventArgs e)
        {
            OdaListele();
            comboDurum.Items.Add("Boş");
            comboDurum.Items.Add("Dolu");
        }

        void OdaListele()
        {
            try
            {
                MySqlDataAdapter dataadapterotel = new MySqlDataAdapter("SELECT * FROM odalar", baglanti);
                DataTable datatableotel = new DataTable();
                dataadapterotel.Fill(datatableotel);
                GridOtel.DataSource = datatableotel;


                GridOtel.Columns["oda_no"].HeaderText = "Oda No";
                GridOtel.Columns["durum"].HeaderText = "Oda Durumu";
                GridOtel.Columns["oda_turu"].HeaderText = "Oda Türü";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string odaNo = txtOdaNo.Text;
            string odaTuru = txtOdaTur.Text;
            string? durum = comboDurum.SelectedItem.ToString();

            MySqlCommand komut = new MySqlCommand("INSERT INTO odalar (oda_no, oda_turu, durum) VALUES (@no, @oda, @durum)", baglanti);
            komut.Parameters.AddWithValue("@no", odaNo);
            komut.Parameters.AddWithValue("@oda", odaTuru);
            komut.Parameters.AddWithValue("@durum", durum);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Oda eklendi.");
            OdaListele();
        }

        private void GridOtel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (GridOtel.CurrentRow != null)
            {
                int id = Convert.ToInt32(GridOtel.CurrentRow.Cells["id"].Value);
                string odaNo = txtOdaNo.Text;
                string odaTuru = txtOdaTur.Text;
                string? durum = comboDurum.SelectedItem.ToString();

                MySqlCommand cmd = new MySqlCommand("UPDATE odalar SET oda_no=@no, oda_turu=@turu, durum=@durum WHERE id=@id", baglanti);
                cmd.Parameters.AddWithValue("@no", odaNo);
                cmd.Parameters.AddWithValue("@turu", odaTuru);
                cmd.Parameters.AddWithValue("@durum", durum);
                cmd.Parameters.AddWithValue("@id", id);

                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Oda güncellendi!");
                OdaListele();

            }
            else
            {
                MessageBox.Show("Oda Güncellenemedi.");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (GridOtel.CurrentRow != null)
            {
                int id = Convert.ToInt32(GridOtel.CurrentRow.Cells["id"].Value);

                MySqlCommand cmd = new MySqlCommand("DELETE FROM odalar WHERE id=@id", baglanti);
                cmd.Parameters.AddWithValue("@id", id);

                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Oda silindi.");
                OdaListele();
            }
        }
    }
}
