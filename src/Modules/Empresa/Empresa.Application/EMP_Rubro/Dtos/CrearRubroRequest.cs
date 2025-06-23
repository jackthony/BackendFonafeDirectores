namespace Empresa.Application.Rubro.Dtos
{
    public class CrearRubroRequest
    {
        public string sNombreRubro { get; set; } = default!;
        public int nUsuarioRegistroId { get; set; }
    }
}
