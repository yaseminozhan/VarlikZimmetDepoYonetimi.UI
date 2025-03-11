using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("Zimmet")]
public partial class Zimmet
{
    [Key]
    [Column("ZimmetID")]
    public int ZimmetId { get; set; }

    [Column("UrunID")]
    public int? UrunId { get; set; }

    [Column("AtananCalisanID")]
    public int? AtananCalisanId { get; set; }

    [Column("AtayanCalisanID")]
    public int? AtayanCalisanId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ZimmetBaslangicTarihi { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ZimmetBitisTarihi { get; set; }

    [StringLength(50)]
    public string? Aciklama { get; set; }

    [ForeignKey("AtananCalisanId")]
    [InverseProperty("ZimmetAtananCalisans")]
    public virtual Calisan? AtananCalisan { get; set; }

    [ForeignKey("AtayanCalisanId")]
    [InverseProperty("ZimmetAtayanCalisans")]
    public virtual Calisan? AtayanCalisan { get; set; }

    [InverseProperty("Zimmet")]
    public virtual ICollection<MusteriZimmet> MusteriZimmets { get; set; } = new List<MusteriZimmet>();

    [ForeignKey("UrunId")]
    [InverseProperty("Zimmets")]
    public virtual Urun? Urun { get; set; }
    public string Ekip { get; set; }
    public string CalisanAdi { get; set; }  


}
