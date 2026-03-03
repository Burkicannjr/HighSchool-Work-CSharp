namespace Otel_otomasyonu_YusufBugra
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnPersonel = new Button();
            btnMusteri = new Button();
            btnOda = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Adsız_tasarım__2_;
            groupBox1.Controls.Add(btnPersonel);
            groupBox1.Controls.Add(btnMusteri);
            groupBox1.Controls.Add(btnOda);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = SystemColors.ButtonShadow;
            groupBox1.Location = new Point(-2, 359);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1004, 237);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnPersonel
            // 
            btnPersonel.BackColor = Color.Goldenrod;
            btnPersonel.Font = new Font("Bahnschrift Condensed", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPersonel.ForeColor = SystemColors.ActiveCaptionText;
            btnPersonel.Location = new Point(717, 36);
            btnPersonel.Name = "btnPersonel";
            btnPersonel.Size = new Size(259, 186);
            btnPersonel.TabIndex = 2;
            btnPersonel.Text = "Personeller";
            btnPersonel.UseVisualStyleBackColor = false;
            btnPersonel.Click += btnPersonel_Click;
            // 
            // btnMusteri
            // 
            btnMusteri.BackColor = Color.Goldenrod;
            btnMusteri.Font = new Font("Bahnschrift Condensed", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMusteri.ForeColor = SystemColors.ActiveCaptionText;
            btnMusteri.Location = new Point(366, 36);
            btnMusteri.Name = "btnMusteri";
            btnMusteri.Size = new Size(259, 186);
            btnMusteri.TabIndex = 1;
            btnMusteri.Text = "Müşteriler";
            btnMusteri.UseVisualStyleBackColor = false;
            btnMusteri.Click += btnMusteri_Click;
            // 
            // btnOda
            // 
            btnOda.BackColor = Color.Goldenrod;
            btnOda.Font = new Font("Bahnschrift Condensed", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOda.ForeColor = SystemColors.ActiveCaptionText;
            btnOda.Location = new Point(14, 36);
            btnOda.Name = "btnOda";
            btnOda.Size = new Size(259, 186);
            btnOda.TabIndex = 0;
            btnOda.Text = "Odalar";
            btnOda.UseVisualStyleBackColor = false;
            btnOda.Click += btnOda_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.image;
            ClientSize = new Size(1001, 589);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Yusuf Otel Paneli";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnPersonel;
        private Button btnMusteri;
        private Button btnOda;
    }
}
