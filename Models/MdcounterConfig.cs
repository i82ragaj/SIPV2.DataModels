using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

[Table("MDCounterConfig")]
[Index("Idpk", "CounterId", Name = "IX_MDCounterConfig", IsUnique = true)]
public partial class MdcounterConfig
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [StringLength(50)]
    public string? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Updated { get; set; }

    [Column("IDPK")]
    [StringLength(10)]
    [Unicode(false)]
    public string Idpk { get; set; } = null!;

    [Column("CounterID")]
    [StringLength(40)]
    [Unicode(false)]
    public string CounterId { get; set; } = null!;

    [StringLength(50)]
    public string? CounterName { get; set; }

    public short? OccupancyLimit { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CounterType { get; set; }
}
