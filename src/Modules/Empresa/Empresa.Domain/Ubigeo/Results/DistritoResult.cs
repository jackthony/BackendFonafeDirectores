/***********
 * Nombre del archivo:  DistritoResult.cs
 * Descripción:         DTO que representa los datos de un distrito, incluyendo su ID, nombre
 *                      y el ID de la provincia a la que pertenece. Utilizado como resultado en consultas.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial del DTO DistritoResult.
 ***********/

namespace Empresa.Domain.Ubigeo.Results
{
    public class DistritoResult
    {
        public int DistritoId { get; set; }
        public string NombreDistrito { get; set; } = string.Empty;
        public int ProvinciaId { get; set; }
    }
}
