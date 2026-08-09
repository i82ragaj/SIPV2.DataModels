using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

[Table("MDUser")]
[Index("Login", Name = "UQ__tc_usuar__7838F272B681AE6F", IsUnique = true)]
public partial class Mduser
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
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column("lastName")]
    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [Column("lastName1")]
    [StringLength(50)]
    public string? LastName1 { get; set; }

    [Column("login")]
    [StringLength(100)]
    public string Login { get; set; } = null!;

    [Column("password")]
    [StringLength(100)]
    public string Password { get; set; } = null!;

    [Column("email")]
    public string? Email { get; set; }

    [Column("phone")]
    [StringLength(50)]
    public string? Phone { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<MduserRol> MduserRols { get; set; } = new List<MduserRol>();
}
