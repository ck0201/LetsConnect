using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LetsConnect.Repository.Database.Models;

[Index("Email", Name = "UC_Email", IsUnique = true)]
[Index("UserLoginId", Name = "UC_UserLoginId", IsUnique = true)]
public partial class User
{
    [Key]
    public int UserId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string UserLoginId { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string UserPassword { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? MiddleName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PhoneNo { get; set; }

    [Column("DOB")]
    public DateOnly? Dob { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Gender { get; set; }

    public DateOnly? CreationDate { get; set; }

    public bool? IsDelete { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<UserPhone> UserPhones { get; set; } = new List<UserPhone>();

    [InverseProperty("User")]
    public virtual ICollection<UsersAddress> UsersAddresses { get; set; } = new List<UsersAddress>();

    [InverseProperty("User")]
    public virtual ICollection<UsersEmail> UsersEmails { get; set; } = new List<UsersEmail>();
}
