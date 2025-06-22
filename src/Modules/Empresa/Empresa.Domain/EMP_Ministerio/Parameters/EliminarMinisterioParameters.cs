namespace Empresa.Domain.Ministerio.Parameters
{
    public class EliminarMinisterioParameters
    {
        public int MinisterioId { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
