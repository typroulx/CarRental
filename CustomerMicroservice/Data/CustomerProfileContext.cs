using System;
using System.Collections.Generic;
using CustomerMicroservice.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerMicroservice.Data;

public partial class CustomerProfileContext : DbContext
{
    public CustomerProfileContext()
    {
    }

    public CustomerProfileContext(DbContextOptions<CustomerProfileContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC074CDD6A4F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}