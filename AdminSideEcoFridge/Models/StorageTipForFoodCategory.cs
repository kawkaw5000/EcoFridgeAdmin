using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Models;

[Table("StorageTipForFoodCategory")]
public partial class StorageTipForFoodCategory
{
    [Key]
    public int StorageTipFoFoodCategoryId { get; set; }

    public int? StorageTipId { get; set; }

    public int? FoodCategoryId { get; set; }

    [ForeignKey("FoodCategoryId")]
    [InverseProperty("StorageTipForFoodCategories")]
    public virtual FoodCategory? FoodCategory { get; set; }

    [ForeignKey("StorageTipId")]
    [InverseProperty("StorageTipForFoodCategories")]
    public virtual StorageTip? StorageTip { get; set; }
}
