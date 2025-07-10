/*****
 * Nombre del archivo:  ImportFileUseCase.cs
 * Descripción:         Caso de uso encargado de gestionar la importación de archivos. 
 *                      Implementa la interfaz `IUseCase`, manejando la lectura, validación y almacenamiento de los datos de un archivo importado, 
 *                      incluyendo la validación de empresas y directores, y la inserción/actualización en la base de datos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Archivo.Application.Archivo.Dtos;
using Archivo.Application.Archivo.Services;
using Archivo.Domain.Archivo.Repositories;
using Archivo.Domain.Archivo.Results;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Archivo.Application.Archivo.UseCases
{
    public class ImportFileUseCase : IUseCase<ImportFileRequest, ImportFileResult>
    {
        private readonly IExportImportService _service;
        private readonly IExportImportRepository _repository;
        private readonly IValidarReferenciaService _validador;

        public ImportFileUseCase(
            IExportImportService service,
            IExportImportRepository repository,
            IValidarReferenciaService validador)
        {
            _service = service;
            _repository = repository;
            _validador = validador;
        }

        public async Task<OneOf<ErrorBase, ImportFileResult>> ExecuteAsync(ImportFileRequest request)
        {
            // Paso 1: Leer Excel
            var result = _service.ImportAsync(request);

            if (result.Empresas.Count == 0 && result.Directores.Count == 0)
                return ErrorBase.Validation("El archivo no contiene datos válidos.");

            // Paso 2: Cargar referencias para validación
            await _validador.CargarReferenciasAsync();

            // Paso 3: Validar empresas
            var empresasValidadas = _validador.ValidarEmpresas(result.Empresas, request.nUsuarioId);

            await _repository.InsertEmpresasAsync(empresasValidadas.RegistrosValidos);
            
            await _repository.UpdateEmpresasAsync(empresasValidadas.RegistrosUpdate);

            await _validador.CargarEmpresasAsync();

            // Paso 4: Validar directores
            var directoresValidados = _validador.ValidarDirectores(result.Directores, request.nUsuarioId);

            // Paso 5: Validar errores
            if (empresasValidadas.TieneErrores || directoresValidados.TieneErrores)
            {
                var errores = empresasValidadas.Errores
                    .Concat(directoresValidados.Errores)
                    .ToList();

                return ErrorBase.Validation(string.Join("\n", errores));
            }

            // Paso 6: Guardar en la base de datos
            await _repository.InsertDirectoresAsync(directoresValidados.RegistrosValidos);

            await _repository.UpdateDirectoresAsync(directoresValidados.RegistrosUpdate);

            // Paso 7: Retornar resultado final
            return new ImportFileResult
            {
                Empresas = result.Empresas,
                Directores = result.Directores
            };
        }
    }
}
