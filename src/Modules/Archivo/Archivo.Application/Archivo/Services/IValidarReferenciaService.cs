using Archivo.Domain.Archivo.Results;
using Archivo.Infrastructure.Archivo.Helpers;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Empresa.Parameters;

namespace Archivo.Application.Archivo.Services
{
    public interface IValidarReferenciaService
    {
        Task CargarReferenciasAsync();
        Task CargarEmpresasAsync();
        ValidacionResultado<CrearEmpresaParameters> ValidarEmpresas(List<EmpresaDocResult> empresas, int usuarioId);
        ValidacionResultado<CrearDirectorParameters> ValidarDirectores(List<DirectorDocResult> directores, int usuarioId);
    }
}
