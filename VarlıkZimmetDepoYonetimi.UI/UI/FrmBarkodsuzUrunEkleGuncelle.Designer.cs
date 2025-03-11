namespace VarlıkZimmetDepoYonetimi.UI
{
    partial class FrmBarkodsuzUrunEkleGuncelle
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
            txtUrunAdi = new TextBox();
            label1 = new Label();
            dgvBarkodsuzUrunler = new DataGridView();
            btnEkle = new Button();
            numericAdet = new NumericUpDown();
            btnSil = new Button();
            btnGuncelle = new Button();
            label2 = new Label();
            txtFiyat = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtKategori = new TextBox();
            btnGeriDon = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBarkodsuzUrunler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAdet).BeginInit();
            SuspendLayout();
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(132, 36);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(260, 23);
            txtUrunAdi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(16, 36);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Ürün Adı";
            // 
            // dgvBarkodsuzUrunler
            // 
            dgvBarkodsuzUrunler.BackgroundColor = Color.Silver;
            dgvBarkodsuzUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarkodsuzUrunler.Location = new Point(12, 200);
            dgvBarkodsuzUrunler.Name = "dgvBarkodsuzUrunler";
            dgvBarkodsuzUrunler.Size = new Size(455, 249);
            dgvBarkodsuzUrunler.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.LightCoral;
            btnEkle.ForeColor = Color.Black;
            btnEkle.Location = new Point(473, 200);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 63);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // numericAdet
            // 
            numericAdet.Location = new Point(132, 162);
            numericAdet.Name = "numericAdet";
            numericAdet.Size = new Size(260, 23);
            numericAdet.TabIndex = 5;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.LightCoral;
            btnSil.Location = new Point(473, 288);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 65);
            btnSil.TabIndex = 4;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.LightCoral;
            btnGuncelle.Location = new Point(473, 376);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 62);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(16, 76);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Kategori";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(132, 120);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(260, 23);
            txtFiyat.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(18, 120);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 1;
            label3.Text = "Fiyat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(18, 162);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 1;
            label4.Text = "Adet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.IndianRed;
            label5.Location = new Point(63, 9);
            label5.Name = "label5";
            label5.Size = new Size(338, 15);
            label5.TabIndex = 6;
            label5.Text = "<<<<<<<<<<<<BARKODSUZ ÜRÜNLER >>>>>>>>>>>>>>";
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(132, 76);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(260, 23);
            txtKategori.TabIndex = 7;
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackColor = Color.CadetBlue;
            btnGeriDon.ForeColor = Color.Blue;
            btnGeriDon.Location = new Point(46, 457);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(392, 23);
            btnGeriDon.TabIndex = 8;
            btnGeriDon.Text = "Seçim ekranı >>>>>>>>>>>>";
            btnGeriDon.UseVisualStyleBackColor = false;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // FrmBarkodsuzUrunEkleGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 492);
            Controls.Add(btnGeriDon);
            Controls.Add(txtKategori);
            Controls.Add(label5);
            Controls.Add(numericAdet);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dgvBarkodsuzUrunler);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtFiyat);
            Controls.Add(txtUrunAdi);
            Name = "FrmBarkodsuzUrunEkleGuncelle";
            Text = "FrmBarkodsuzUrunEkleGuncelle";
            Load += FrmBarkodsuzUrunEkleGuncelle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBarkodsuzUrunler).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrunAdi;
        private Label label1;
        private DataGridView dgvBarkodsuzUrunler;
        private Button btnEkle;
        private NumericUpDown numericAdet;
        private Button btnSil;
        private Button btnGuncelle;
        private Label label2;
        private TextBox txtFiyat;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtKategori;
        private Button btnGeriDon;
    }
}