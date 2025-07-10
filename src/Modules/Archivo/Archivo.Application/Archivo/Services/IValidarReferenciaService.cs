/*****
 * Nombre del archivo:  IValidarReferenciaService.cs
 * Descripción:         Interfaz que define los métodos para validar referencias de empresas y directores. 
 *                      Incluye métodos para cargar referencias y empresas, y para validar empresas y directores con los resultados de validación correspondientes.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz.
 *****/
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
