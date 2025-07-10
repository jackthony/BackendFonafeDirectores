/***********
 * Nombre del archivo:  DietaSqlRepository.cs
 * Descripción:         Implementación del repositorio del módulo Dieta utilizando Dapper y SQL Server.
 *                      Contiene el método para obtener una dieta específica a través de un procedimiento almacenado.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial del repositorio con método de consulta de dieta.
 ***********/

using Dapper;
using Empresa.Domain.Dieta.Parameters;
using Empresa.Domain.Dieta.Repositories;
using Empresa.Domain.Dieta.Results;
using System.Data;

namespace Empresa.Infrastructure.Dieta.Persistence.Repositories.SqlServer
{
    public class DietaSqlRepository(IDbConnection connection) : IDietaRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<DietaResult?> ObtenerDietaAsync(ObtenerDietaParameter request)
        {
            var parameters = new DynamicParameters(request);

            return await _connection.QueryFirstOrDefaultAsync<DietaResult>(
                "sp_ObtenerDieta",
                parameters,
                commandType: CommandType.StoredProcedure);
        }
    }
}
