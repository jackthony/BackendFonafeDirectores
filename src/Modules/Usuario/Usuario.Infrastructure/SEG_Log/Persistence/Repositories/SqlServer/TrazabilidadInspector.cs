/***********
 * Nombre del archivo:  TrazabilidadInspector.cs
 * Descripción:         Implementación que inspecciona el estado actual de una entidad específica en tablas permitidas,
 *                      generando su representación en JSON para ser utilizada en logs de trazabilidad.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación de método para obtener el estado de una fila como JSON, validando contra una lista blanca de tablas.
 ***********/

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
            "EMP_Sector",
            "EMP_Empresa",
            "EMP_Cargo",
            "EMP_TipoDirector",
            "EMP_Rubro",
            "EMP_Ministerio",
            "EMP_Especialidad",
            "Elemento",
            "EMP_Director",
            "SEG_Usuario"
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
