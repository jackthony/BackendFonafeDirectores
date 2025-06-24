using Empresa.Domain.Empresa.Results;
using Empresa.Presentation.Empresa.Responses;

namespace Empresa.Presentation.Empresa.Mappers
{
    public static class EmpresaResponseMapper
    {
        public static EmpresaResponse ToResponse(EmpresaResult dto) => new()
        {
            nIdEmpresa = dto.IdEmpresa,
            sRuc = dto.Ruc,
            sRazonSocial = dto.RazonSocial,
            nIdProponente = dto.IdSector,
            nIdRubroNegocio = dto.IdRubroNegocio,
            sIdDepartamento = dto.IdDepartamento.ToString("D4"),
            sIdProvincia = dto.IdProvincia.ToString("D4"),
            sIdDistrito = dto.IdDistrito.ToString("D4"),
            sDireccion = dto.Direccion,
            sComentario = dto.Comentario,
            mIngresosUltimoAnio = dto.IngresosUltimoAnio,
            mUtilidadUltimoAnio = dto.UtilidadUltimoAnio,
            mConformacionCapitalSocial = dto.ConformacionCapitalSocial,
            nNumeroMiembros = dto.NumeroMiembros,
            bRegistradoMercadoValores = dto.RegistradoMercadoValores,
            bActivo = dto.Activo,
            dtFechaRegistro = dto.FechaRegistro,
            nUsuarioRegistro = dto.UsuarioRegistro,
            dtFechaModificacion = dto.FechaModificacion,
            nUsuarioModificacion = dto.UsuarioModificacion,
            sDescripcionRubro = dto.DescripcionRubro,
            sNombreMinisterio = dto.NombreMinisterio,
            sProvinciaDescripcion = dto.ProvinciaDescripcion
        };

        public static IEnumerable<EmpresaResponse> ToListResponse(IEnumerable<EmpresaResult> items)
            => items.Select(ToResponse);
    }
}
