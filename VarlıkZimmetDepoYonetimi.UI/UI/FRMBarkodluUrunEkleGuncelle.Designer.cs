namespace VarlıkZimmetDepoYonetimi.UI
{
    partial class FRMBarkodluUrunEkleGuncelle
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
            label2 = new Label();
            txtFiyat = new TextBox();
            label3 = new Label();
            numericAdet = new NumericUpDown();
            label4 = new Label();
            txtBarkodNo = new TextBox();
            label5 = new Label();
            btnEkle = new Button();
            dgvBarkodluUrunler = new DataGridView();
            btnSil = new Button();
            btnGuncelle = new Button();
            label6 = new Label();
            txtKategori = new TextBox();
            btnGeriDon = new Button();
            ((System.ComponentModel.ISupportInitialize)numericAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBarkodluUrunler).BeginInit();
            SuspendLayout();
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(127, 40);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(332, 23);
            txtUrunAdi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(23, 43);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(23, 80);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Kategori";
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(127, 101);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(332, 23);
            txtFiyat.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(23, 109);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 1;
            label3.Text = "Fiyat";
            // 
            // numericAdet
            // 
            numericAdet.Location = new Point(127, 139);
            numericAdet.Name = "numericAdet";
            numericAdet.Size = new Size(332, 23);
            numericAdet.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(23, 141);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 1;
            label4.Text = "Adet";
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(127, 180);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(332, 23);
            txtBarkodNo.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(23, 180);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 1;
            label5.Text = "Barkod No";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.LightCoral;
            btnEkle.Location = new Point(540, 209);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 61);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvBarkodluUrunler
            // 
            dgvBarkodluUrunler.BackgroundColor = Color.Silver;
            dgvBarkodluUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarkodluUrunler.Location = new Point(12, 209);
            dgvBarkodluUrunler.Name = "dgvBarkodluUrunler";
            dgvBarkodluUrunler.Size = new Size(510, 229);
            dgvBarkodluUrunler.TabIndex = 5;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.LightCoral;
            btnSil.Location = new Point(540, 276);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 64);
            btnSil.TabIndex = 4;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.LightCoral;
            btnGuncelle.Location = new Point(540, 346);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 73);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.IndianRed;
            label6.Location = new Point(69, 9);
            label6.Name = "label6";
            label6.Size = new Size(347, 15);
            label6.TabIndex = 6;
            label6.Text = "<<<<<<<<<<<<BARKODLU ÜRÜNLER >>>>>>>>>>>>>>>>";
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(127, 72);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(332, 23);
            txtKategori.TabIndex = 7;
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackColor = Color.CadetBlue;
            btnGeriDon.ForeColor = Color.Blue;
            btnGeriDon.Location = new Point(23, 455);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(488, 23);
            btnGeriDon.TabIndex = 8;
            btnGeriDon.Text = "seçim ekranı>>>>>>>>>>>>>>>>>>>>>>>>>>";
            btnGeriDon.UseVisualStyleBackColor = false;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // FRMBarkodluUrunEkleGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 490);
            Controls.Add(btnGeriDon);
            Controls.Add(txtKategori);
            Controls.Add(label6);
            Controls.Add(dgvBarkodluUrunler);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(numericAdet);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtFiyat);
            Controls.Add(label5);
            Controls.Add(txtBarkodNo);
            Controls.Add(label1);
            Controls.Add(txtUrunAdi);
            Name = "FRMBarkodluUrunEkleGuncelle";
            Text = "FRMBarkodluUrunEkleGuncelle";
            Load += FRMBarkodluUrunEkleGuncelle_Load;
            ((System.ComponentModel.ISupportInitialize)numericAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBarkodluUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrunAdi;
        private Label label1;
        private Label label2;
        private TextBox txtFiyat;
        private Label label3;
        private NumericUpDown numericAdet;
        private Label label4;
        private TextBox txtBarkodNo;
        private Label label5;
        private Button btnEkle;
        private DataGridView dgvBarkodluUrunler;
        private Button btnSil;
        private Button btnGuncelle;
        private Label label6;
        private TextBox txtKategori;
        private Button btnGeriDon;
    }
}