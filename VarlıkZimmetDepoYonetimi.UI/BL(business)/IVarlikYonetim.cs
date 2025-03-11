using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarlıkZimmetDepoYonetimi.UI.Entities;

namespace VarlıkZimmetDepoYonetimi.UI.BL_business_
{
    /// <summary>
    ///interface veritabanı işlemlerini yönetecek ve DataAccess katmanıyla iletişim kuracak. o nedenle ekleme güncelleme silme ve listeleme işlemlerini yapıyoruz ardından VarlikYonetim Sınıfında bunları implement edeceğiz.
    /// </summary>
    public interface IVarlikYonetim
    {
        void Add(Urun urun);
        void Delete(int urunId);
        void Update(Urun urun);
        List<Urun> GetAll();
    }
}
