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
                sRuc = source.sRuc,
                sRazonSocial = source.sRazonSocial,
                nSectorId = source.nSectorId,
                nRubroId = source.nRubroId,
                nDepartamentoId = source.nDepartamentoId,
                nProvinciaId = source.nProvinciaId,
                nDistritoId = source.nDistritoId,
                sDireccion = source.sDireccion,
                sComentario = source.sComentario,
                dIngresosUltimoAnio = source.dIngresosUltimoAnio,
                dUtilidadUltimoAnio = source.dUtilidadUltimoAnio,
                dConformacionCapitalSocial = source.dConformacionCapitalSocial,
                nNumeroMiembros = source.nNumeroMiembros,
                bRegistradoMercadoValor = source.bRegistradoMercadoValor,
                dtFechaModificacion = _timeProvider.NowPeru,
                nUsuarioModificacionId = source.nUsuarioModificacionId
            };
        }
    }
}
