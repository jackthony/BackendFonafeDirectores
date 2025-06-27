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
                Ruc = source.sRuc,
                RazonSocial = source.sRazonSocial,
                IdSector = source.nIdSector,
                IdRubroNegocio = source.nIdRubroNegocio,
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
                UsuarioRegistro = source.nUsuarioRegistro,
                FechaRegistro = _timeProvider.NowPeru
            };
        }
    }
}
