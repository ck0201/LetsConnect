using System;
using System.Collections.Generic;
using LetsConnect.Repository.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace LetsConnect.Repository;

public partial class LetsConnectDbContext : DbContext
{
    public LetsConnectDbContext()
    {
    }

    public LetsConnectDbContext(DbContextOptions<LetsConnectDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserPhone> UserPhones { get; set; }

    public virtual DbSet<UsersAddress> UsersAddresses { get; set; }

    public virtual DbSet<UsersEmail> UsersEmails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Project1;Trusted_Connection=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4C3CE30CCB");

            entity.Property(e => e.IsDelete).HasDefaultValue(false);
        });

        modelBuilder.Entity<UserPhone>(entity =>
        {
            entity.HasKey(e => e.PhoneId).HasName("PK__UserPhon__F3EE4BB0DEE64805");

            entity.Property(e => e.PhoneId).ValueGeneratedOnAdd();

            entity.HasOne(d => d.User).WithMany(p => p.UserPhones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserId");
        });

        modelBuilder.Entity<UsersAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UsersAdd__3214EC07A38A086E");

            entity.HasOne(d => d.User).WithMany(p => p.UsersAddresses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserIdAddress");
        });

        modelBuilder.Entity<UsersEmail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UsersEma__3214EC07C3F90463");

            entity.HasOne(d => d.User).WithMany(p => p.UsersEmails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmailUsers");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
