/*****
 * Nombre del archivo:  ObtenerDietaRequestMapper.cs
 * Descripción:         Clase encargada de mapear una solicitud para obtener la dieta (`ObtenerDietaRequest`) a los parámetros necesarios para la base de datos (`ObtenerDietaParameter`).
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;
using Empresa.Domain.Dieta.Parameters;
using Empresa.Application.Dieta.Dtos;

namespace Empresa.Application.Dieta.Mappers
{
    public class ObtenerDietaRequestMapper : IMapper<ObtenerDietaRequest, ObtenerDietaParameter>
    {
        public ObtenerDietaParameter Map(ObtenerDietaRequest source)
        {
            return new ObtenerDietaParameter
            {
                Ruc = source.SRUC,
                TipoCargo = source.NTipoCargo
            };
        }
    }
}
