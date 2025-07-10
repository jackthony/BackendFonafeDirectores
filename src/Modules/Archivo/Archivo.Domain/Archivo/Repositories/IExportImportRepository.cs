/*****
 * Nombre del archivo:  IExportImportRepository.cs
 * Descripción:         Interfaz que define los métodos para interactuar con los datos de exportación e importación de empresas y directores en el repositorio. 
 *                      Incluye operaciones para obtener empresas y directores, así como insertar y actualizar estos datos en la base de datos.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz.
 *****/
using Archivo.Domain.Archivo.Parameters;
using Archivo.Domain.Archivo.Results;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Empresa.Parameters;

namespace Archivo.Domain.Archivo.Repositories
{
    public interface IExportImportRepository
    {
        public Task<List<EmpresaDocResult>> GetEmpresas(ExportParameters request);
        public Task<List<DirectorDocResult>> GetDirectores(ExportParameters request);
        public Task InsertEmpresasAsync(List<CrearEmpresaParameters> empresas);
        public Task UpdateEmpresasAsync(List<CrearEmpresaParameters> empresas);
        public Task InsertDirectoresAsync(List<CrearDirectorParameters> directores);
        public Task UpdateDirectoresAsync(List<CrearDirectorParameters> directores);
    }
}
