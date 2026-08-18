namespace SIPV2.DataModels;

// Personalización manual (no tocada por `dotnet ef dbcontext scaffold --force`,
// que solo regenera Mdparking.cs). Relación configurada en
// AppDbContext.Custom.cs -> OnModelCreatingPartial.
public partial class Mdparking
{
    // Relación 1:1 por clave compartida: MDParkingStatus.ID = MDParking.ID
    // (no hay FK real en la base de datos, solo coinciden los valores).
    public virtual MdparkingStatus? ParkingStatus { get; set; }
}
