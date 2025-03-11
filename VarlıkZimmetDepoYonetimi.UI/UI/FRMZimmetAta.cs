using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using VarlıkZimmetDepoYonetimi.UI.Entities;

namespace VarlıkZimmetDepoYonetimi.UI
{

    public partial class FRMZimmetAta : Form
    {
        private MyDBContext _context;
        public FRMZimmetAta()
        {
            _context = new MyDBContext();
            InitializeComponent();
        }
        /// <summary>
        /// ekipleri oluşturup veritabanından ürünleri seçiyoruz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRMZimmetAta_Load(object sender, EventArgs e)
        {

            cmbEkip.Items.Clear();
            cmbEkip.Items.Add("IT Ekibi");
            cmbEkip.Items.Add("Satış Ekibi");
            cmbEkip.Items.Add("Lojistik Ekibi");
            cmbEkip.Items.Add("Muhasebe Ekibi");


            cmbUrunler.DataSource = _context.BarkodluUrunler.ToList();
            cmbUrunler.DisplayMember = "UrunAdi";
            cmbUrunler.ValueMember = "Id";


            ZimmetleriListele();
            btnGeriDon.Click += new EventHandler(btnGeriDon_Click);
        }

        private void btnZimmetle_Click(object sender, EventArgs e)
        {
            if (cmbEkip.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ekip seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text))
            {
                MessageBox.Show("Lütfen çalışan adını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbUrunler.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenUrunId = Convert.ToInt32(cmbUrunler.SelectedValue);




            //ürün zaten zimmetli mi

            bool urunZatenZimmetli = _context.Zimmetler.Any(z => z.UrunId == secilenUrunId && z.ZimmetBitisTarihi == null);

            if (urunZatenZimmetli)
            {
                MessageBox.Show("Bu ürün zimmetlenmiş! Başka bir ürün seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //yeni zimmet kaydı oluşturma 

            Zimmet yeniZimmet = new Zimmet()
            {
                Ekip = cmbEkip.SelectedItem.ToString(),
                CalisanAdi = txtAdSoyad.Text,
                UrunId = secilenUrunId,
                ZimmetBaslangicTarihi = DateTime.Now,
                ZimmetBitisTarihi = null
            };

            _context.Zimmetler.Add(yeniZimmet);
            _context.SaveChanges();
            MessageBox.Show("Ürün başarıyla zimmetlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ZimmetleriListele();
        }
        /// <summary>
        ///barkodlu ve barkodsuz ürünleri alıyourz.
        /// </summary>
        private void ZimmetleriListele()
        {
            var urunler = (from u in _context.BarkodluUrunler
                           join z in _context.Zimmetler on u.Id equals z.UrunId into zimmetJoin
                           from zimmet in zimmetJoin.DefaultIfEmpty()
                           select new Urun
                           {
                               UrunId = u.Id,
                               UrunAdi = u.UrunAdi,
                               BarkodluMu = true,
                               UrunGuncelFiyat = u.Fiyat,

                           }).ToList();
            dgvZimmetler.DataSource = urunler;
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close(); 
            FrmUrunEkleSecim secimFormu = new FrmUrunEkleSecim(); 
            secimFormu.ShowDialog(); 
           
        }


    }
}
