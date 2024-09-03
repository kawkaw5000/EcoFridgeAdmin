using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Models;

[Table("FoodCategory")]
public partial class FoodCategory
{
    [Key]
    public int FoodCategoryId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FoodCategoryName { get; set; } = null!;

    [InverseProperty("FoodCategory")]
    public virtual ICollection<StorageTipForFoodCategory> StorageTipForFoodCategories { get; set; } = new List<StorageTipForFoodCategory>();
}
