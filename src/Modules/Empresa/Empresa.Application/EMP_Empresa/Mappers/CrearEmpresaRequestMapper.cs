using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.Empresa.Dtos;
using Empresa.Domain.Empresa.Parameters;

namespace Empresa.Application.Empresa.Mappers
{
    public class CrearEmpresaRequestMapper : IMapper<CrearEmpresaRequest, CrearEmpresaParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearEmpresaRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearEmpresaParameters Map(CrearEmpresaRequest source)
        {
            return new CrearEmpresaParameters
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
                dtFechaRegistro = _timeProvider.NowPeru,
                nUsuarioRegistroId = source.nUsuarioRegistroId
            };
        }
    }
}
