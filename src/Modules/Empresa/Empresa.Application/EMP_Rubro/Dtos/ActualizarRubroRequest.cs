namespace Empresa.Application.Rubro.Dtos
{
    public class ActualizarRubroRequest
    {
        public int RubroId { get; set; }
        public string NombreRubro { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
    }
}
