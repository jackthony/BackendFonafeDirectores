namespace Empresa.Domain.Sector.Parameters
{
    public class CrearSectorParameters
    {
        // Tabla SEG_Empresa
        public string Sectorname { get; set; } = default!;
        public string PasswordHash { get; set; } = default!;
        public string CorreoElectronico { get; set; } = default!;
        public DateTime FechaRegistro { get; set; }
        public int EmpresaRegistroId { get; set; }

        // Tabla SEG_EmpresaInfo
        public string ApellidoPaterno { get; set; } = default!;
        public string ApellidoMaterno { get; set; } = default!;
        public string Nombres { get; set; } = default!;
    }
}
