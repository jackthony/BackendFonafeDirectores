using Dapper;
using System.Data;
using Usuario.Domain.SEG_Log.Repositories;

namespace Usuario.Infrastructure.SEG_Log.Persistence.Repositories.SqlServer
{
    public class TrazabilidadInspector(IDbConnection connection) : ITrazabilidadInspector
    {
        private readonly IDbConnection _connection = connection;
        private readonly HashSet<string> _tablasPermitidas =
        [
            "EMP_Sector", "EMP_Empresa", "EMP_Cargo"
        ];
        public async Task<string?> ObtenerEstadoActualAsync(string tabla, string campoId, int valorId)
        {
            if (!_tablasPermitidas.Contains(tabla))
                throw new ArgumentException($"Tabla '{tabla}' no está permitida.");

            var query = $"SELECT * FROM {tabla} WHERE {campoId} = @Id FOR JSON AUTO";

            var resultado = await _connection.QuerySingleOrDefaultAsync<string>(query, new { Id = valorId });

            return string.IsNullOrWhiteSpace(resultado) ? null : resultado;
        }
    }
}
