namespace Empresa.Domain.Rubro.Parameters
{
    public class ActualizarRubroParameters
    {
        public int RubroId { get; set; }
        public string NombreRubro { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}
