/***********
 * Nombre del archivo:  UbigeoSqlRepository.cs
 * Descripción:         Implementación del repositorio de Ubigeo utilizando Dapper y SQL Server.
 *                      Expone métodos para listar departamentos, provincias y distritos mediante procedimientos almacenados.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial del repositorio con métodos de consulta.
 ***********/

using Dapper;
using System.Data;
using Empresa.Domain.Ubigeo.Parameters;
using Empresa.Domain.Ubigeo.Repositories;
using Empresa.Domain.Ubigeo.Results;

namespace Empresa.Infrastructure.Ubigeo.Persistence.Repositories.SqlServer
{
    public class UbigeoSqlRepository(IDbConnection connection) : IUbigeoRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<List<DepartamentoResult>> ListDepartamentos(ListarDepartamentoParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<DepartamentoResult>(
                "sp_ListarDepartamento",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<List<DistritoResult>> ListDistritos(ListarDistritoParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<DistritoResult>(
                "sp_ListarDistrito",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<List<ProvinciaResult>> ListProvincias(ListarProvinciaParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<ProvinciaResult>(
                "sp_ListarProvincia",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
    }
}
