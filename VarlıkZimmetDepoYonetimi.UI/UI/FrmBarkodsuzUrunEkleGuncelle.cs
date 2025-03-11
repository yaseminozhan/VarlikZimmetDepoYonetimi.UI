using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarlıkZimmetDepoYonetimi.UI.Entities;

namespace VarlıkZimmetDepoYonetimi.UI
{
    public partial class FrmBarkodsuzUrunEkleGuncelle : Form
    {
        private MyDBContext _context;
        public FrmBarkodsuzUrunEkleGuncelle()
        {
            _context = new MyDBContext();
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //validasyon 

            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text))
            {
                MessageBox.Show("Lütfen ürün adını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKategori.Text))
            {
                MessageBox.Show("Lütfen bir kategori girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtKategori.Text.Any(char.IsDigit)) // Eğer kategori içinde rakam varsa
            {
                MessageBox.Show("Kategori adı rakam içeremez! Lütfen sadece harf girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFiyat.Text) || !decimal.TryParse(txtFiyat.Text, out _))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericAdet.Value <= 0)
            {
                MessageBox.Show("Adet 0 veya negatif olamaz, lütfen geçerli bir adet girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //validasyon tamamlanınca ürün ekleme bölümü 

            BarkodsuzUrun yeniUrun = new BarkodsuzUrun()
            {
                UrunAdi = txtUrunAdi.Text,
                Kategori = txtKategori.Text,
                Fiyat = Convert.ToDecimal(txtFiyat.Text),
                Adet = Convert.ToInt32(numericAdet.Value),
            };

            _context.BarkodsuzUrunler.Add(yeniUrun);
            _context.SaveChanges();
            MessageBox.Show("Barkodsuz ürün başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UrunleriListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvBarkodsuzUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek için bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenId = Convert.ToInt32(dgvBarkodsuzUrunler.SelectedRows[0].Cells["Id"].Value);
            var urun = _context.BarkodsuzUrunler.Find(secilenId);

            if (urun == null)
            {
                MessageBox.Show("Ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kullanıcı hangi alanı değiştirdiyse onu güncelle

            if (!string.IsNullOrWhiteSpace(txtUrunAdi.Text))
                urun.UrunAdi = txtUrunAdi.Text;

            if (!string.IsNullOrWhiteSpace(txtKategori.Text))
                urun.Kategori = txtKategori.Text;

            if (!string.IsNullOrWhiteSpace(txtFiyat.Text) && decimal.TryParse(txtFiyat.Text, out decimal fiyat))
                urun.Fiyat = fiyat;

            if (numericAdet.Value > 0) // Adet boş olamaz ama 0 girerse değişmesin
                urun.Adet = Convert.ToInt32(numericAdet.Value);

            _context.SaveChanges();
            MessageBox.Show("Barkodsuz ürün başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UrunleriListele();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvBarkodsuzUrunler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenId = Convert.ToInt32(dgvBarkodsuzUrunler.SelectedRows[0].Cells["Id"].Value);
            var urun = _context.BarkodsuzUrunler.Find(secilenId);

            if (urun == null)
            {
                MessageBox.Show("Seçilen ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //onay alma 

            DialogResult onay = MessageBox.Show("Bu barkodsuz ürünü silmek istediğinize emin misiniz?", "Silme Onayı",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                _context.BarkodsuzUrunler.Remove(urun);
                _context.SaveChanges();
                MessageBox.Show("Barkodsuz ürün başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UrunleriListele();
            }
        }
        private void UrunleriListele()
        {
            dgvBarkodsuzUrunler.DataSource = _context.BarkodsuzUrunler.ToList();
        }

        private void FrmBarkodsuzUrunEkleGuncelle_Load(object sender, EventArgs e)
        {
            UrunleriListele();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close(); 
            FrmUrunEkleSecim secimFormu = new FrmUrunEkleSecim(); 
            secimFormu.ShowDialog(); 
           
        }
    }
}
