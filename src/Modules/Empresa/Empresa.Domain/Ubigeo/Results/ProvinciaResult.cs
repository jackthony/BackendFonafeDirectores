/***********
 * Nombre del archivo:  ProvinciaResult.cs
 * Descripción:         DTO que representa los datos de una provincia, incluyendo su ID, nombre
 *                      y el ID del departamento al que pertenece. Utilizado como resultado de consultas.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial del DTO ProvinciaResult.
 ***********/

namespace Empresa.Domain.Ubigeo.Results
{
    public class ProvinciaResult
    {
        public int ProvinciaId { get; set; }
        public string NombreProvincia { get; set; } = string.Empty;
        public int DepartamentoId { get; set; }
    }
}
