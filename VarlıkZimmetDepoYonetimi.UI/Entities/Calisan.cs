using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("Calisan")]
public partial class Calisan
{
    [Key]
    [Column("CalisanID")]
    public int CalisanId { get; set; }

    [StringLength(50)]
    public string? AdSoyad { get; set; }

    [StringLength(50)]
    public string? Telefon { get; set; }

    [StringLength(50)]
    public string? Mail { get; set; }

    [Column("RolID")]
    public int? RolId { get; set; }

    [Column("EkipID")]
    public int? EkipId { get; set; }

    [StringLength(12)]
    public string? AboneNo { get; set; }

    public string? Sifre { get; set; }

    [ForeignKey("EkipId")]
    [InverseProperty("Calisans")]
    public virtual Ekip? Ekip { get; set; }

    [ForeignKey("RolId")]
    [InverseProperty("Calisans")]
    public virtual Rol? Rol { get; set; }

    [InverseProperty("AtananCalisan")]
    public virtual ICollection<Zimmet> ZimmetAtananCalisans { get; set; } = new List<Zimmet>();

    [InverseProperty("AtayanCalisan")]
    public virtual ICollection<Zimmet> ZimmetAtayanCalisans { get; set; } = new List<Zimmet>();
}
