/***********
 * Nombre del archivo:  DietaResult.cs
 * Descripción:         Clase que representa el resultado con la información de dieta,
 *                      incluyendo RUC, tipo de cargo y monto de la dieta.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación de la clase para representar resultados de dieta.
 ***********/

namespace Empresa.Domain.Dieta.Results
{
    public class DietaResult
    {
        public string Ruc { get; set; } = string.Empty;
        public int TipoCargo { get; set; }
        public decimal MontoDieta { get; set; }
    }
}
