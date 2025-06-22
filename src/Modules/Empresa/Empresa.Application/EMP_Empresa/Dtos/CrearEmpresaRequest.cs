namespace Empresa.Application.Empresa.Dtos
{
    public class CrearEmpresaRequest
    {
        public string Empresaname { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string CorreoElectronico { get; set; } = default!;
        public int EmpresaRegistroId { get; set; }
        public string ApellidoPaterno { get; set; } = default!;
        public string ApellidoMaterno { get; set; } = default!;
        public string Nombres { get; set; } = default!;
    }
}
