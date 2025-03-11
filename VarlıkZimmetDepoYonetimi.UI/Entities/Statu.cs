using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("Statu")]
public partial class Statu
{
    [Key]
    [Column("StatuID")]
    public int StatuId { get; set; }

    [StringLength(50)]
    public string? StatuAdi { get; set; }

    public bool? AktifMi { get; set; }

    [InverseProperty("Statu")]
    public virtual ICollection<UrunStatu> UrunStatus { get; set; } = new List<UrunStatu>();
}
