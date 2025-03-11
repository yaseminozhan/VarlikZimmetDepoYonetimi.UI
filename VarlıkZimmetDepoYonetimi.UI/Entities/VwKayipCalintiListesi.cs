using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Keyless]
public partial class VwKayipCalintiListesi
{
    [Column("KayipCalintiID")]
    public int KayipCalintiId { get; set; }

    [Column("UrunID")]
    public int? UrunId { get; set; }

    [StringLength(50)]
    public string? Aciklama { get; set; }

    public short? Tarih { get; set; }
}
