using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

[Table("TRProcessError")]
[Index("ExcutionId", Name = "IX_Errores")]
public partial class TrprocessError
{
    [Key]
    [Column("ID")]
    public Guid Id { get; set; }

    public bool? Active { get; set; }

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
    public string? Idpk { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? UserName { get; set; }

    public int? ErrorNumber { get; set; }

    public int? ErrorState { get; set; }

    public int? ErrorSeverity { get; set; }

    public int? ErrorLine { get; set; }

    [Unicode(false)]
    public string? ErrorProcedure { get; set; }

    [Unicode(false)]
    public string? ErrorMessage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ErrorDateTime { get; set; }

    public Guid? ExcutionId { get; set; }
}
