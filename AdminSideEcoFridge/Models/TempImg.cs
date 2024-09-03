using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AdminSideEcoFridge.Models;

[Table("TempImg")]
public partial class TempImg
{
    [Key]
    public int TempImgId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? FilePath { get; set; }
}
