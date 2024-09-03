using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Models;

[Table("StoragePlan")]
public partial class StoragePlan
{
    [Key]
    public int StoragePlanId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StoragePlanName { get; set; } = null!;

    public int StorageSize { get; set; }

    public int Duration { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }

    [InverseProperty("StoragePlan")]
    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();

    [InverseProperty("StoragePlan")]
    public virtual ICollection<UserPlan> UserPlans { get; set; } = new List<UserPlan>();
}
