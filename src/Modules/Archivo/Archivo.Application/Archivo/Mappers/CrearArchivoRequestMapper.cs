/*****
 * Nombre del archivo:  CrearArchivoRequestMapper.cs
 * Descripción:         Clase encargada de mapear la solicitud de creación de archivo (`CrearArchivoRequest`) a los parámetros necesarios para la operación (`CrearArchivoParameters`).
 *                      Utiliza un proveedor de tiempo (`ITimeProvider`) para asignar la fecha de registro.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;
using Shared.Time;
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Parameters;

namespace Archivo.Application.Archivo.Mappers
{
    public class CrearArchivoRequestMapper : IMapper<CrearArchivoRequest, CrearArchivoParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearArchivoRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearArchivoParameters Map(CrearArchivoRequest source)
        {
            var result = new CrearArchivoParameters
            {
                IsDocumento = source.IsDocumento,
                CarpetaPadreId = source.CarpetaPadreId,
                UsuarioRegistroId = source.UsuarioRegistroId,
                FechaRegistro = _timeProvider.NowPeru,
                EmpresaId = source.EmpresaId,
                DirectorId = source.DirectorId,
            };

            if (source.IsDocumento && source.Archivo != null)
            {
                result.Peso = source.Archivo.Length;
                result.TipoMime = source.Archivo.ContentType;
            }

            return result;
        }
    }
}
