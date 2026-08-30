using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

[Keyless]
public partial class VdailyTotal
{
    [Column("IDPK")]
    [StringLength(10)]
    [Unicode(false)]
    public string Idpk { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TotalDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? DailyTotalAmount { get; set; }

    public int? DailyTransWithPay { get; set; }

    public int? DailyTransWithOutPay { get; set; }
}
