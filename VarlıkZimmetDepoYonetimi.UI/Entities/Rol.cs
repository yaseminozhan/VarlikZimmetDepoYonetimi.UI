using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("Rol")]
public partial class Rol
{
    [Key]
    [Column("RolID")]
    public int RolId { get; set; }

    [StringLength(50)]
    public string? RolAdi { get; set; }

    [InverseProperty("Rol")]
    public virtual ICollection<Calisan> Calisans { get; set; } = new List<Calisan>();

    [InverseProperty("Rol")]
    public virtual ICollection<SayfaYetki> SayfaYetkis { get; set; } = new List<SayfaYetki>();
}
