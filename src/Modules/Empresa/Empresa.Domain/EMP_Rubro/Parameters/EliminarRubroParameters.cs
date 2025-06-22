namespace Empresa.Domain.Rubro.Parameters
{
    public class EliminarRubroParameters
    {
        public int RubroId { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
