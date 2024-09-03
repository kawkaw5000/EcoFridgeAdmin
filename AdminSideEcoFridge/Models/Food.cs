using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Models;

[Table("Food")]
public partial class Food
{
    [Key]
    public int FoodId { get; set; }

    public int? FoodCategoryId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? FoodName { get; set; }

    public int? Quantity { get; set; }

    public int? Servings { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateAdded { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpiryDate { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? FoodPicturePath { get; set; }

    [InverseProperty("Food")]
    public virtual ICollection<FoodIngredient> FoodIngredients { get; set; } = new List<FoodIngredient>();

    [InverseProperty("Food")]
    public virtual ICollection<UserFood> UserFoods { get; set; } = new List<UserFood>();
}
