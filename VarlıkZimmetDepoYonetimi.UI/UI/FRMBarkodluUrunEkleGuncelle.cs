using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarlıkZimmetDepoYonetimi.UI.BL_business_;
using VarlıkZimmetDepoYonetimi.UI.Entities;

namespace VarlıkZimmetDepoYonetimi.UI
{

    public partial class FRMBarkodluUrunEkleGuncelle : Form
    {
        private MyDBContext _context;


        public FRMBarkodluUrunEkleGuncelle()
        {

            _context = new MyDBContext();
            InitializeComponent();
        }
        /// <summary>
        /// barkodlu ürün ekleme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEkle_Click(object sender, EventArgs e)
        {

            //bütün bilgilerin girildiğine dair validate 

            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text)) //ürün adı boş olamaz
            {
                MessageBox.Show("Lütfen ürün adını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKategori.Text)) //kategori boş olamaz
            {
                MessageBox.Show("Lütfen bir kategori girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //sadece string ifade girilir

            if (txtKategori.Text.Any(char.IsDigit)) // Eğer herhangi bir rakam varsa
            {
                MessageBox.Show("Kategori adı rakam içeremez! Lütfen sadece harf girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFiyat.Text) || !decimal.TryParse(txtFiyat.Text, out _)) //fiyat boş veya geçersiz olamaz
            {
                MessageBox.Show("Lütfen geçerli bir fiyat girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericAdet.Value <= 0) //0 girilemez
            {
                MessageBox.Show("Adet 0  olamaz, lütfen geçerli bir adet girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBarkodNo.Text)) //barkod no boş geçilemez
            {
                MessageBox.Show("Lütfen bir barkod numarası girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // barkod numarası aynı olamaz kontrolü.
            bool barkodVarMi = _context.BarkodluUrunler.Any(u => u.BarkodNo == txtBarkodNo.Text);

            if (barkodVarMi)
            {
                MessageBox.Show("Bu barkod numarası zaten kayıtlı! Lütfen farklı bir barkod girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ///tüm alanlar doluysa ekleme işlemi devam eder.

            BarkodluUrun yeniUrun = new BarkodluUrun() //kullanıcının girdiği bilgileri alıyoruz.
            {
                UrunAdi = txtUrunAdi.Text,
                Kategori = txtKategori.Text,
                Fiyat = Convert.ToDecimal(txtFiyat.Text),
                Adet = Convert.ToInt32(numericAdet.Value),
                BarkodNo = txtBarkodNo.Text,
            };
            //veritabanına ekleme işlemi.
            _context.BarkodluUrunler.Add(yeniUrun);
            _context.SaveChanges();
            MessageBox.Show("Barkodlu ürün eklendi.");
            UrunleriListele();

        }

        /// <summary>
        /// güncelle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvBarkodluUrunler.SelectedRows.Count == 0) //seçim yapmadan güncelleme yapılmaya çalışılınırsa hata  mesajı ver
            {
                MessageBox.Show("Lütfen güncellemek için bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenId = Convert.ToInt32(dgvBarkodluUrunler.SelectedRows[0].Cells["Id"].Value);
            var urun = _context.BarkodluUrunler.Find(secilenId);

            if (urun == null)
            {
                MessageBox.Show("Ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!string.IsNullOrWhiteSpace(txtUrunAdi.Text))
                urun.UrunAdi = txtUrunAdi.Text;

            if (!string.IsNullOrWhiteSpace(txtKategori.Text))
                urun.Kategori = txtKategori.Text;

            if (!string.IsNullOrWhiteSpace(txtFiyat.Text) && decimal.TryParse(txtFiyat.Text, out decimal fiyat))
                urun.Fiyat = fiyat;

            if (numericAdet.Value > 0) // Adet boş olamaz ama 0 girerse değişmesin
                urun.Adet = Convert.ToInt32(numericAdet.Value);

            if (!string.IsNullOrWhiteSpace(txtBarkodNo.Text))
                urun.BarkodNo = txtBarkodNo.Text;

            _context.SaveChanges();
            MessageBox.Show("Ürün başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UrunleriListele();
        }
        /// <summary>
        /// ürün silme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvBarkodluUrunler.SelectedRows.Count == 0) //seçim yapılmadan butona basıldığında hata mesajı versin.
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenId = Convert.ToInt32(dgvBarkodluUrunler.SelectedRows[0].Cells["Id"].Value);
            var urun = _context.BarkodluUrunler.Find(secilenId);

            if (urun == null)
            {
                MessageBox.Show("Seçilen ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //silme işlemi için onay alalım.

            DialogResult onay = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?", "Silme Onayı",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                _context.BarkodluUrunler.Remove(urun);
                _context.SaveChanges();
                MessageBox.Show("Barkodlu ürün başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UrunleriListele();
            }
        }


        /// <summary>
        /// listeyi form açıldığında direk getir.
        /// </summary>
        private void UrunleriListele()
        {
            dgvBarkodluUrunler.DataSource = _context.BarkodluUrunler.ToList();
        }

        private void FRMBarkodluUrunEkleGuncelle_Load(object sender, EventArgs e)
        {
            UrunleriListele();
        }

        /// <summary>
        /// seçim ekranına geri dönmek için. belki başka işlem yapılmak istenir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close(); // Mevcut formu gizle
            FrmUrunEkleSecim secimFormu = new FrmUrunEkleSecim(); // Seçim formunu oluştur
            secimFormu.ShowDialog(); // Seçim formunu aç
           
        }
    }
}
