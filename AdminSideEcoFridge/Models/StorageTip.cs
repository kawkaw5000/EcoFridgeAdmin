using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Models;

[Table("StorageTip")]
public partial class StorageTip
{
    [Key]
    public int StorageTipId { get; set; }

    [Column(TypeName = "text")]
    public string? TipText { get; set; }

    [InverseProperty("StorageTip")]
    public virtual ICollection<StorageTipForFoodCategory> StorageTipForFoodCategories { get; set; } = new List<StorageTipForFoodCategory>();
}
