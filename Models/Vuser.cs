using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

[Keyless]
public partial class Vuser
{
    [Column("name")]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column("lastname")]
    [StringLength(50)]
    public string Lastname { get; set; } = null!;

    [Column("lastname1")]
    [StringLength(50)]
    public string? Lastname1 { get; set; }

    [Column("login")]
    [StringLength(100)]
    public string Login { get; set; } = null!;

    [Column("email")]
    public string? Email { get; set; }

    [Column("phone")]
    [StringLength(50)]
    public string? Phone { get; set; }

    [Column("active")]
    public bool Active { get; set; }

    [Column("id")]
    public int Id { get; set; }

    [Column("rols")]
    public string? Rols { get; set; }
}
