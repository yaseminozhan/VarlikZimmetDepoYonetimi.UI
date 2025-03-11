using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities;

[Table("Model")]
public partial class Model
{
    [Key]
    [Column("ModelID")]
    public int ModelId { get; set; }

    [StringLength(50)]
    public string? ModelAdi { get; set; }

    [Column("UstModelID")]
    public int? UstModelId { get; set; }

    [InverseProperty("UstModel")]
    public virtual ICollection<Model> InverseUstModel { get; set; } = new List<Model>();

    [InverseProperty("Model")]
    public virtual ICollection<Urun> Uruns { get; set; } = new List<Urun>();

    [ForeignKey("UstModelId")]
    [InverseProperty("InverseUstModel")]
    public virtual Model? UstModel { get; set; }
}
