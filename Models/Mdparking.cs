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

    public bool Active { get; set; }

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    [StringLength(50)]
    public string? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Created { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Updated { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [Column("SRV")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Srv { get; set; }

    [StringLength(100)]
    public string? Name { get; set; }

    [StringLength(100)]
    public string? Company { get; set; }

    [Column("DACode")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Dacode { get; set; }

    public DateOnly? DateFromTable { get; set; }

    public DateOnly? DateToTable { get; set; }

    [Column("NDays")]
    public int? Ndays { get; set; }

    public bool? TruncateTables { get; set; }

    [Column("SII")]
    public bool? Sii { get; set; }

    public bool? MultiCounter { get; set; }

    [Column("ServerIP")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ServerIp { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Job { get; set; }

    public TimeOnly? LoadDate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Frecuency { get; set; }

    [InverseProperty("IdpkNavigation")]
    public virtual ICollection<TrimportProcess> TrimportProcesses { get; set; } = new List<TrimportProcess>();
}
