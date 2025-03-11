using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("Musteri")]
public partial class Musteri
{
    [Key]
    [Column("MusteriID")]
    public int MusteriId { get; set; }

    [StringLength(50)]
    public string? AdSoyad { get; set; }

    [InverseProperty("Musteri")]
    public virtual ICollection<MusteriZimmet> MusteriZimmets { get; set; } = new List<MusteriZimmet>();
}
