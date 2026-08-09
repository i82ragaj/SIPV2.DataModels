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
    public Guid Id { get; set; }

    public bool Active { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Updated { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    [InverseProperty("Rol")]
    public virtual ICollection<MduserRol> MduserRols { get; set; } = new List<MduserRol>();
}
