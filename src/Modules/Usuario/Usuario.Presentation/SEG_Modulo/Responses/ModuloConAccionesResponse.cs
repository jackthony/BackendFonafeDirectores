namespace Usuario.Presentation.Modulo.Responses
{
    public class ModuloConAccionesResponse
    {
        public int nModuloId { get; set; }
        public string sNombre { get; set; } = string.Empty;
        public string? sRuta { get; set; }
        public string? sIcono { get; set; }
        public bool bModuloPermitido { get; set; }
        public List<AccionResponse> acciones { get; set; } = [];
    }
}
