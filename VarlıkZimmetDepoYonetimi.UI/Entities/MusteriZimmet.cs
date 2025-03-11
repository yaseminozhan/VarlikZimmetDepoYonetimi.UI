using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("MusteriZimmet")]
public partial class MusteriZimmet
{
    [Key]
    [Column("MusteriZimmetID")]
    public int MusteriZimmetId { get; set; }

    [Column("ZimmetID")]
    public int ZimmetId { get; set; }

    [Column("MusteriID")]
    public int MusteriId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TuketmeTarihi { get; set; }

    [ForeignKey("MusteriId")]
    [InverseProperty("MusteriZimmets")]
    public virtual Musteri Musteri { get; set; } = null!;

    [InverseProperty("MusteriZimmet")]
    public virtual ICollection<MusteriZimmetIptalIade> MusteriZimmetIptalIades { get; set; } = new List<MusteriZimmetIptalIade>();

    [ForeignKey("ZimmetId")]
    [InverseProperty("MusteriZimmets")]
    public virtual Zimmet Zimmet { get; set; } = null!;
}
