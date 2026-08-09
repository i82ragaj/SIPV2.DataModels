using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

[Table("MDUserRol")]
public partial class MduserRol
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

    [Column("userId")]
    public Guid? UserId { get; set; }

    [Column("rolId")]
    public Guid? RolId { get; set; }

    [ForeignKey("RolId")]
    [InverseProperty("MduserRols")]
    public virtual Mdrol? Rol { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("MduserRols")]
    public virtual Mduser? User { get; set; }
}
