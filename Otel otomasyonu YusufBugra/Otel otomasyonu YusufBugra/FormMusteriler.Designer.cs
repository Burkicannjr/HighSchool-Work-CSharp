namespace Otel_otomasyonu_YusufBugra
{
    partial class FormMusteriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dateCikis = new DateTimePicker();
            dateGiris = new DateTimePicker();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnKaydet = new Button();
            txtCikTarih = new Label();
            txtOdaNo = new TextBox();
            txtEposta = new TextBox();
            txtTelefon = new TextBox();
            txtAd = new TextBox();
            txtGirTarih = new Label();
            label = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            GridMusteriler = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridMusteriler).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Adsız_tasarım__2_;
            groupBox1.Controls.Add(dateCikis);
            groupBox1.Controls.Add(dateGiris);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(txtCikTarih);
            groupBox1.Controls.Add(txtOdaNo);
            groupBox1.Controls.Add(txtEposta);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(txtGirTarih);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 361);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1021, 238);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // dateCikis
            // 
            dateCikis.Location = new Point(347, 164);
            dateCikis.Name = "dateCikis";
            dateCikis.Size = new Size(136, 27);
            dateCikis.TabIndex = 15;
            // 
            // dateGiris
            // 
            dateGiris.Location = new Point(175, 164);
            dateGiris.Name = "dateGiris";
            dateGiris.Size = new Size(135, 27);
            dateGiris.TabIndex = 2;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Goldenrod;
            btnGuncelle.Location = new Point(857, 23);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(158, 101);
            btnGuncelle.TabIndex = 14;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Goldenrod;
            btnSil.Location = new Point(697, 23);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(158, 101);
            btnSil.TabIndex = 13;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += button2_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Goldenrod;
            btnKaydet.Location = new Point(533, 23);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(158, 101);
            btnKaydet.TabIndex = 12;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += button1_Click;
            // 
            // txtCikTarih
            // 
            txtCikTarih.AutoSize = true;
            txtCikTarih.BackColor = Color.Goldenrod;
            txtCikTarih.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCikTarih.Location = new Point(347, 117);
            txtCikTarih.Name = "txtCikTarih";
            txtCikTarih.Size = new Size(137, 26);
            txtCikTarih.TabIndex = 10;
            txtCikTarih.Text = "Çıkış Tarihi:";
            // 
            // txtOdaNo
            // 
            txtOdaNo.Location = new Point(25, 166);
            txtOdaNo.Name = "txtOdaNo";
            txtOdaNo.Size = new Size(125, 27);
            txtOdaNo.TabIndex = 8;
            // 
            // txtEposta
            // 
            txtEposta.Location = new Point(319, 72);
            txtEposta.Name = "txtEposta";
            txtEposta.Size = new Size(125, 27);
            txtEposta.TabIndex = 7;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(175, 72);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 6;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(25, 72);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 5;
            // 
            // txtGirTarih
            // 
            txtGirTarih.AutoSize = true;
            txtGirTarih.BackColor = Color.Goldenrod;
            txtGirTarih.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGirTarih.Location = new Point(175, 117);
            txtGirTarih.Name = "txtGirTarih";
            txtGirTarih.Size = new Size(138, 26);
            txtGirTarih.TabIndex = 4;
            txtGirTarih.Text = "Giriş Tarihi:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Goldenrod;
            label.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(40, 117);
            label.Name = "label";
            label.Size = new Size(98, 26);
            label.TabIndex = 3;
            label.Text = "Oda No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Goldenrod;
            label3.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(347, 23);
            label3.Name = "label3";
            label3.Size = new Size(89, 26);
            label3.TabIndex = 2;
            label3.Text = "Eposta:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Goldenrod;
            label2.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(201, 23);
            label2.Name = "label2";
            label2.Size = new Size(95, 26);
            label2.TabIndex = 1;
            label2.Text = "Telefon:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Goldenrod;
            label1.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(40, 23);
            label1.Name = "label1";
            label1.Size = new Size(118, 26);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad:";
            // 
            // GridMusteriler
            // 
            GridMusteriler.BackgroundColor = Color.Goldenrod;
            GridMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridMusteriler.Location = new Point(1, -3);
            GridMusteriler.Name = "GridMusteriler";
            GridMusteriler.RowHeadersWidth = 51;
            GridMusteriler.Size = new Size(1021, 247);
            GridMusteriler.TabIndex = 1;
            // 
            // FormMusteriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.image;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1023, 600);
            Controls.Add(GridMusteriler);
            Controls.Add(groupBox1);
            Name = "FormMusteriler";
            Text = "FormMusteriler";
            Load += FormMusteriler_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridMusteriler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtOdaNo;
        private TextBox txtEposta;
        private TextBox txtTelefon;
        private TextBox txtAd;
        private Label txtGirTarih;
        private Label label;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label txtCikTarih;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnKaydet;
        private DataGridView GridMusteriler;
        private DateTimePicker dateGiris;
        private DateTimePicker dateCikis;
    }
}