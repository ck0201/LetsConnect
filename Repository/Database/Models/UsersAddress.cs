using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LetsConnect.Repository.Database.Models;

[Table("UsersAddress")]
public partial class UsersAddress
{
    [Key]
    public int Id { get; set; }

    public int UserId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RoomNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Locality { get; set; } = null!;

    [Column("PIN", TypeName = "decimal(18, 0)")]
    public decimal Pin { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Village { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string District { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string City { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string State { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Country { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? Other { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("UsersAddresses")]
    public virtual User User { get; set; } = null!;
}
