using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Models;

[Table("UserRole")]
public partial class UserRole
{
    [Key]
    public int UserRoleId { get; set; }

    public int? UserId { get; set; }

    public int? RoleId { get; set; }

    [InverseProperty("UserRole")]
    public virtual ICollection<Donee> Donees { get; set; } = new List<Donee>();

    [InverseProperty("UserRole")]
    public virtual ICollection<Donor> Donors { get; set; } = new List<Donor>();

    [ForeignKey("RoleId")]
    [InverseProperty("UserRoles")]
    public virtual Role? Role { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("UserRoles")]
    public virtual User? User { get; set; }
}
