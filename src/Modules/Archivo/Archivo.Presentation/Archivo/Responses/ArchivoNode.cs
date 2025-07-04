using System.Text.Json.Serialization;

namespace Archivo.Presentation.Archivo.Responses
{

    [JsonPolymorphic(TypeDiscriminatorPropertyName = "tipo")]
    [JsonDerivedType(typeof(ArchivoCarpeta), 0)]
    [JsonDerivedType(typeof(ArchivoDocumento), 1)]
    public abstract class ArchivoNode
    {
        public int nElementoId { get; set; }
        public string sNombre { get; set; } = string.Empty;
        public int? nCarpetaPadreId { get; set; }
        public int nEmpresaId { get; set; }
        public int nUsuarioRegistroId { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public abstract bool bEsDocumento { get; }

        [JsonIgnore]
        public abstract int tipo { get; }
    }
}
