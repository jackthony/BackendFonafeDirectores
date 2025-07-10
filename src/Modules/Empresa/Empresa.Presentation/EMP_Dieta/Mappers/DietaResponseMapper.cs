/***********
* Nombre del archivo: DietaResponseMapper.cs
* Descripción:        **Clase estática que actúa como mapeador para transformar objetos de dominio `DietaResult`
*                     en objetos de respuesta `DietaResponse`**. Este mapeador simplifica la conversión de los resultados
*                     obtenidos de la lógica de negocio a un formato adecuado para ser presentado al cliente,
*                     asignando el RUC, el tipo de cargo y el monto de la dieta.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapeadora estática para respuestas de dieta.
***********/

using Empresa.Domain.Dieta.Results;

namespace Empresa.Presentation.Dieta.Responses
{
    public static class DietaResponseMapper
    {
        public static DietaResponse ToResponse(DietaResult result)
        {
            return new DietaResponse
            {
                SRUC = result.Ruc,
                NTipoCargo = result.TipoCargo,
                MDieta = result.MontoDieta
            };
        }
    }
}
