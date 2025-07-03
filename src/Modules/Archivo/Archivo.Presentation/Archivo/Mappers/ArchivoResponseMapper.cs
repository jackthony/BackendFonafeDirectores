using Archivo.Domain.Archivo.Results;
using Archivo.Presentation.Archivo.Responses;

namespace Archivo.Presentation.Archivo.Mappers
{
    public static class ArchivoResponseMapper
    {
        public static ArchivoNode ToNode(ArchivoResult dto)
        {
            if (dto.EsDocumento)
            {
                return new ArchivoDocumento
                {
                    nElementoId = dto.ElementoId,
                    sNombre = dto.Nombre,
                    nCarpetaPadreId = dto.CarpetaPadreId,
                    nEmpresaId = dto.EmpresaId,
                    nUsuarioRegistroId = dto.UsuarioRegistroId,
                    dtFechaRegistro = dto.FechaRegistro,
                    nPeso = dto.Peso,
                    sTipoMime = dto.TipoMime,
                    sUrlStorage = dto.UrlStorage
                };
            }
            else
            {
                return new ArchivoCarpeta
                {
                    nElementoId = dto.ElementoId,
                    sNombre = dto.Nombre,
                    nCarpetaPadreId = dto.CarpetaPadreId,
                    nEmpresaId = dto.EmpresaId,
                    nUsuarioRegistroId = dto.UsuarioRegistroId,
                    dtFechaRegistro = dto.FechaRegistro
                };
            }
        }

        public static List<ArchivoNode> ToTree(List<ArchivoResult> planos)
        {
            var dict = planos.ToDictionary(x => x.ElementoId, ToNode);
            var raiz = new List<ArchivoNode>();

            foreach (var nodo in dict.Values)
            {
                if (nodo.nCarpetaPadreId is null)
                {
                    raiz.Add(nodo);
                }
                else if (dict.TryGetValue(nodo.nCarpetaPadreId.Value, out var padre) && padre is ArchivoCarpeta carpeta)
                {
                    carpeta.ltHijos.Add(nodo);
                }
            }

            return raiz;
        }

        public static List<ArchivoNode> ToList(List<ArchivoResult> planos)
            => planos.Select(ToNode).ToList();
    }
}
