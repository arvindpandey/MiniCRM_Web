using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MiniCRM.Infrastructure.Entities;

[Index("DepartmentName", Name = "UQ__Departme__D949CC343A392CE6", IsUnique = true)]
public partial class Department
{
    [Key]
    [Column("DepartmentID")]
    public int DepartmentId { get; set; }

    [StringLength(100)]
    public string DepartmentName { get; set; } = null!;

    [Column("CreateAT", TypeName = "datetime")]
    public DateTime? CreateAt { get; set; }
}
