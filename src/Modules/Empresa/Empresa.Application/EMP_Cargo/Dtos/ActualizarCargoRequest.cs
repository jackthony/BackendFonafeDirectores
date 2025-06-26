namespace Empresa.Application.Cargo.Dtos
{
    public class ActualizarCargoRequest
    {
        public int nIdCargo { get; set; }
        public string sNombreCargo { get; set; } = default!;
        public int nUsuarioModificacion { get; set; }
    }
}
