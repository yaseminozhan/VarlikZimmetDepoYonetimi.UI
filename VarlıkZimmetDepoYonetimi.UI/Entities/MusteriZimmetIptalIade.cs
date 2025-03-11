using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("MusteriZimmetIptalIade")]
public partial class MusteriZimmetIptalIade
{
    [Key]
    [Column("MusteriZimmetİptalIadeID")]
    public int MusteriZimmetİptalIadeId { get; set; }

    [Column("MusteriZimmetID")]
    public int? MusteriZimmetId { get; set; }

    [StringLength(50)]
    public string? Tarih { get; set; }

    [StringLength(50)]
    public string? Aciklama { get; set; }

    public bool? IadeMi { get; set; }

    [ForeignKey("MusteriZimmetId")]
    [InverseProperty("MusteriZimmetIptalIades")]
    public virtual MusteriZimmet? MusteriZimmet { get; set; }
}
