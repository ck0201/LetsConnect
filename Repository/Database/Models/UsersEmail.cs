using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LetsConnect.Repository.Database.Models;

[Index("UserId", "Email", Name = "UC_UserIdEmail", IsUnique = true)]
public partial class UsersEmail
{
    [Key]
    public int Id { get; set; }

    public int UserId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UsersEmails")]
    public virtual User User { get; set; } = null!;
}
