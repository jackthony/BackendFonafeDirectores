/*****
 * Nombre del archivo:  ObtenerDietaRequest.cs
 * Descripción:         Clase que representa una solicitud para obtener información sobre la dieta asociada a un cargo y un RUC específicos. 
 *                      Incluye las propiedades `SRUC` (RUC de la empresa) y `NTipoCargo` (tipo de cargo asociado a la dieta).
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
namespace Empresa.Application.Dieta.Dtos
{
    public class ObtenerDietaRequest
    {
        public required string SRUC { get; set; }
        public required int NTipoCargo { get; set; }
    }
}
