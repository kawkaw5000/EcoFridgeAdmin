using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Models;

[Table("UserPlan")]
public partial class UserPlan
{
    [Key]
    public int UserPlanId { get; set; }

    public int? UserId { get; set; }

    public int? StoragePlanId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SubscriptionDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpiryDate { get; set; }

    [ForeignKey("StoragePlanId")]
    [InverseProperty("UserPlans")]
    public virtual StoragePlan? StoragePlan { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("UserPlans")]
    public virtual User? User { get; set; }
}
