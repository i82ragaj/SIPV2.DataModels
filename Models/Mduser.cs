using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

[Table("MDUser")]
[Index("Login", Name = "UQ_login", IsUnique = true)]
public partial class Mduser
{
    [Key]
    public Guid Id { get; set; }

    public bool Active { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [StringLength(50)]
    public string? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Updated { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [StringLength(50)]
    public string? LastName { get; set; }

    [StringLength(50)]
    public string? LastName1 { get; set; }

    [StringLength(100)]
    public string Login { get; set; } = null!;

    [StringLength(100)]
    public string? Password { get; set; }

    public string? Email { get; set; }

    [StringLength(50)]
    public string? Phone { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<MduserRol> MduserRols { get; set; } = new List<MduserRol>();
}
