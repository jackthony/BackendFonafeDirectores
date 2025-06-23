namespace Empresa.Application.Cargo.Dtos
{
    public class CrearCargoRequest
    {
        public string sNombreCargo { get; set; } = default!;
        public int nUsuarioRegistro { get; set; }
    }
}
