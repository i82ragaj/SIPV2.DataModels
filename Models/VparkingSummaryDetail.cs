using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

[Keyless]
public partial class VparkingSummaryDetail
{
    [Column("ID")]
    [StringLength(72)]
    [Unicode(false)]
    public string? Id { get; set; }

    [Column("IDSummary")]
    [StringLength(41)]
    [Unicode(false)]
    public string? Idsummary { get; set; }

    [Column("IDPK")]
    [StringLength(10)]
    [Unicode(false)]
    public string Idpk { get; set; } = null!;

    public DateOnly? Date { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? PaymentTypeId { get; set; }

    [StringLength(50)]
    public string? PaymentTypeName { get; set; }

    public int? Operations { get; set; }

    [Column(TypeName = "decimal(38, 4)")]
    public decimal? Total { get; set; }

    public int? Discount { get; set; }
}
