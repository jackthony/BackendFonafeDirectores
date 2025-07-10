/*****
 * Nombre del archivo:  ListarDepartamentoRequest.cs
 * Descripción:         DTO que representa la solicitud para listar departamentos. Permite filtrar
 *                      por nombre de departamento de forma opcional.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

namespace Empresa.Application.Ubigeo.Dtos
{
    public class ListarDepartamentoRequest
    {
        public string? sNombre {  get; set; }
    }
}
