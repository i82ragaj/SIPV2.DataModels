using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

[Keyless]
public partial class VparkingSummary
{
    [Column("ID")]
    [StringLength(41)]
    [Unicode(false)]
    public string? Id { get; set; }

    [Column("IDPK")]
    [StringLength(10)]
    [Unicode(false)]
    public string Idpk { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public int? Operations { get; set; }

    [Column(TypeName = "decimal(38, 4)")]
    public decimal? Total { get; set; }

    [StringLength(29)]
    [Unicode(false)]
    public string? InvoiceNoMin { get; set; }

    [StringLength(29)]
    [Unicode(false)]
    public string? InvoiceNoMax { get; set; }

    [Column(TypeName = "decimal(38, 4)")]
    public decimal? ParkingTransTotal { get; set; }

    public int? ParkingTransNum { get; set; }

    public int? SumMinutes { get; set; }

    [Column(TypeName = "decimal(38, 4)")]
    public decimal? InvoicesTotal { get; set; }

    public int? InvoicesNum { get; set; }

    [Column("ACATotal", TypeName = "decimal(38, 4)")]
    public decimal? Acatotal { get; set; }

    [Column("ACANum")]
    public int? Acanum { get; set; }

    [Column("CEITotal", TypeName = "decimal(38, 4)")]
    public decimal? Ceitotal { get; set; }

    [Column("CEINum")]
    public int? Ceinum { get; set; }

    [Column("CERTotal", TypeName = "decimal(38, 4)")]
    public decimal? Certotal { get; set; }

    [Column("CERNum")]
    public int? Cernum { get; set; }

    [Column(TypeName = "decimal(38, 4)")]
    public decimal? CashTotal { get; set; }

    public int? CashNum { get; set; }

    [Column(TypeName = "decimal(38, 4)")]
    public decimal? RestTotal { get; set; }

    public int? RestNum { get; set; }
}
