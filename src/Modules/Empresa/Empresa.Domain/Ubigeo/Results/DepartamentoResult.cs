/***********
 * Nombre del archivo:  DepartamentoResult.cs
 * Descripción:         DTO que representa los datos de un departamento, incluyendo su ID y nombre.
 *                      Utilizado como resultado en operaciones de consulta del módulo Ubigeo.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial del DTO DepartamentoResult.
 ***********/

namespace Empresa.Domain.Ubigeo.Results
{
    public class DepartamentoResult
    {
        public int DepartamentoId { get; set; }
        public string NombreDepartamento { get; set; } = string.Empty;
    }
}
