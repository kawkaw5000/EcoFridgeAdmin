using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Models;

[Table("FoodIngredient")]
public partial class FoodIngredient
{
    [Key]
    public int FoodIngredientId { get; set; }

    public int? FoodId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string IngredientName { get; set; } = null!;

    [ForeignKey("FoodId")]
    [InverseProperty("FoodIngredients")]
    public virtual Food? Food { get; set; }
}
