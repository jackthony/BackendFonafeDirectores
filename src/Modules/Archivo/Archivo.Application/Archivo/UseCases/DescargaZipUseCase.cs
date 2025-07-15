using System.IO.Compression;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Archivo.Application.Archivo.Services;
using Archivo.Domain.Archivo.Results;
using Archivo.Application.Archivo.Helpers;

namespace Archivo.Application.Archivo.UseCases
{
    public class DescargaZipUseCase : IUseCase<List<ArchivoResult>, Stream>
    {
        private readonly IStorageService _storageService;

        public DescargaZipUseCase(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public async Task<OneOf<ErrorBase, Stream>> ExecuteAsync(List<ArchivoResult> archivos)
        {
            var archivosParaZip = ArchivoResultExtensions.GenerarArchivosParaZip(archivos);

            if (archivosParaZip.Count == 0)
                return ErrorBase.Validation("No hay archivos válidos para comprimir.");

            var memoryStream = new MemoryStream();

            try
            {
                using (var zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create, leaveOpen: true))
                {
                    foreach (var archivo in archivosParaZip)
                    {
                        try
                        {
                            var stream = await _storageService.DescargarArchivoAsync(archivo.Url);
                            var zipEntry = zipArchive.CreateEntry(archivo.RutaEnZip, CompressionLevel.Fastest);

                            using var entryStream = zipEntry.Open();
                            await stream.CopyToAsync(entryStream);
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }

                memoryStream.Seek(0, SeekOrigin.Begin);
                return memoryStream;
            }
            catch (Exception ex)
            {
                return ErrorBase.Unexpected($"Error al generar el ZIP: {ex.Message}");
            }
        }
    }
}
