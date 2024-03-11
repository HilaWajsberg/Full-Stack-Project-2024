using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class ClayKefContext : DbContext
{
    public ClayKefContext()
    {
        
    }
    public ClayKefContext(DbContextOptions<ClayKefContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Age> Ages { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CourseLevel> CourseLevels { get; set; }

    public virtual DbSet<Duration> Durations { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<MemberToCourse> MemberToCourses { get; set; }

    public virtual DbSet<Pricing> Pricings { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<Timing> Timings { get; set; }

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

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Course__357D4CF8C17EA525");

            entity.ToTable("Course");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.AgeCode).HasColumnName("ageCode");
            entity.Property(e => e.CourseLevelCode).HasColumnName("courseLevelCode");
            entity.Property(e => e.DurationCode).HasColumnName("durationCode");
            entity.Property(e => e.MemberToCourseCode).HasColumnName("memberToCourseCode");
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

            entity.HasOne(d => d.AgeCodeNavigation).WithMany(p => p.Courses)
                .HasForeignKey(d => d.AgeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("courseToAge");

            entity.HasOne(d => d.CourseLevelCodeNavigation).WithMany(p => p.Courses)
                .HasForeignKey(d => d.CourseLevelCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("courseToCourseLevel");

            entity.HasOne(d => d.DurationCodeNavigation).WithMany(p => p.Courses)
                .HasForeignKey(d => d.DurationCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("courseToDuration");

            entity.HasOne(d => d.MemberToCourseCodeNavigation).WithMany(p => p.Courses)
                .HasForeignKey(d => d.MemberToCourseCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("courseToMemberToCourse");

            entity.HasOne(d => d.PricingCodeNavigation).WithMany(p => p.Courses)
                .HasForeignKey(d => d.PricingCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("courseToPricing");

            entity.HasOne(d => d.ProductTypeCodeNavigation).WithMany(p => p.Courses)
                .HasForeignKey(d => d.ProductTypeCode)
                .HasConstraintName("courseToProductType");

            entity.HasOne(d => d.TimingCodeNavigation).WithMany(p => p.Courses)
                .HasForeignKey(d => d.TimingCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("courseToTiming");
        });

        modelBuilder.Entity<CourseLevel>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__CourseLe__357D4CF899E490E7");

            entity.ToTable("CourseLevel");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("type");
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
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("lastName");
            entity.Property(e => e.MemberToCourseCode).HasColumnName("memberToCourseCode");
            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("password");
            entity.Property(e => e.TOrF).HasColumnName("tOrF");

            entity.HasOne(d => d.MemberToCourseCodeNavigation).WithMany(p => p.Members)
                .HasForeignKey(d => d.MemberToCourseCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("memberToMemberToCourse");
        });

        modelBuilder.Entity<MemberToCourse>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__MemberTo__357D4CF847B24547");

            entity.ToTable("MemberToCourse");

            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.CourseCode).HasColumnName("courseCode");
            entity.Property(e => e.MemberCode).HasColumnName("memberCode");
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

            entity.HasOne(d => d.PricingCodeNavigation).WithMany(p => p.ProductTypes)
                .HasForeignKey(d => d.PricingCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("productToPricing");
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
