using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("UrunBarkod")]
public partial class UrunBarkod
{
    [Key]
    [Column("UrunBarkodID")]
    public int UrunBarkodId { get; set; }

    public Guid? BarkodNo { get; set; }

    [Column("UrunID")]
    public int? UrunId { get; set; }

    [ForeignKey("UrunId")]
    [InverseProperty("UrunBarkods")]
    public virtual Urun? Urun { get; set; }
}
