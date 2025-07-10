/***********
 * Nombre del archivo:  DietaResponse.cs
 * Descripción:         Clase DTO que representa la respuesta del módulo Dieta.
 *                      Contiene propiedades que describen la información básica
 *                      relacionada con la dieta, incluyendo el RUC, tipo de cargo y monto.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Definición inicial del DTO DietaResponse.
 ***********/

namespace Empresa.Presentation.Dieta.Responses
{
    public class DietaResponse
    {
        public string SRUC { get; set; } = string.Empty;
        public int NTipoCargo { get; set; }
        public decimal MDieta { get; set; }
    }
}
