namespace VarlıkZimmetDepoYonetimi.UI
{
    partial class FRMZimmetAta
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
            label1 = new Label();
            txtAdSoyad = new TextBox();
            dgvZimmetler = new DataGridView();
            cmbEkip = new ComboBox();
            btnZimmetle = new Button();
            label2 = new Label();
            label3 = new Label();
            cmbUrunler = new ComboBox();
            label4 = new Label();
            btnGeriDon = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvZimmetler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(10, 41);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Ekip Adı";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(133, 74);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(323, 23);
            txtAdSoyad.TabIndex = 1;
            // 
            // dgvZimmetler
            // 
            dgvZimmetler.BackgroundColor = Color.Silver;
            dgvZimmetler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvZimmetler.Location = new Point(12, 193);
            dgvZimmetler.Name = "dgvZimmetler";
            dgvZimmetler.Size = new Size(505, 199);
            dgvZimmetler.TabIndex = 2;
            // 
            // cmbEkip
            // 
            cmbEkip.FormattingEnabled = true;
            cmbEkip.Location = new Point(133, 41);
            cmbEkip.Name = "cmbEkip";
            cmbEkip.Size = new Size(323, 23);
            cmbEkip.TabIndex = 3;
            // 
            // btnZimmetle
            // 
            btnZimmetle.BackColor = Color.LightCoral;
            btnZimmetle.Location = new Point(442, 135);
            btnZimmetle.Name = "btnZimmetle";
            btnZimmetle.Size = new Size(75, 52);
            btnZimmetle.TabIndex = 4;
            btnZimmetle.Text = "ZİMMETLE";
            btnZimmetle.UseVisualStyleBackColor = false;
            btnZimmetle.Click += btnZimmetle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.IndianRed;
            label2.Location = new Point(91, 9);
            label2.Name = "label2";
            label2.Size = new Size(330, 15);
            label2.TabIndex = 0;
            label2.Text = ">>>>>>>>>>>>>>>ZİMMET ATA<<<<<<<<<<<<<<<<<";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(10, 106);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 0;
            label3.Text = "Ürünler";
            // 
            // cmbUrunler
            // 
            cmbUrunler.FormattingEnabled = true;
            cmbUrunler.Location = new Point(133, 106);
            cmbUrunler.Name = "cmbUrunler";
            cmbUrunler.Size = new Size(323, 23);
            cmbUrunler.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(10, 74);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 0;
            label4.Text = "Çalışan Ad Soyad";
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackColor = Color.CadetBlue;
            btnGeriDon.ForeColor = Color.Blue;
            btnGeriDon.Location = new Point(33, 415);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(468, 23);
            btnGeriDon.TabIndex = 5;
            btnGeriDon.Text = "seçim ekranı >>>>>>>>>>>>>>>>>>>>>>";
            btnGeriDon.UseVisualStyleBackColor = false;
            // 
            // FRMZimmetAta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 450);
            Controls.Add(btnGeriDon);
            Controls.Add(btnZimmetle);
            Controls.Add(cmbUrunler);
            Controls.Add(cmbEkip);
            Controls.Add(dgvZimmetler);
            Controls.Add(txtAdSoyad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMZimmetAta";
            Text = "FRMZimmetAta";
            Load += FRMZimmetAta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvZimmetler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAdSoyad;
        private DataGridView dgvZimmetler;
        private ComboBox cmbEkip;
        private Button btnZimmetle;
        private Label label2;
        private Label label3;
        private ComboBox cmbUrunler;
        private Label label4;
        private Button btnGeriDon;
    }
}