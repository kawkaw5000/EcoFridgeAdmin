using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Models;

[Table("PaymentTransaction")]
public partial class PaymentTransaction
{
    [Key]
    public int PaymentTransactionId { get; set; }

    public int? UserId { get; set; }

    public int? StoragePlanId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaymentDate { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Amount { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PaymentMethod { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TransactionStatus { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TransactionReferenceId { get; set; }

    [ForeignKey("StoragePlanId")]
    [InverseProperty("PaymentTransactions")]
    public virtual StoragePlan? StoragePlan { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("PaymentTransactions")]
    public virtual User? User { get; set; }
}
