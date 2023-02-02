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

  

    

 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        

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

        

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
