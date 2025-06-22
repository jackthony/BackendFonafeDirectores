namespace Empresa.Domain.Rubro.Parameters
{
    public class CrearRubroParameters
    {
        public string NombreRubro { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
