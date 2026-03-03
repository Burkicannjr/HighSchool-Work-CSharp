namespace Otel_otomasyonu_YusufBugra
{
    partial class FormPersonel
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
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMaas = new TextBox();
            txtTelefon = new TextBox();
            txtKonum = new TextBox();
            txtAdSoyad = new TextBox();
            gridPersonel = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPersonel).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Adsız_tasarım__2_;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMaas);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(txtKonum);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Location = new Point(-2, 326);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1010, 243);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Goldenrod;
            button3.Location = new Point(728, 130);
            button3.Name = "button3";
            button3.Size = new Size(175, 96);
            button3.TabIndex = 11;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Goldenrod;
            button1.Location = new Point(813, 26);
            button1.Name = "button1";
            button1.Size = new Size(175, 96);
            button1.TabIndex = 10;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.Location = new Point(619, 26);
            button2.Name = "button2";
            button2.Size = new Size(175, 96);
            button2.TabIndex = 9;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Goldenrod;
            label4.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(262, 112);
            label4.Name = "label4";
            label4.Size = new Size(73, 26);
            label4.TabIndex = 7;
            label4.Text = "Maaş:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Goldenrod;
            label3.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 112);
            label3.Name = "label3";
            label3.Size = new Size(95, 26);
            label3.TabIndex = 6;
            label3.Text = "Telefon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Goldenrod;
            label2.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(262, 21);
            label2.Name = "label2";
            label2.Size = new Size(89, 26);
            label2.TabIndex = 5;
            label2.Text = "Konum:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Goldenrod;
            label1.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 21);
            label1.Name = "label1";
            label1.Size = new Size(118, 26);
            label1.TabIndex = 4;
            label1.Text = "Ad Soyad:";
            // 
            // txtMaas
            // 
            txtMaas.Location = new Point(235, 141);
            txtMaas.Name = "txtMaas";
            txtMaas.Size = new Size(140, 27);
            txtMaas.TabIndex = 3;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(33, 141);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(147, 27);
            txtTelefon.TabIndex = 2;
            // 
            // txtKonum
            // 
            txtKonum.Location = new Point(226, 50);
            txtKonum.Name = "txtKonum";
            txtKonum.Size = new Size(149, 27);
            txtKonum.TabIndex = 1;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(33, 50);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(147, 27);
            txtAdSoyad.TabIndex = 0;
            // 
            // gridPersonel
            // 
            gridPersonel.BackgroundColor = Color.Goldenrod;
            gridPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPersonel.Location = new Point(128, -2);
            gridPersonel.Name = "gridPersonel";
            gridPersonel.RowHeadersWidth = 51;
            gridPersonel.Size = new Size(716, 263);
            gridPersonel.TabIndex = 1;
            // 
            // FormPersonel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.image;
            ClientSize = new Size(998, 564);
            Controls.Add(gridPersonel);
            Controls.Add(groupBox1);
            Name = "FormPersonel";
            Text = "FormPersonel";
            Load += FormPersonel_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridPersonel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMaas;
        private TextBox txtTelefon;
        private TextBox txtKonum;
        private TextBox txtAdSoyad;
        private Button button3;
        private Button button1;
        private Button button2;
        private DataGridView gridPersonel;
    }
}