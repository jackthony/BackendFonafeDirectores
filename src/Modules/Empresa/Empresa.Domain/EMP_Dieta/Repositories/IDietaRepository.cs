/***********
 * Nombre del archivo:  IDietaRepository.cs
 * Descripción:         Interfaz que define el método para obtener la información de dieta
 *                      basada en parámetros específicos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación de la interfaz para el repositorio de dieta.
 ***********/

using Empresa.Domain.Dieta.Parameters;
using Empresa.Domain.Dieta.Results;

namespace Empresa.Domain.Dieta.Repositories
{
    public interface IDietaRepository
    {
        public Task<DietaResult?> ObtenerDietaAsync(ObtenerDietaParameter request);
    }
}
