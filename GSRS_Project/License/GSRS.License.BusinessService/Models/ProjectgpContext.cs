using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GSRS.License.BusinessService.Models;

public partial class ProjectgpContext : DbContext
{
    public ProjectgpContext()
    {
    }

    public ProjectgpContext(DbContextOptions<ProjectgpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ImportType> ImportTypes { get; set; }

    public virtual DbSet<LicenseServer> LicenseServers { get; set; }

    public virtual DbSet<LicenseServerGroup> LicenseServerGroups { get; set; }

    public virtual DbSet<LicenseType> LicenseTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ImportType>(entity =>
        {
            entity.HasKey(e => e.ImportTypeId).HasName("PK__Import_T__A9FA549C1730E5E4");

            entity.ToTable("Import_Type");

            entity.Property(e => e.ImportTypeId)
                .ValueGeneratedNever()
                .HasColumnName("ImportTypeID");
            entity.Property(e => e.ChangedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateChanged).HasColumnType("datetime");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Descriptions)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ImportTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LicenseServer>(entity =>
        {
            entity.HasKey(e => e.LicServerId).HasName("PK__License___6E8AE6BBF08B283D");

            entity.ToTable("License_server");

            entity.Property(e => e.LicServerId)
                .ValueGeneratedNever()
                .HasColumnName("LicServerID");
            entity.Property(e => e.Comment)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateChanged).HasColumnType("datetime");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Descriptions)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FolderName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImportTypeId).HasColumnName("ImportTypeID");
            entity.Property(e => e.LicServerGroupId).HasColumnName("LicServerGroupID");
            entity.Property(e => e.ServerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UdlFileName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.ImportType).WithMany(p => p.LicenseServers)
                .HasForeignKey(d => d.ImportTypeId)
                .HasConstraintName("FK__License_s__Impor__4AB81AF0");

            entity.HasOne(d => d.LicServerGroup).WithMany(p => p.LicenseServers)
                .HasForeignKey(d => d.LicServerGroupId)
                .HasConstraintName("FK__License_s__LicSe__49C3F6B7");

            entity.HasOne(d => d.LicType).WithMany(p => p.LicenseServers)
                .HasForeignKey(d => d.LicTypeId)
                .HasConstraintName("FK__License_s__LicTy__4BAC3F29");
        });

        modelBuilder.Entity<LicenseServerGroup>(entity =>
        {
            entity.HasKey(e => e.LicServerGroupId).HasName("PK__License___7BA11028E4E8006A");

            entity.ToTable("License_server_group");

            entity.Property(e => e.LicServerGroupId)
                .ValueGeneratedNever()
                .HasColumnName("LicServerGroupID");
            entity.Property(e => e.ChangedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryIso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateChanged).HasColumnType("datetime");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.ServerGroupName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LicenseType>(entity =>
        {
            entity.HasKey(e => e.LicTypeId).HasName("PK__License___DEE40BAC2BE6DF8E");

            entity.ToTable("License_type");

            entity.Property(e => e.LicTypeId).ValueGeneratedNever();
            entity.Property(e => e.ChangedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateChanged).HasColumnType("datetime");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.ImportFrequency)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LicTypeName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.ImportType).WithMany(p => p.LicenseTypes)
                .HasForeignKey(d => d.ImportTypeId)
                .HasConstraintName("FK__License_t__Impor__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
