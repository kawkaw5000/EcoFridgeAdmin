using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Models;

[Table("UserFood")]
public partial class UserFood
{
    [Key]
    public int UserFoodId { get; set; }

    public int? UserId { get; set; }

    public int? FoodId { get; set; }

    public int? FoodStoredCount { get; set; }

    [InverseProperty("UserFood")]
    public virtual ICollection<DonationTransaction> DonationTransactions { get; set; } = new List<DonationTransaction>();

    [ForeignKey("FoodId")]
    [InverseProperty("UserFoods")]
    public virtual Food? Food { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("UserFoods")]
    public virtual User? User { get; set; }
}
