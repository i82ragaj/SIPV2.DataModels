using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

[Table("MDRol")]
public partial class Mdrol
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("active")]
    public bool Active { get; set; }

    [Column("createdBy")]
    public int? CreatedBy { get; set; }

    [Column("updatedBy")]
    public int? UpdatedBy { get; set; }

    [Column("created", TypeName = "datetime")]
    public DateTime? Created { get; set; }

    [Column("updated", TypeName = "datetime")]
    public DateTime? Updated { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [InverseProperty("Rol")]
    public virtual ICollection<MduserRol> MduserRols { get; set; } = new List<MduserRol>();
}
