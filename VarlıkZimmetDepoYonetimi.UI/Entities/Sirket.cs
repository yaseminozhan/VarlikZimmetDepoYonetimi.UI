using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("Sirket")]
public partial class Sirket
{
    [Key]
    [Column("SirketID")]
    public int SirketId { get; set; }

    [StringLength(50)]
    public string? SirketAdi { get; set; }

    [InverseProperty("Sirket")]
    public virtual ICollection<Depo> Depos { get; set; } = new List<Depo>();

    [ForeignKey("SirketId")]
    [InverseProperty("Sirkets")]
    public virtual ICollection<Ekip> Ekips { get; set; } = new List<Ekip>();
}
