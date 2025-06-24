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
