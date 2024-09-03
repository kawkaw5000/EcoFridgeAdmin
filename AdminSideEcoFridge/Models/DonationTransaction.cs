using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Models;

[Table("DonationTransaction")]
public partial class DonationTransaction
{
    [Key]
    public int DonationTransactionId { get; set; }

    public int? DonorId { get; set; }

    public int? DoneeId { get; set; }

    public int? UserFoodId { get; set; }

    public int? DonationDate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    [ForeignKey("DoneeId")]
    [InverseProperty("DonationTransactions")]
    public virtual Donee? Donee { get; set; }

    [ForeignKey("DonorId")]
    [InverseProperty("DonationTransactions")]
    public virtual Donor? Donor { get; set; }

    [ForeignKey("UserFoodId")]
    [InverseProperty("DonationTransactions")]
    public virtual UserFood? UserFood { get; set; }
}
