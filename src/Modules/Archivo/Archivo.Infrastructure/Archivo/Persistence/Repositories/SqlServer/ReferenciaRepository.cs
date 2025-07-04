using Archivo.Domain.Archivo.Repositories;
using Archivo.Domain.Archivo.Results;
using Dapper;
using System.Data;

namespace Archivo.Infrastructure.Archivo.Persistence.Repositories.SqlServer
{
    public class ReferenciaRepository(IDbConnection connection) : IReferenciaRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<List<ReferenciaResult>> GetEmpresasAsync()
        {
            var query = "SELECT nEmpresaId AS Id, sRuc AS Nombre FROM EMP_Empresa";
            var result = await _connection.QueryAsync<ReferenciaResult>(query);
            return [.. result];
        }

        public async Task<List<ReferenciaResult>> GetProvinciasAsync()
        {
            var query = "SELECT nProvinciaId AS Id, sNombreProvincia AS Nombre, nDepartamentoId AS ReferenceId FROM CAT_Provincia";
            var result = await _connection.QueryAsync<ReferenciaResult>(query);
            return [.. result];
        }

        public async Task<List<ReferenciaResult>> GetDepartamentosAsync()
        {
            var query = "SELECT nDepartamentoId AS Id, sNombreDepartamento AS Nombre FROM CAT_Departamento";
            var result = await _connection.QueryAsync<ReferenciaResult>(query);
            return [.. result];
        }

        public async Task<List<ReferenciaResult>> GetDistritosAsync()
        {
            var query = "SELECT nDistritoId AS Id, sNombreDistrito AS Nombre, nProvinciaId AS ReferenceId FROM CAT_Distrito";
            var result = await _connection.QueryAsync<ReferenciaResult>(query);
            return [.. result];
        }

        public async Task<List<ReferenciaResult>> GetRubrosAsync()
        {
            var query = "SELECT nRubroId AS Id, sNombreRubro AS Nombre FROM EMP_Rubro";
            var result = await _connection.QueryAsync<ReferenciaResult>(query);
            return [.. result];
        }

        public async Task<List<ReferenciaResult>> GetMinisteriosAsync()
        {
            var query = "SELECT nMinisterioId AS Id, sNombreMinisterio AS Nombre FROM EMP_Ministerio";
            var result = await _connection.QueryAsync<ReferenciaResult>(query);
            return [.. result];
        }

        public async Task<List<ReferenciaResult>> GetGenerosAsync()
        {
            var query = "SELECT nValor AS Id, sDescripcion AS Nombre FROM Constantes where nCodigo = 1 and nValor <> 0";
            var result = await _connection.QueryAsync<ReferenciaResult>(query);
            return [.. result];
        }

        public async Task<List<ReferenciaResult>> GetTiposDocumentoAsync()
        {
            var query = "SELECT nValor AS Id, sDescripcion AS Nombre FROM Constantes where nCodigo = 2 and nValor <> 0";
            var result = await _connection.QueryAsync<ReferenciaResult>(query);
            return [.. result];
        }

        public async Task<List<ReferenciaResult>> GetTiposDirectorAsync()
        {
            var query = "SELECT nTipoDirectorId AS Id, sNombreTipoDirector AS Nombre FROM EMP_TipoDirector";
            var result = await _connection.QueryAsync<ReferenciaResult>(query);
            return [.. result];
        }

        public async Task<List<ReferenciaResult>> GetDirectoresAsync()
        {
            var query = "SELECT nDirectorId AS Id, sNumeroDocumento AS Nombre FROM EMP_Director";
            var result = await _connection.QueryAsync<ReferenciaResult>(query);
            return [.. result];
        }

        public async Task<List<ReferenciaResult>> GetCargosDirectorAsync()
        {
            var query = "SELECT nValor AS Id, sDescripcion AS Nombre FROM Constantes where nCodigo = 12 and nValor <> 0";
            var result = await _connection.QueryAsync<ReferenciaResult>(query);
            return [.. result];
        }

        public async Task<List<ReferenciaResult>> GetTiposPersonalAsync()
        {
            var query = "SELECT nValor AS Id, sDescripcion AS Nombre FROM Constantes where nCodigo = 13 and nValor <> 0";
            var result = await _connection.QueryAsync<ReferenciaResult>(query);
            return [.. result];
        }

        public async Task<List<ReferenciaResult>> GetSectoresAsync()
        {
            var query = "SELECT nSectorId AS Id, sNombreSector AS Nombre FROM EMP_Sector";
            var result = await _connection.QueryAsync<ReferenciaResult>(query);
            return [.. result];
        }

        public async Task<List<ReferenciaResult>> GetEspecialidadesAsync()
        {
            var query = "SELECT nEspecialidadId AS Id, sNombreEspecialidad AS Nombre FROM EMP_Especialidad";
            var result = await _connection.QueryAsync<ReferenciaResult>(query);
            return [.. result];
        }

        public async Task<List<ReferenciaResult>> GetCargosAsync()
        {
            var query = "SELECT nCargoId AS Id, sNombreCargo AS Nombre FROM EMP_Cargo";
            var result = await _connection.QueryAsync<ReferenciaResult>(query);
            return [.. result];
        }
    }
}
