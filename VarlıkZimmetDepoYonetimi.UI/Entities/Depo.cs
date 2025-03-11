using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("Depo")]
public partial class Depo
{
    [Key]
    [Column("DepoID")]
    public int DepoId { get; set; }

    [StringLength(50)]
    public string? DepoAdi { get; set; }

    [Column("SirketID")]
    public int? SirketId { get; set; }

    [InverseProperty("Depo")]
    public virtual ICollection<DepoUrun> DepoUruns { get; set; } = new List<DepoUrun>();

    [ForeignKey("SirketId")]
    [InverseProperty("Depos")]
    public virtual Sirket? Sirket { get; set; }
}
