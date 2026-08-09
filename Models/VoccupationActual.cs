using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

[Keyless]
public partial class VoccupationActual
{
    [Column("ID")]
    [StringLength(51)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ParkingCode { get; set; } = null!;

    [StringLength(100)]
    public string ParkingName { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string CounterCode { get; set; } = null!;

    [StringLength(50)]
    public string? CounterName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ControlSystem { get; set; }

    public short? Capacity { get; set; }

    public short CurrentLevel { get; set; }

    [Column(TypeName = "decimal(19, 9)")]
    public decimal? Perc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Updated { get; set; }
}
