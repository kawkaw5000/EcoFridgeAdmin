using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Models;

[Table("Donee")]
public partial class Donee
{
    [Key]
    public int DoneeId { get; set; }

    public int? UserRoleId { get; set; }

    [InverseProperty("Donee")]
    public virtual ICollection<DonationTransaction> DonationTransactions { get; set; } = new List<DonationTransaction>();

    [ForeignKey("UserRoleId")]
    [InverseProperty("Donees")]
    public virtual UserRole? UserRole { get; set; }
}
