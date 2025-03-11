using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("Yetki")]
public partial class Yetki
{
    [Key]
    [Column("YetkiID")]
    public int YetkiId { get; set; }

    [StringLength(50)]
    public string? YetkiAdi { get; set; }

    [InverseProperty("Yetki")]
    public virtual ICollection<SayfaYetki> SayfaYetkis { get; set; } = new List<SayfaYetki>();
}
