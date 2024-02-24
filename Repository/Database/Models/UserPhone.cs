using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LetsConnect.Repository.Database.Models;

[Index("UserId", "Number", Name = "UC_UserIdNumber", IsUnique = true)]
public partial class UserPhone
{
    [Key]
    [Column(TypeName = "decimal(18, 0)")]
    public decimal PhoneId { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string Number { get; set; } = null!;

    public int UserId { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("UserPhones")]
    public virtual User User { get; set; } = null!;
}
