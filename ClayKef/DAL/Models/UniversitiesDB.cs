﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class UniversitiesDB : DbContext
{
    public UniversitiesDB()
    {
    }

    public UniversitiesDB(DbContextOptions<UniversitiesDB> options)
        : base(options)
    {
    }

    public virtual DbSet<Age> Ages { get; set; }

    public virtual DbSet<Duration> Durations { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupLevel> GroupLevels { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Pricing> Pricings { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<Timing> Timings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ClayKef\\DAL\\Database.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Age>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__tmp_ms_x__357D4CF834395955");

            entity.ToTable("Age");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("name");
        });

        modelBuilder.Entity<Duration>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Duration__357D4CF8595DCC37");

            entity.ToTable("Duration");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("type");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__tmp_ms_x__357D4CF8D752BE34");

            entity.ToTable("Group");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.AgeCode).HasColumnName("ageCode");
            entity.Property(e => e.DurationCode).HasColumnName("durationCode");
            entity.Property(e => e.GroupLevelCode).HasColumnName("groupLevelCode");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("name");
            entity.Property(e => e.NumOfMembers).HasColumnName("numOfMembers");
            entity.Property(e => e.OpeningDate)
                .HasColumnType("date")
                .HasColumnName("openingDate");
            entity.Property(e => e.PricingCode).HasColumnName("pricingCode");
            entity.Property(e => e.ProductTypeCode).HasColumnName("productTypeCode");
            entity.Property(e => e.TimingCode).HasColumnName("timingCode");
        });

        modelBuilder.Entity<GroupLevel>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__tmp_ms_x__357D4CF8C35D0185");

            entity.ToTable("GroupLevel");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("type");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Member__357D4CF88634E034");

            entity.ToTable("Member");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.CellPhone)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("cellPhone");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("firstName");
            entity.Property(e => e.GroupCode).HasColumnName("groupCode");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("lastName");
            entity.Property(e => e.TOrP).HasColumnName("tOrP");
        });

        modelBuilder.Entity<Pricing>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Pricing__357D4CF831BC3A38");

            entity.ToTable("Pricing");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__ProductT__357D4CF8F30E4FFB");

            entity.ToTable("ProductType");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.PricingCode).HasColumnName("pricingCode");
            entity.Property(e => e.Technique)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("technique");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("type");
        });

        modelBuilder.Entity<Timing>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Timing__357D4CF809D3B983");

            entity.ToTable("Timing");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Day).HasColumnName("day");
            entity.Property(e => e.Hour).HasColumnName("hour");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
