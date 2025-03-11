using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlıkZimmetDepoYonetimi.UI.Entities
{
    public class BarkodsuzUrun
    {
        public int Id { get; set; } 
        public string UrunAdi { get; set; }
        public string Kategori { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }
    }
}
