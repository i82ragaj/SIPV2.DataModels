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
    public Guid Id { get; set; }

    public bool Active { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Updated { get; set; }

    public Guid? UserId { get; set; }

    public Guid? RolId { get; set; }

    [ForeignKey("RolId")]
    [InverseProperty("MduserRols")]
    public virtual Mdrol? Rol { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("MduserRols")]
    public virtual Mduser? User { get; set; }
}
