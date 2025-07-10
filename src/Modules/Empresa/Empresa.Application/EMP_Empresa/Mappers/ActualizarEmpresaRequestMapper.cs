/*****
 * Nombre del archivo:  ActualizarEmpresaRequestMapper.cs
 * Descripción:         Mapea un objeto de tipo ActualizarEmpresaRequest a ActualizarEmpresaParameters.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación de mapeo entre el DTO de actualización de empresa y el modelo de parámetros.
 *****/
using Shared.Kernel.Interfaces;
using Empresa.Application.Empresa.Dtos;
using Empresa.Domain.Empresa.Parameters;
using Shared.Time;

namespace Empresa.Application.Empresa.Mappers
{
    public class ActualizarEmpresaRequestMapper : IMapper<ActualizarEmpresaRequest, ActualizarEmpresaParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public ActualizarEmpresaRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }
        public ActualizarEmpresaParameters Map(ActualizarEmpresaRequest source)
        {
            return new ActualizarEmpresaParameters
            {
                IdEmpresa = source.nIdEmpresa,
                IdRubroNegocio = source.nIdRubroNegocio,
                IdSector = source.nIdSector,
                IdDepartamento = int.Parse(source.sIdDepartamento),
                IdProvincia = int.Parse(source.sIdProvincia),
                IdDistrito = int.Parse(source.sIdDistrito),
                Direccion = source.sDireccion,
                Comentario = source.sComentario,
                NumeroMiembros = source.nNumeroMiembros,
                IngresosUltimoAnio = source.mIngresosUltimoAnio,
                UtilidadUltimoAnio = source.mUtilidadUltimoAnio,
                ConformacionCapitalSocial = source.mConformacionCapitalSocial,
                RegistradoMercadoValores = source.bRegistradoMercadoValores,
                Activo = source.bActivo,
                UsuarioModificacion = source.nUsuarioModificacion,
                FechaModificacion = _timeProvider.NowPeru
            };
        }
    }
}
