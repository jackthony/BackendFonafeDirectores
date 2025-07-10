/*****
 * Nombre del archivo:  ListarEmpresaPaginadoRequest.cs
 * Descripción:         Define el DTO para listar empresas de manera paginada.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Se ha creado el DTO para permitir la paginación al listar empresas, con filtros opcionales por razón social y estado.
 *****/
using Shared.Kernel.Requests;

namespace Empresa.Application.Empresa.Dtos
{
    public class ListarEmpresaPaginadoRequest : PagedRequest
    {
        public string? sRazonSocial { get; set; }
        public bool? bEstado { get; set; }
    }
}
