namespace Empresa.Domain.Ministerio.Parameters
{
    public class CrearMinisterioParameters
    {
        public string NombreMinisterio { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
