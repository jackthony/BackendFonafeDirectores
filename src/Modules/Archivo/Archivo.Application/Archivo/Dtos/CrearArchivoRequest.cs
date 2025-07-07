using Microsoft.AspNetCore.Http;
using Shared.Kernel.Interfaces;

namespace Archivo.Application.Archivo.Dtos
{
    public class CrearArchivoRequest : ITrackableRequest
    {
        public required bool IsDocumento { get; set; }
        public IFormFile? Archivo { get; set; }
        public required string EmpresaId { get; set; }
        public int? DirectorId { get; set; }
        public int? CarpetaPadreId { get; set; }
        public int UsuarioRegistroId { get; set; }

        public int UsuarioId => UsuarioRegistroId;
        public string Modulo => "ARCHIVO";
        public string Tabla => "Elemento";
        public string CampoId => "nElementoId";
        public int? ValorId => null;
        public string Movimiento => "Create";
    }
}
