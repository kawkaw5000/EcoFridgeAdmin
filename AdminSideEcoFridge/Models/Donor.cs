using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Models;

[Table("Donor")]
public partial class Donor
{
    [Key]
    public int DonorId { get; set; }

    public int? UserRoleId { get; set; }

    [InverseProperty("Donor")]
    public virtual ICollection<DonationTransaction> DonationTransactions { get; set; } = new List<DonationTransaction>();

    [ForeignKey("UserRoleId")]
    [InverseProperty("Donors")]
    public virtual UserRole? UserRole { get; set; }
}
