/*****
 * Nombre del archivo:  ExportImportSqlRepository.cs
 * Descripción:         Implementación del repositorio `IExportImportRepository` para la base de datos SQL Server utilizando Dapper. 
 *                      Contiene métodos para obtener, insertar y actualizar empresas y directores, 
 *                      ejecutando procedimientos almacenados correspondientes para cada operación de exportación e importación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Archivo.Domain.Archivo.Parameters;
using Archivo.Domain.Archivo.Repositories;
using Archivo.Domain.Archivo.Results;
using Dapper;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Empresa.Parameters;
using System.Data;

namespace Archivo.Infrastructure.Archivo.Persistence.Repositories.SqlServer
{
    public class ExportImportSqlRepository(IDbConnection connection) : IExportImportRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<List<DirectorDocResult>> GetDirectores(ExportParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<DirectorDocResult>(
                "sp_ListarDirectorDoc",
                parameters,
                commandType: CommandType.StoredProcedure);

            return [.. result];
        }

        public async Task<List<EmpresaDocResult>> GetEmpresas(ExportParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<EmpresaDocResult>(
                "sp_ListarEmpresaDoc",
                parameters,
                commandType: CommandType.StoredProcedure);

            return [.. result];
        }

        public async Task InsertDirectoresAsync(List<CrearDirectorParameters> directores)
        {
            var table = new DataTable();
            table.Columns.Add("nEmpresaId", typeof(int));
            table.Columns.Add("nTipoDocumentoId", typeof(int));
            table.Columns.Add("sNumeroDocumento", typeof(string));
            table.Columns.Add("sNombres", typeof(string));
            table.Columns.Add("sApellidos", typeof(string));
            table.Columns.Add("dtFechaNacimiento", typeof(DateTime));
            table.Columns.Add("nGeneroId", typeof(int));
            table.Columns.Add("nDistritoId", typeof(int));
            table.Columns.Add("nProvinciaId", typeof(int));
            table.Columns.Add("nDepartamentoId", typeof(int));
            table.Columns.Add("sDireccion", typeof(string));
            table.Columns.Add("sTelefono", typeof(string));
            table.Columns.Add("sTelefonoSecundario", typeof(string));
            table.Columns.Add("sTelefonoTerciario", typeof(string));
            table.Columns.Add("sCorreo", typeof(string));
            table.Columns.Add("sCorreoSecundario", typeof(string));
            table.Columns.Add("sCorreoTerciario", typeof(string));
            table.Columns.Add("nCargoId", typeof(int));
            table.Columns.Add("nTipoDirectorId", typeof(int));
            table.Columns.Add("nSectorId", typeof(int));
            table.Columns.Add("sProfesion", typeof(string));
            table.Columns.Add("dDieta", typeof(decimal));
            table.Columns.Add("nEspecialidadId", typeof(int));
            table.Columns.Add("dtFechaNombramiento", typeof(DateTime));
            table.Columns.Add("dtFechaDesignacion", typeof(DateTime));
            table.Columns.Add("dtFechaRenuncia", typeof(DateTime));
            table.Columns.Add("sComentario", typeof(string));
            table.Columns.Add("dtFechaRegistro", typeof(DateTime));
            table.Columns.Add("nUsuarioRegistroId", typeof(int));
            table.Columns.Add("bActivo", typeof(bool));

            foreach (var d in directores)
            {
                table.Rows.Add(
                    d.IdEmpresa,
                    d.TipoDocumento,
                    d.NumeroDocumento,
                    d.Nombres,
                    d.Apellidos,
                    d.FechaNacimiento,
                    d.Genero,
                    d.Distrito,
                    d.Provincia,
                    d.Departamento,
                    d.Direccion,
                    d.Telefono,
                    d.TelefonoSecundario ?? "",
                    d.TelefonoTerciario ?? "",
                    d.Correo,
                    d.CorreoSecundario ?? "",
                    d.CorreoTerciario ?? "",
                    d.Cargo,
                    d.TipoDirector,
                    d.nSectorId,
                    d.Profesion,
                    d.Dieta,
                    d.Especialidad,
                    d.FechaNombramiento,
                    d.FechaDesignacion,
                    DBNull.Value,
                    d.Comentario,
                    d.FechaRegistro,
                    d.UsuarioRegistro,
                    true
                );
            }

            var parameters = new DynamicParameters();
            parameters.Add("@Directores", table.AsTableValuedParameter("dbo.TP_DirectorImport"));

            await _connection.ExecuteAsync(
                "sp_ImportarDirectores",
                parameters,
                commandType: CommandType.StoredProcedure
            );
        }

        public async Task InsertEmpresasAsync(List<CrearEmpresaParameters> empresas)
        {
            var table = new DataTable();
            table.Columns.Add("sRuc", typeof(string));
            table.Columns.Add("sRazonSocial", typeof(string));
            table.Columns.Add("nSectorId", typeof(int));
            table.Columns.Add("nRubroId", typeof(int));
            table.Columns.Add("nDepartamentoId", typeof(int));
            table.Columns.Add("nProvinciaId", typeof(int));
            table.Columns.Add("nDistritoId", typeof(int));
            table.Columns.Add("sDireccion", typeof(string));
            table.Columns.Add("sComentario", typeof(string));
            table.Columns.Add("dIngresosUltimoAnio", typeof(decimal));
            table.Columns.Add("dUtilidadUltimoAnio", typeof(decimal));
            table.Columns.Add("dConformacionCapitalSocial", typeof(decimal));
            table.Columns.Add("nNumeroMiembros", typeof(int));
            table.Columns.Add("bRegistradoMercadoValores", typeof(bool));
            table.Columns.Add("bActivo", typeof(bool));
            table.Columns.Add("dtFechaRegistro", typeof(DateTime));
            table.Columns.Add("nUsuarioRegistroId", typeof(int));


            foreach (var empresa in empresas)
            {
                table.Rows.Add(
                    empresa.Ruc,
                    empresa.RazonSocial,
                    empresa.IdSector,
                    empresa.IdRubroNegocio,
                    empresa.IdDepartamento,
                    empresa.IdProvincia,
                    empresa.IdDistrito,
                    empresa.Direccion,
                    empresa.Comentario,
                    empresa.IngresosUltimoAnio,
                    empresa.UtilidadUltimoAnio,
                    empresa.ConformacionCapitalSocial,
                    empresa.NumeroMiembros,
                    empresa.RegistradoMercadoValores,
                    empresa.Activo,
                    empresa.FechaRegistro,
                    empresa.UsuarioRegistro
                );
            }

            var parameters = new DynamicParameters();
            parameters.Add("@Empresas", table.AsTableValuedParameter("dbo.TP_EmpresaImport"));

            await _connection.ExecuteAsync(
                "sp_ImportarEmpresas",
                parameters,
                commandType: CommandType.StoredProcedure
            );
        }

        public async Task UpdateDirectoresAsync(List<CrearDirectorParameters> directores)
        {
            var table = new DataTable();
            table.Columns.Add("nEmpresaId", typeof(int));
            table.Columns.Add("nTipoDocumentoId", typeof(int));
            table.Columns.Add("sNumeroDocumento", typeof(string));
            table.Columns.Add("sNombres", typeof(string));
            table.Columns.Add("sApellidos", typeof(string));
            table.Columns.Add("dtFechaNacimiento", typeof(DateTime));
            table.Columns.Add("nGeneroId", typeof(int));
            table.Columns.Add("nDistritoId", typeof(int));
            table.Columns.Add("nProvinciaId", typeof(int));
            table.Columns.Add("nDepartamentoId", typeof(int));
            table.Columns.Add("sDireccion", typeof(string));
            table.Columns.Add("sTelefono", typeof(string));
            table.Columns.Add("sTelefonoSecundario", typeof(string));
            table.Columns.Add("sTelefonoTerciario", typeof(string));
            table.Columns.Add("sCorreo", typeof(string));
            table.Columns.Add("sCorreoSecundario", typeof(string));
            table.Columns.Add("sCorreoTerciario", typeof(string));
            table.Columns.Add("nCargoId", typeof(int));
            table.Columns.Add("nTipoDirectorId", typeof(int));
            table.Columns.Add("nSectorId", typeof(int));
            table.Columns.Add("sProfesion", typeof(string));
            table.Columns.Add("dDieta", typeof(decimal));
            table.Columns.Add("nEspecialidadId", typeof(int));
            table.Columns.Add("dtFechaNombramiento", typeof(DateTime));
            table.Columns.Add("dtFechaDesignacion", typeof(DateTime));
            table.Columns.Add("dtFechaRenuncia", typeof(DateTime));
            table.Columns.Add("sComentario", typeof(string));
            table.Columns.Add("dtFechaRegistro", typeof(DateTime));
            table.Columns.Add("nUsuarioRegistroId", typeof(int));
            table.Columns.Add("bActivo", typeof(bool));

            foreach (var d in directores)
            {
                table.Rows.Add(
                    d.IdEmpresa,
                    d.TipoDocumento,
                    d.NumeroDocumento,
                    d.Nombres,
                    d.Apellidos,
                    d.FechaNacimiento,
                    d.Genero,
                    d.Distrito,
                    d.Provincia,
                    d.Departamento,
                    d.Direccion,
                    d.Telefono,
                    d.TelefonoSecundario ?? "",
                    d.TelefonoTerciario ?? "",
                    d.Correo,
                    d.CorreoSecundario ?? "",
                    d.CorreoTerciario ?? "",
                    d.Cargo,
                    d.TipoDirector,
                    d.nSectorId,
                    d.Profesion,
                    d.Dieta,
                    d.Especialidad,
                    d.FechaNombramiento,
                    d.FechaDesignacion,
                    DBNull.Value,
                    d.Comentario,
                    d.FechaRegistro,
                    d.UsuarioRegistro,
                    true
                );
            }

            var parameters = new DynamicParameters();
            parameters.Add("@Directores", table.AsTableValuedParameter("dbo.TP_DirectorImport"));

            await _connection.ExecuteAsync(
                "sp_ActualizarImportarDirectores",
                parameters,
                commandType: CommandType.StoredProcedure
            );
        }

        public async Task UpdateEmpresasAsync(List<CrearEmpresaParameters> empresas)
        {
            var table = new DataTable();
            table.Columns.Add("sRuc", typeof(string));
            table.Columns.Add("sRazonSocial", typeof(string));
            table.Columns.Add("nSectorId", typeof(int));
            table.Columns.Add("nRubroId", typeof(int));
            table.Columns.Add("nDepartamentoId", typeof(int));
            table.Columns.Add("nProvinciaId", typeof(int));
            table.Columns.Add("nDistritoId", typeof(int));
            table.Columns.Add("sDireccion", typeof(string));
            table.Columns.Add("sComentario", typeof(string));
            table.Columns.Add("dIngresosUltimoAnio", typeof(decimal));
            table.Columns.Add("dUtilidadUltimoAnio", typeof(decimal));
            table.Columns.Add("dConformacionCapitalSocial", typeof(decimal));
            table.Columns.Add("nNumeroMiembros", typeof(int));
            table.Columns.Add("bRegistradoMercadoValores", typeof(bool));
            table.Columns.Add("bActivo", typeof(bool));
            table.Columns.Add("dtFechaRegistro", typeof(DateTime));
            table.Columns.Add("nUsuarioRegistroId", typeof(int));


            foreach (var empresa in empresas)
            {
                table.Rows.Add(
                    empresa.Ruc,
                    empresa.RazonSocial,
                    empresa.IdSector,
                    empresa.IdRubroNegocio,
                    empresa.IdDepartamento,
                    empresa.IdProvincia,
                    empresa.IdDistrito,
                    empresa.Direccion,
                    empresa.Comentario,
                    empresa.IngresosUltimoAnio,
                    empresa.UtilidadUltimoAnio,
                    empresa.ConformacionCapitalSocial,
                    empresa.NumeroMiembros,
                    empresa.RegistradoMercadoValores,
                    empresa.Activo,
                    empresa.FechaRegistro,
                    empresa.UsuarioRegistro
                );
            }

            var parameters = new DynamicParameters();
            parameters.Add("@Empresas", table.AsTableValuedParameter("dbo.TP_EmpresaImport"));

            await _connection.ExecuteAsync(
                "sp_ImportarActualizarEmpresas",
                parameters,
                commandType: CommandType.StoredProcedure
            );
        }
    }
}
