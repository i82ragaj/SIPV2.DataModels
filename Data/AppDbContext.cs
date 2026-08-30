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

    public virtual DbSet<MdcounterConfig> MdcounterConfigs { get; set; }

    public virtual DbSet<Mdparking> Mdparkings { get; set; }

    public virtual DbSet<MdparkingStatus> MdparkingStatuses { get; set; }

    public virtual DbSet<MdparkingType> MdparkingTypes { get; set; }

    public virtual DbSet<Mdrol> Mdrols { get; set; }

    public virtual DbSet<Mduser> Mdusers { get; set; }

    public virtual DbSet<MduserRol> MduserRols { get; set; }

    public virtual DbSet<TrimportProcess> TrimportProcesses { get; set; }

    public virtual DbSet<TrprocessError> TrprocessErrors { get; set; }

    public virtual DbSet<VdailyTotal> VdailyTotals { get; set; }

    public virtual DbSet<VlastParkingDatum> VlastParkingData { get; set; }

    public virtual DbSet<VoccupationActual> VoccupationActuals { get; set; }

    public virtual DbSet<VparkingSummary> VparkingSummaries { get; set; }

    public virtual DbSet<VparkingSummaryDetail> VparkingSummaryDetails { get; set; }

    public virtual DbSet<Vuser> Vusers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MdcounterConfig>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasDefaultValue("system", "DF_MDCounterConfig_CreatedBy");
            entity.Property(e => e.IsActive).HasDefaultValue(true, "DF_MDCounterConfig_IsActive");
            entity.Property(e => e.UpdatedBy).HasDefaultValue("system", "DF_MDCounterConfig_UpdatedBy");

            entity.HasOne(d => d.IdpkNavigation).WithMany(p => p.MdcounterConfigs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MDCounterConfig_MDParking");
        });

        modelBuilder.Entity<Mdparking>(entity =>
        {
            entity.Property(e => e.Active).HasDefaultValue(true, "DF__MDParking__Activ__3B75D760");
            entity.Property(e => e.CreatedBy).HasDefaultValue("system", "DF_MDParking_CreatedBy");
            entity.Property(e => e.Frecuency).HasDefaultValue("N", "DF__MDParking__Frecu__3C69FB99");
            entity.Property(e => e.Sii).HasDefaultValue(false, "DF__MDParking__SII__3A81B327");
            entity.Property(e => e.UpdatedBy).HasDefaultValue("system", "DF_MDParking_UpdatedBy");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Mdparkings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MDParking_MDParkingType");
        });

        modelBuilder.Entity<MdparkingStatus>(entity =>
        {
            entity.Property(e => e.Active).HasDefaultValue(true, "DF_MDParkingStatus_Active");
            entity.Property(e => e.CreatedBy).HasDefaultValue("system", "DF_MDParkingStatus_CreatedBy");
            entity.Property(e => e.UpdatedBy).HasDefaultValue("system", "DF_MDParkingStatus_UpdatedBy");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.MdparkingStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MDParkingStatus_MDParking");
        });

        modelBuilder.Entity<MdparkingType>(entity =>
        {
            entity.Property(e => e.Active).HasDefaultValue(true, "DF__MDParkingType__active__3F466844");
            entity.Property(e => e.CreatedBy).HasDefaultValue("system", "DF_MDParkingType_CreatedBy");
            entity.Property(e => e.UpdatedBy).HasDefaultValue("system", "DF_MDParkingType_UpdatedBy");
        });

        modelBuilder.Entity<Mdrol>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Active).HasDefaultValue(true, "DF__MDRol__active__3F466844");
            entity.Property(e => e.CreatedBy).HasDefaultValue("system", "DF_MDRol_CreatedBy");
            entity.Property(e => e.UpdatedBy).HasDefaultValue("system", "DF_MDRol_UpdatedBy");
        });

        modelBuilder.Entity<Mduser>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Active).HasDefaultValue(true, "DF__MDUser__active__45F365D3");
            entity.Property(e => e.CreatedBy).HasDefaultValue("system", "DF_MDUser_CreatedBy");
            entity.Property(e => e.UpdatedBy).HasDefaultValue("system", "DF_MDUser_UpdatedBy");
        });

        modelBuilder.Entity<MduserRol>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Active).HasDefaultValue(true, "DF__MDUserRol__activ__48CFD27E");
            entity.Property(e => e.CreatedBy).HasDefaultValue("system", "DF_MDUserRol_CreatedBy");
            entity.Property(e => e.UpdatedBy).HasDefaultValue("system", "DF_MDUserRol_UpdatedBy");

            entity.HasOne(d => d.Rol).WithMany(p => p.MduserRols).HasConstraintName("FK_MDUserRol_MDRol");

            entity.HasOne(d => d.User).WithMany(p => p.MduserRols).HasConstraintName("FK_MDUserRol_MDUser");
        });

        modelBuilder.Entity<TrimportProcess>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Active).HasDefaultValue(true, "DF_TRImportProcess_Active");
            entity.Property(e => e.CreatedBy).HasDefaultValue("system", "DF_TRImportProcess_CreatedBy");
            entity.Property(e => e.UpdatedBy).HasDefaultValue("system", "DF_TRImportProcess_UpdatedBy");

            entity.HasOne(d => d.IdpkNavigation).WithMany(p => p.TrimportProcesses).HasConstraintName("FK_TRImportProcess_MDParking");
        });

        modelBuilder.Entity<TrprocessError>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Active).HasDefaultValue(true, "DF_TRProcessError_Active");
            entity.Property(e => e.CreatedBy).HasDefaultValue("system", "DF_TRProcessError_CreatedBy");
            entity.Property(e => e.UpdatedBy).HasDefaultValue("system", "DF_TRProcessError_UpdatedBy");
        });

        modelBuilder.Entity<VdailyTotal>(entity =>
        {
            entity.ToView("VDailyTotal");
        });

        modelBuilder.Entity<VlastParkingDatum>(entity =>
        {
            entity.ToView("VLastParkingData");
        });

        modelBuilder.Entity<VoccupationActual>(entity =>
        {
            entity.ToView("VOccupationActual");
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
