using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Models;

[Keyless]
public partial class VwUsersFoodItem
{
    public int UserFoodId { get; set; }

    public int UserId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LastName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FoodBusinessName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DoneeOrganizationName { get; set; }

    public DateOnly? Birthdate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Province { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Barangay { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Street { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ProfilePicturePath { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ProofPicturePath { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? EmailVerificationCode { get; set; }

    public bool? EmailConfirmed { get; set; }

    public int? StorageSize { get; set; }

    public int FoodId { get; set; }

    public int FoodCategoryId { get; set; }

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
}
