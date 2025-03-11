using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("KayipCalinti")]
public partial class KayipCalinti
{
    [Key]
    [Column("KayipCalintiID")]
    public int KayipCalintiId { get; set; }

    [Column("UrunID")]
    public int? UrunId { get; set; }

    [StringLength(50)]
    public string? Aciklama { get; set; }

    public short? Tarih { get; set; }

    [ForeignKey("UrunId")]
    [InverseProperty("KayipCalintis")]
    public virtual Urun? Urun { get; set; }
}
