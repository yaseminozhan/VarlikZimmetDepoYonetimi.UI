using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("DepoUrun")]
public partial class DepoUrun
{
    [Key]
    [Column("DepoUrunID")]
    public int DepoUrunId { get; set; }

    [Column("DepoID")]
    public int? DepoId { get; set; }

    [Column("UrunID")]
    public int? UrunId { get; set; }

    public short? Miktar { get; set; }

    [StringLength(5)]
    public string? Birim { get; set; }

    [ForeignKey("DepoId")]
    [InverseProperty("DepoUruns")]
    public virtual Depo? Depo { get; set; }

    [ForeignKey("UrunId")]
    [InverseProperty("DepoUruns")]
    public virtual Urun? Urun { get; set; }
}
