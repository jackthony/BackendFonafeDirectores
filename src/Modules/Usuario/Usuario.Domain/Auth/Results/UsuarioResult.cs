namespace Usuario.Domain.Auth.Results
{
    public class UsuarioResult
    {
        public int UsuarioId { get; set; }
        public string CorreoElectronico { get; set; } = default!;
        public string PasswordHash { get; set; } = default!;
        public string NombreCompleto { get; set; } = default!;
        public string NombreVisual { get; set; } = default!;
        public string PrimerNombre { get; set; } = default!;
        public string Status { get; set; } = default!;
        public string JsonModulos { get; set; } = default!;
        public int IntentosFallidos {  get; set; } = default!;
    }
}
