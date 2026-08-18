namespace SIPV2.DataModels;

// Personalización manual (no tocada por `dotnet ef dbcontext scaffold --force`,
// que solo regenera MdparkingStatus.cs). Relación configurada en
// AppDbContext.Custom.cs -> OnModelCreatingPartial.
public partial class MdparkingStatus
{
    // Relación 1:1 por clave compartida: este Id es el mismo que MDParking.ID
    // (no hay FK real en la base de datos, solo coinciden los valores).
    public virtual Mdparking? Parking { get; set; }
}
