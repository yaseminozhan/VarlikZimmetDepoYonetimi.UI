using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[PrimaryKey("SayfaId", "YetkiId", "RolId")]
[Table("SayfaYetki")]
public partial class SayfaYetki
{
    [Key]
    [Column("SayfaID")]
    public int SayfaId { get; set; }

    [Key]
    [Column("YetkiID")]
    public int YetkiId { get; set; }

    [Key]
    [Column("RolID")]
    public int RolId { get; set; }

    [ForeignKey("RolId")]
    [InverseProperty("SayfaYetkis")]
    public virtual Rol Rol { get; set; } = null!;

    [ForeignKey("SayfaId")]
    [InverseProperty("SayfaYetkis")]
    public virtual Sayfa Sayfa { get; set; } = null!;

    [ForeignKey("YetkiId")]
    [InverseProperty("SayfaYetkis")]
    public virtual Yetki Yetki { get; set; } = null!;
}
