using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VarlıkZimmetDepoYonetimi.UI.Entities;

namespace VarlıkZimmetDepoYonetimi.UI.BL_business_
{
    public class VarlikYonetim : IVarlikYonetim
    {
        private readonly MyDBContext _Context;
        public VarlikYonetim()
        {
            _Context = new MyDBContext();
        }
        /// <summary>
        /// Ürünler tablosuna yeni ürünler ekliyoruz. ardından kaydediyoruz.
        /// </summary>
        /// <param name="urun"></param>
        public void Add(Urun urun)
        {
            _Context.Urunler.Add(urun);
            _Context.SaveChanges();
        }
        /// <summary>
        /// ürün ıd ye göre ürünü buluyoruz. ardından silebilmek için remove edip değişiklikleri kaydediyoruz.
        /// </summary>
        /// <param name="urunId"></param>
        public void Delete(int urunId)
        {
            var urun = _Context.Urunler.FirstOrDefault(u => u.UrunId == urunId);
            if (urun != null)
            {
                _Context.Urunler.Remove(urun); //ürünleri sil
                _Context.SaveChanges(); //kaydet
            }
        }
        /// <summary>
        /// ürünler tablosundaki tüm verileri alıyoruz.
        /// </summary>
        /// <returns></returns>
        public List<Urun> GetAll()
        {
            var barkodluUrunler = (from u in _Context.BarkodluUrunler
                                   join z in _Context.Zimmetler on u.Id equals z.UrunId into zimmetJoin
                                   from zimmet in zimmetJoin.DefaultIfEmpty() // Eğer zimmeti yoksa NULL dönecek
                                   select new Urun
                                   {
                                       UrunId = u.Id,
                                       UrunAdi = u.UrunAdi,
                                       BarkodluMu = true,
                                       
                                       UrunGuncelFiyat = u.Fiyat,

                                       ZimmetBilgisi = zimmet != null ? zimmet.CalisanAdi : "Zimmetli Değil"
                                   }).ToList();

            var barkodsuzUrunler = (from u in _Context.BarkodsuzUrunler
                                    join z in _Context.Zimmetler on u.Id equals z.UrunId into zimmetJoin
                                    from zimmet in zimmetJoin.DefaultIfEmpty()
                                    select new Urun
                                    {
                                        UrunId = u.Id,
                                        UrunAdi = u.UrunAdi,
                                        BarkodluMu = false,

                                        UrunGuncelFiyat = u.Fiyat,

                                        ZimmetBilgisi = zimmet != null ? zimmet.CalisanAdi : "Zimmetli Değil"
                                    }).ToList();

            return barkodluUrunler.Concat(barkodsuzUrunler).ToList();
        }



        /// <summary>
        /// mevcut ürünü buluyoruz ve güncelleme işlemlerini yapıyoruz.
        /// </summary>
        /// <param name="urun"></param>
        /// burada yaptığım ekstra bir işlem daha oldu. ürünler tablosunda ürün adı kolonu yoktu sql serverde alter yaparak tabloyu oluşturdum ardından bu projeye scafold atarak gelmesini sağladım sonrasında da kullandım. 
        public void Update(Urun urun)
        {
            var MevcutUrunler = _Context.Urunler.Find(urun.UrunId); //1. mevcut ürünü bulduk ıd ile.
            //2. ürün bulunduysa eğer güncelleme yapılıyor.
            if (MevcutUrunler != null)
            {
                MevcutUrunler.UrunAdi = urun.UrunAdi; //yeni ürün adı.
                MevcutUrunler.UrunGuncelFiyat = urun.UrunGuncelFiyat;
                MevcutUrunler.Aciklama = urun.Aciklama;
                _Context.SaveChanges();

            }
        }
    }
}
