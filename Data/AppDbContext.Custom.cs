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
            // Relación 1:1 por clave compartida (ahora con FK real en la base de datos,
            // FK_MDParkingStatus_MDParking): el scaffold ya configura HasOne/WithOne en
            // AppDbContext.cs, pero no puede inferir por sí solo qué lado es el
            // dependiente, así que lo completamos aquí con HasForeignKey explícito
            // (si no, EF lanza "The dependent side could not be determined...").
            entity.HasOne(s => s.IdNavigation).WithOne(p => p.MdparkingStatus).HasForeignKey<MdparkingStatus>(s => s.Id);
        });
    }
}
