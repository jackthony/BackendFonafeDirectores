/***********
 * Nombre del archivo:  ObtenerDietaParameter.cs
 * Descripción:         Clase que representa los parámetros para obtener información de dieta,
 *                      incluyendo RUC y tipo de cargo.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación de la clase de parámetros para obtener dieta.
 ***********/

namespace Empresa.Domain.Dieta.Parameters
{
    public class ObtenerDietaParameter
    {
        public required string Ruc { get; set; } = string.Empty;
        public required int TipoCargo { get; set; }
    }
}
