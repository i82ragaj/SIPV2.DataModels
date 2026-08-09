using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Mdparking> Mdparkings { get; set; }

    public virtual DbSet<Mdrol> Mdrols { get; set; }

    public virtual DbSet<Mduser> Mdusers { get; set; }

    public virtual DbSet<MduserRol> MduserRols { get; set; }

    public virtual DbSet<TrimportProcess> TrimportProcesses { get; set; }

    public virtual DbSet<TrprocessError> TrprocessErrors { get; set; }

    public virtual DbSet<VoccupationActual> VoccupationActuals { get; set; }

    public virtual DbSet<VparkingDatum> VparkingData { get; set; }

    public virtual DbSet<VparkingSummary> VparkingSummaries { get; set; }

    public virtual DbSet<VparkingSummaryDetail> VparkingSummaryDetails { get; set; }

    public virtual DbSet<Vuser> Vusers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mdparking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ALLParki__3214EC279C67C035");

            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.Frecuency).HasDefaultValue("N");
        });

        modelBuilder.Entity<Mdrol>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Active).HasDefaultValue(true, "DF__MDRol__active__3F466844");
        });

        modelBuilder.Entity<Mduser>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Active).HasDefaultValue(true, "DF__MDUser__active__45F365D3");
        });

        modelBuilder.Entity<MduserRol>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Active).HasDefaultValue(true, "DF__MDUserRol__activ__48CFD27E");

            entity.HasOne(d => d.Rol).WithMany(p => p.MduserRols).HasConstraintName("FK_MDUserRol_MDRol");

            entity.HasOne(d => d.User).WithMany(p => p.MduserRols).HasConstraintName("FK_MDUserRol_MDUser");
        });

        modelBuilder.Entity<TrimportProcess>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdpkNavigation).WithMany(p => p.TrimportProcesses).HasConstraintName("FK_TRImportProcess_MDParking");
        });

        modelBuilder.Entity<TrprocessError>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ErrorId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VoccupationActual>(entity =>
        {
            entity.ToView("VOccupationActual");
        });

        modelBuilder.Entity<VparkingDatum>(entity =>
        {
            entity.ToView("VParkingData");
        });

        modelBuilder.Entity<VparkingSummary>(entity =>
        {
            entity.ToView("VParkingSummary");
        });

        modelBuilder.Entity<VparkingSummaryDetail>(entity =>
        {
            entity.ToView("VParkingSummaryDetail");
        });

        modelBuilder.Entity<Vuser>(entity =>
        {
            entity.ToView("VUser");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
