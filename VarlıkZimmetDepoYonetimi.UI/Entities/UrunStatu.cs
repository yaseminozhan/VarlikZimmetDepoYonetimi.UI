using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("UrunStatu")]
public partial class UrunStatu
{
    [Key]
    [Column("UrunStatuID")]
    public int UrunStatuId { get; set; }

    [Column("UrunID")]
    public int UrunId { get; set; }

    [Column("StatuID")]
    public int StatuId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Tarih { get; set; }

    [ForeignKey("StatuId")]
    [InverseProperty("UrunStatus")]
    public virtual Statu Statu { get; set; } = null!;

    [ForeignKey("UrunId")]
    [InverseProperty("UrunStatus")]
    public virtual Urun Urun { get; set; } = null!;
}
