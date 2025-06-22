namespace Empresa.Domain.Empresa.Parameters
{
    public class CrearEmpresaParameters
    {
        // Tabla SEG_Empresa
        public string Empresaname { get; set; } = default!;
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
