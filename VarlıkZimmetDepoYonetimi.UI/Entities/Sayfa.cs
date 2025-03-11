using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("Sayfa")]
public partial class Sayfa
{
    [Key]
    [Column("SayfaID")]
    public int SayfaId { get; set; }

    [StringLength(50)]
    public string? SayfaPath { get; set; }

    [InverseProperty("Sayfa")]
    public virtual ICollection<SayfaYetki> SayfaYetkis { get; set; } = new List<SayfaYetki>();
}
