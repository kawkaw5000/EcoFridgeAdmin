using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Models;


public partial class VwUsersRoleView
{
    [Key]
    public int UserRoleId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string RoleName { get; set; } = null!;

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

    [StringLength(10)]
    [Unicode(false)]
    public string? EmailVerificationCode { get; set; }

    public bool? EmailConfirmed { get; set; }

    public int? StorageSize { get; set; }

    public int RoleId { get; set; }
}
