using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

[Keyless]
public partial class VlastParkingDatum
{
    [Column("ID")]
    [StringLength(10)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [StringLength(100)]
    public string? Name { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastCountTotals { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastCountTotalsStatus { get; set; }

    public int? DailyTrans { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DailyTotalAmount { get; set; }

    [Column("ocupTotal", TypeName = "decimal(19, 9)")]
    public decimal? OcupTotal { get; set; }

    [Column("ocupAbo", TypeName = "decimal(19, 9)")]
    public decimal? OcupAbo { get; set; }

    [Column("ocupRot", TypeName = "decimal(19, 9)")]
    public decimal? OcupRot { get; set; }
}
