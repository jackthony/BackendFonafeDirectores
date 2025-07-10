/*****
 * Nombre del archivo:  EliminarEmpresaRequestMapper.cs
 * Descripción:         Mapea un objeto de tipo EliminarEmpresaRequest a EliminarEmpresaParameters.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación de mapeo entre el DTO de eliminación de empresa y el modelo de parámetros.
 *****/
using Shared.Kernel.Interfaces;
using Empresa.Application.Empresa.Dtos;
using Empresa.Domain.Empresa.Parameters;
using Shared.Time;

namespace Empresa.Application.Empresa.Mappers
{
    public class EliminarEmpresaRequestMapper : IMapper<EliminarEmpresaRequest, EliminarEmpresaParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public EliminarEmpresaRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }
        public EliminarEmpresaParameters Map(EliminarEmpresaRequest source)
        {
            return new EliminarEmpresaParameters
            {
                EmpresaId = source.nIdEmpresa,
                FechaModificacion = _timeProvider.NowPeru,
                UsuarioModificacionId = source.nUsuarioModificacion
            };
        }
    }
}
