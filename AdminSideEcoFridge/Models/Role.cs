using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Models;

[Table("Role")]
public partial class Role
{
    [Key]
    public int RoleId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string RoleName { get; set; } = null!;

    [InverseProperty("Role")]
    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
