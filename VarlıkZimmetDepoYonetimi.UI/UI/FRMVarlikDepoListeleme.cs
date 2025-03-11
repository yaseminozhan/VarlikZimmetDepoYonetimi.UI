using Microsoft.EntityFrameworkCore;
using VarlıkZimmetDepoYonetimi.UI.BL_business_;
using VarlıkZimmetDepoYonetimi.UI.Entities;

namespace VarlıkZimmetDepoYonetimi.UI
{
    public partial class FRMVarlikDepoListeleme : Form
    {
        public MyDBContext _context;
        private readonly IVarlikYonetim _varlikYonetim;
        public FRMVarlikDepoListeleme(IVarlikYonetim varlikYonetim)
        {
            _varlikYonetim = varlikYonetim;
            InitializeComponent();
            this.Load += new EventHandler(FRMVarlikDepoListeleme_Load1); //form açıldığında FRMVarlikDepoListeleme_Load1 çalışması için. 
            _context = new MyDBContext();
            UrunleriListele();
        }

        /// <summary>
        /// form açıldığında ilk çalışacak metot budur.  form açıldığında ürünleri listele.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRMVarlikDepoListeleme_Load1(object? sender, EventArgs e)
        {
            UrunleriListele(); //veritabanındaki ürünleri data grid view de listeleyecek.
            DgvÜrünlerListesi.Refresh(); // DataGridView’i yenile
        }

        /// <summary>
        /// ürünleri listele metodunda ürünlere data gridde ulaşmayı sağlıyoruz.
        /// </summary>
        private void UrunleriListele()
        {
            var urunler = _varlikYonetim.GetAll(); //varlık yönetim üzerinden tüm ürünleri al .
            DgvÜrünlerListesi.DataSource = urunler; //data grid e bağla.
        }
      
        /// <summary>
        /// bir ürün ekleme formu oluşturdum o formda kullanıcıya barkodlu ürün mü barkodsuz ürün mü diye iki seçenek sunacağız ve hangisi seçilirse o forma gidilecek.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnYeniUrunEkle_Click(object sender, EventArgs e)
        {
            var urunEkleFormu = new FrmUrunEkleSecim();
            urunEkleFormu.ShowDialog(); //seçim formunu göster.
        }

       
    }
}
