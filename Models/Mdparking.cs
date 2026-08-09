using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

[Table("MDParking")]
public partial class Mdparking
{
    [Key]
    [Column("ID")]
    [StringLength(10)]
    [Unicode(false)]
    public string Id { get; set; } = null!;

    [Column("type")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("SRV")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Srv { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    [StringLength(100)]
    public string? Company { get; set; }

    public TimeOnly? HoraCierre { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastImported { get; set; }

    [StringLength(100)]
    public string? LastImportedStatus { get; set; }

    [Column("LastImportedOK", TypeName = "datetime")]
    public DateTime? LastImportedOk { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastCountTotals { get; set; }

    [StringLength(100)]
    public string? LastCountTotalsStatus { get; set; }

    public TimeOnly? LastImportedDuration { get; set; }

    public DateOnly? DateFromTable { get; set; }

    public DateOnly? DateToTable { get; set; }

    [Column("NDays")]
    public int? Ndays { get; set; }

    public bool? TruncateTables { get; set; }

    [Column("SII")]
    public bool Sii { get; set; }

    public bool Active { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Frecuency { get; set; } = null!;

    [Column("ServerIP")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ServerIp { get; set; }

    public TimeOnly? LoadDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Job { get; set; }

    [Column("DACode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Dacode { get; set; }

    public bool? MultiCounter { get; set; }

    public bool? Exclude { get; set; }

    [InverseProperty("IdpkNavigation")]
    public virtual ICollection<TrimportProcess> TrimportProcesses { get; set; } = new List<TrimportProcess>();
}
