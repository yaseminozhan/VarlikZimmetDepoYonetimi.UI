namespace VarlıkZimmetDepoYonetimi.UI
{
    partial class FRMVarlikDepoListeleme
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
            DgvÜrünlerListesi = new DataGridView();
            BtnYeniUrunEkle = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvÜrünlerListesi).BeginInit();
            SuspendLayout();
            // 
            // DgvÜrünlerListesi
            // 
            DgvÜrünlerListesi.BackgroundColor = Color.FromArgb(192, 192, 255);
            DgvÜrünlerListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvÜrünlerListesi.Location = new Point(12, 35);
            DgvÜrünlerListesi.Name = "DgvÜrünlerListesi";
            DgvÜrünlerListesi.Size = new Size(587, 299);
            DgvÜrünlerListesi.TabIndex = 0;
            // 
            // BtnYeniUrunEkle
            // 
            BtnYeniUrunEkle.BackColor = Color.FromArgb(0, 192, 192);
            BtnYeniUrunEkle.Location = new Point(-5, 352);
            BtnYeniUrunEkle.Name = "BtnYeniUrunEkle";
            BtnYeniUrunEkle.Size = new Size(635, 23);
            BtnYeniUrunEkle.TabIndex = 3;
            BtnYeniUrunEkle.Text = ">>>>>>>> YENİ BİLGİ EKLE >>>>>>>>";
            BtnYeniUrunEkle.UseVisualStyleBackColor = false;
            BtnYeniUrunEkle.Click += BtnYeniUrunEkle_Click;
            // 
            // label1
            // 
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(119, 9);
            label1.Name = "label1";
            label1.Size = new Size(511, 23);
            label1.TabIndex = 4;
            label1.Text = "<<<<<<<<<<<<<<<<<<<<BİLGİLER>>>>>>>>>>>>>>>>\r\n";
            // 
            // FRMVarlikDepoListeleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 402);
            Controls.Add(label1);
            Controls.Add(BtnYeniUrunEkle);
            Controls.Add(DgvÜrünlerListesi);
            Name = "FRMVarlikDepoListeleme";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DgvÜrünlerListesi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvÜrünlerListesi;
        private Button BtnYeniUrunEkle;
        private Label label1;
    }
}
