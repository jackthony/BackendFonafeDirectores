/*****
 * Nombre del archivo:  ExportFileRequestMapper.cs
 * Descripción:         Clase encargada de mapear la solicitud de exportación de archivo (`ExportFileRequest`) a los parámetros necesarios para la operación de exportación (`ExportParameters`).
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Parameters;
using Shared.Kernel.Interfaces;

namespace Archivo.Application.Archivo.Mappers
{
    public class ExportFileRequestMapper : IMapper<ExportFileRequest, ExportParameters>
    {
        public ExportParameters Map(ExportFileRequest request)
        {
            return new ExportParameters
            {
            };
        }
    }
}
