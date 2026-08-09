using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

[Table("TRImportProcess")]
public partial class TrimportProcess
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    [Column("IDPK")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Idpk { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Begin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? End { get; set; }

    public TimeOnly? Duration { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    public string? Description { get; set; }

    [ForeignKey("Idpk")]
    [InverseProperty("TrimportProcesses")]
    public virtual Mdparking? IdpkNavigation { get; set; }
}
