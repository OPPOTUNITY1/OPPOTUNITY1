﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _18_NguyenDucTrung_Lab01_AutomobileLibrary.DataAccess;

public partial class NguyenDucTrungMyStockContext : DbContext
{
    public NguyenDucTrungMyStockContext()
    {
    }

    public NguyenDucTrungMyStockContext(DbContextOptions<NguyenDucTrungMyStockContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server =TRUNGBANTHAO\\SQLEXPRESS; database =NguyenDucTrung_MyStock;uid=sa;pwd=123;TrustServerCertificate=True;Connection Timeout=100;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CarId).HasColumnName("CarID");
            entity.Property(e => e.CarName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("money");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
