/*****
 * Nombre del archivo:  ElementoResponseMapper.cs
 * Descripción:         Clase estática que contiene métodos para mapear objetos de `ArchivoResult` a respuestas estructuradas como `ElementoDetalleResponse` y `ElementoNodoResponse`. 
 *                      Incluye métodos para convertir un archivo en un nodo con detalles asociados y estructurar los archivos en una representación jerárquica.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Archivo.Domain.Archivo.Results;
using Archivo.Presentation.Archivo.Responses;

namespace Archivo.Presentation.Archivo.Mappers
{
    public static class ElementoResponseMapper
    {
        public static ElementoDetalleResponse ToDetalle(ArchivoResult dto)
        {
            return new ElementoDetalleResponse
            {
                tipo = dto.EsDocumento ? 1 : 0,
                nPeso = dto.Peso ?? 0,
                sTipoMime = dto.TipoMime ?? string.Empty,
                sUrlStorage = dto.UrlStorage ?? string.Empty,
                bEsDocumento = dto.EsDocumento,
                nElementoId = dto.ElementoId,
                sNombre = dto.Nombre,
                nCarpetaPadreId = dto.CarpetaPadreId,
                nEmpresaId = dto.EmpresaId,
                nUsuarioRegistroId = dto.UsuarioRegistroId,
                stFechaRegistro = dto.FechaRegistro
            };
        }

        public static ElementoNodoResponse<ElementoDetalleResponse> ToNodo(ArchivoResult dto)
        {
            return new ElementoNodoResponse<ElementoDetalleResponse>
            {
                id = dto.ElementoId,
                name = dto.Nombre,
                codeParent = dto.CarpetaPadreId ?? 0,
                status = dto.EsDocumento ? 1 : 0,
                element = ToDetalle(dto),
                hasChildren = false,
                Children = []
            };
        }

        public static List<ElementoNodoResponse<ElementoDetalleResponse>> ToTree(List<ArchivoResult> planos, int? idRaiz = null)
        {
            var nodos = planos.Select(ToNodo).ToDictionary(n => n.id);
            var raiz = new List<ElementoNodoResponse<ElementoDetalleResponse>>();

            foreach (var nodo in nodos.Values)
            {
                if (idRaiz.HasValue)
                {
                    if (nodo.codeParent == idRaiz)
                    {
                        raiz.Add(nodo);
                    }
                }
                else
                {
                    if (nodo.codeParent == 0 || nodo.codeParent is null)
                    {
                        raiz.Add(nodo);
                    }
                }
                if (nodo.codeParent.HasValue && nodos.TryGetValue(nodo.codeParent.Value, out var padre))
                {
                    padre.Children.Add(nodo);
                    padre.hasChildren = true;
                }
            }

            return raiz;
        }

        public static List<ElementoNodoResponse<ElementoDetalleResponse>> ToList(List<ArchivoResult> planos)
            => planos.Select(ToNodo).ToList();
    }
}
