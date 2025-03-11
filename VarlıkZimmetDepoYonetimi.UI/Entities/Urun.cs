using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("Urun")]
public partial class Urun
{
    [Key]
    [Column("UrunID")]
    public int UrunId { get; set; }

    [Column("ModelID")]
    public int? ModelId { get; set; }

    public bool? GarantiliMi { get; set; }

    [Column(TypeName = "money")]
    public decimal? UrunMaliyeti { get; set; }

    [StringLength(50)]
    public string? Aciklama { get; set; }

    public bool? BarkodluMu { get; set; }

    [Column(TypeName = "money")]
    public decimal? UrunGuncelFiyat { get; set; }

    [StringLength(100)]
    public string? UrunAdi { get; set; }

    [InverseProperty("Urun")]
    public virtual ICollection<DepoUrun> DepoUruns { get; set; } = new List<DepoUrun>();

    [InverseProperty("Urun")]
    public virtual ICollection<KayipCalinti> KayipCalintis { get; set; } = new List<KayipCalinti>();

    [ForeignKey("ModelId")]
    [InverseProperty("Uruns")]
    public virtual Model? Model { get; set; }

    [InverseProperty("Urun")]
    public virtual ICollection<UrunBarkod> UrunBarkods { get; set; } = new List<UrunBarkod>();

    [InverseProperty("Urun")]
    public virtual ICollection<UrunDetay> UrunDetays { get; set; } = new List<UrunDetay>();

    [InverseProperty("Urun")]
    public virtual ICollection<UrunStatu> UrunStatus { get; set; } = new List<UrunStatu>();

    [InverseProperty("Urun")]
    public virtual ICollection<Zimmet> Zimmets { get; set; } = new List<Zimmet>();

    public string? ZimmetBilgisi { get; set; } // Zimmet bilgisi
}
