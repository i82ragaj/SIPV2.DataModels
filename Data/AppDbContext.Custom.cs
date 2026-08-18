using Microsoft.EntityFrameworkCore;

namespace SIPV2.DataModels;

// Personalización manual, aparte de AppDbContext.cs (que regenera el scaffold
// con --force). Enganchada vía el hook OnModelCreatingPartial que el propio
// scaffold deja declarado al final de OnModelCreating.
public partial class AppDbContext
{
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MdparkingStatus>(entity =>
        {
            // Clave compartida (no hay FK real en la base de datos): el Id de
            // MDParkingStatus es también el de MDParking al que pertenece.
            entity.HasOne(s => s.Parking).WithOne(p => p.ParkingStatus).HasForeignKey<MdparkingStatus>(s => s.Id);
        });
    }
}
