namespace Empresa.Domain.Rubro.Results
{
    public class RubroResult
    {
        public int RubroId { get; set; }
        public string NombreRubro { get; set; } = default!;
        public bool IsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacionId { get; set; }
    }
}
