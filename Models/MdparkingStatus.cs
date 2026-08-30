using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

[Table("MDParkingStatus")]
public partial class MdparkingStatus
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

    [Column(TypeName = "datetime")]
    public DateTime? LastImported { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? LastImportedStatus { get; set; }

    [Column("LastImportedOK", TypeName = "datetime")]
    public DateTime? LastImportedOk { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastCountTotals { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastCountTotalsStatus { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastImportedDuration { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("MdparkingStatus")]
    public virtual Mdparking IdNavigation { get; set; } = null!;
}
