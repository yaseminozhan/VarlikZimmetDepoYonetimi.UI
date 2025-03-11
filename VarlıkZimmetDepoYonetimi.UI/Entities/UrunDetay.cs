using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("UrunDetay")]
public partial class UrunDetay
{
    [Key]
    [Column("UrunDetayID")]
    public int UrunDetayId { get; set; }

    [Column("UrunID")]
    public int? UrunId { get; set; }

    public short? Miktar { get; set; }

    [ForeignKey("UrunId")]
    [InverseProperty("UrunDetays")]
    public virtual Urun? Urun { get; set; }
}
