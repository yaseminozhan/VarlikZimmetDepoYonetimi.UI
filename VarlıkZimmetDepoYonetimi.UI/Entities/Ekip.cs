using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("Ekip")]
public partial class Ekip
{
    [Key]
    [Column("EkipID")]
    public int EkipId { get; set; }

    [StringLength(50)]
    public string? EkipAdi { get; set; }

    [InverseProperty("Ekip")]
    public virtual ICollection<Calisan> Calisans { get; set; } = new List<Calisan>();

    [ForeignKey("EkipId")]
    [InverseProperty("Ekips")]
    public virtual ICollection<Sirket> Sirkets { get; set; } = new List<Sirket>();
}
