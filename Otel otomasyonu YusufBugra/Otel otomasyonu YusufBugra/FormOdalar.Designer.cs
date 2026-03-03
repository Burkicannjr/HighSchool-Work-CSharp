namespace Otel_otomasyonu_YusufBugra
{
    partial class FormOdalar
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
            GridOtel = new DataGridView();
            groupBox1 = new GroupBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            comboDurum = new ComboBox();
            txtOdaTur = new TextBox();
            txtOdaNo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)GridOtel).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GridOtel
            // 
            GridOtel.BackgroundColor = Color.Goldenrod;
            GridOtel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridOtel.Location = new Point(197, -2);
            GridOtel.Name = "GridOtel";
            GridOtel.RowHeadersWidth = 51;
            GridOtel.Size = new Size(605, 262);
            GridOtel.TabIndex = 0;
            GridOtel.CellContentClick += GridOtel_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Adsız_tasarım__2_;
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Controls.Add(comboDurum);
            groupBox1.Controls.Add(txtOdaTur);
            groupBox1.Controls.Add(txtOdaNo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(-1, 358);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(997, 220);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Goldenrod;
            btnGuncelle.Location = new Point(751, 102);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(166, 89);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Goldenrod;
            btnSil.Location = new Point(835, 7);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(166, 89);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Goldenrod;
            btnEkle.Location = new Point(663, 7);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(166, 89);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // comboDurum
            // 
            comboDurum.FormattingEnabled = true;
            comboDurum.Location = new Point(483, 93);
            comboDurum.Name = "comboDurum";
            comboDurum.Size = new Size(151, 28);
            comboDurum.TabIndex = 6;
            // 
            // txtOdaTur
            // 
            txtOdaTur.Location = new Point(281, 94);
            txtOdaTur.Name = "txtOdaTur";
            txtOdaTur.Size = new Size(125, 27);
            txtOdaTur.TabIndex = 4;
            // 
            // txtOdaNo
            // 
            txtOdaNo.Location = new Point(50, 94);
            txtOdaNo.Name = "txtOdaNo";
            txtOdaNo.Size = new Size(125, 27);
            txtOdaNo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Goldenrod;
            label3.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(486, 41);
            label3.Name = "label3";
            label3.Size = new Size(148, 26);
            label3.TabIndex = 2;
            label3.Text = "Oda Durumu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Goldenrod;
            label2.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(281, 41);
            label2.Name = "label2";
            label2.Size = new Size(117, 26);
            label2.TabIndex = 1;
            label2.Text = "Oda Türü:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Goldenrod;
            label1.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 41);
            label1.Name = "label1";
            label1.Size = new Size(98, 26);
            label1.TabIndex = 0;
            label1.Text = "Oda No:";
            // 
            // FormOdalar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.image;
            ClientSize = new Size(993, 579);
            Controls.Add(groupBox1);
            Controls.Add(GridOtel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormOdalar";
            Text = "FormOdalar";
            Load += FormOdalar_Load;
            ((System.ComponentModel.ISupportInitialize)GridOtel).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridOtel;
        private GroupBox groupBox1;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private ComboBox comboDurum;
        private TextBox txtOdaTur;
        private TextBox txtOdaNo;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}