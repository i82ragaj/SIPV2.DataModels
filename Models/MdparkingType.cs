using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

[Table("MDParkingType")]
public partial class MdparkingType
{
    [Key]
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

    public string? Name { get; set; }

    public string? Description { get; set; }

    [InverseProperty("TypeNavigation")]
    public virtual ICollection<Mdparking> Mdparkings { get; set; } = new List<Mdparking>();
}
