using ClosedXML.Excel;
using Usuario.Application.SEG_Log.Services;
using Usuario.Domain.SEG_Log.Results;

namespace Usuario.Infrastructure.SEG_Log.Services
{
    public class ExportLogsService : IExportLogsService
    {
        private readonly string[] _encabezadosAuditoria =
        [
            "Username",
            "Correo Electrónico",
            "Apellido Paterno",
            "Apellido Materno",
            "Nombres",
            "Estado"
        ];

        private readonly string[] _encabezadosPorTipoUsuario =
        [
            "Username",
            "Correo Electrónico",
            "Rol",
            "Apellido Paterno",
            "Apellido Materno",
            "Nombres",
            "Estado"
        ];

        private readonly string[] _encabezadosLogSistema =
        [
            "Id",
            "UsuarioId",
            "CorreoElectronico",
            "TipoEvento",
            "Mensaje",
            "StackTrace",
            "Fecha",
            "Origen",
            "Estado",
            "Ip",
            "IdSession"
        ];

        private readonly string[] _encabezadosLogTrazabilidad =
        [
            "Id",
            "UsuarioId",
            "CorreoElectronico",
            "Modulo",
            "Entidad",
            "Movimiento",
            "Fecha",
            "IdSession",
            "DatosAntes",
            "DatosDespues",
            "Detalles"
        ];

        public Stream ExportarAuditoriaUsuariosExcel(List<AuditLogEstadoUsuarioResult> usuarios)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Auditoría de Usuarios");

            for (int i = 0; i < _encabezadosAuditoria.Length; i++)
            {
                worksheet.Cell(1, i + 1).Value = _encabezadosAuditoria[i];
                worksheet.Cell(1, i + 1).Style.Font.Bold = true;
            }

            int fila = 2;
            foreach (var user in usuarios)
            {
                worksheet.Cell(fila, 1).Value = user.Username;
                worksheet.Cell(fila, 2).Value = user.CorreoElectronico;
                worksheet.Cell(fila, 3).Value = user.ApellidoPaterno;
                worksheet.Cell(fila, 4).Value = user.ApellidoMaterno;
                worksheet.Cell(fila, 5).Value = user.Nombres;
                worksheet.Cell(fila, 6).Value = user.Estado;
                fila++;
            }

            worksheet.Columns().AdjustToContents();

            var stream = new MemoryStream();
            workbook.SaveAs(stream);
            stream.Position = 0;
            return stream;
        }

        public Stream ExportarUsuariosPorTipoUsuarioExcel(List<UsuarioPorTipoUsuarioResult> usuarios)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Usuarios por Tipo");

            for (int i = 0; i < _encabezadosPorTipoUsuario.Length; i++)
            {
                worksheet.Cell(1, i + 1).Value = _encabezadosPorTipoUsuario[i];
                worksheet.Cell(1, i + 1).Style.Font.Bold = true;
            }

            int fila = 2;
            foreach (var user in usuarios)
            {
                worksheet.Cell(fila, 1).Value = user.Username;
                worksheet.Cell(fila, 2).Value = user.CorreoElectronico;
                worksheet.Cell(fila, 3).Value = user.Rol;
                worksheet.Cell(fila, 4).Value = user.ApellidoPaterno;
                worksheet.Cell(fila, 5).Value = user.ApellidoMaterno;
                worksheet.Cell(fila, 6).Value = user.Nombres;
                worksheet.Cell(fila, 7).Value = user.Estado;
                fila++;
            }

            worksheet.Columns().AdjustToContents();

            var stream = new MemoryStream();
            workbook.SaveAs(stream);
            stream.Position = 0;
            return stream;
        }

        public Stream ExportarLogSistemaExcel(List<LogSistemaResult> logs)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Log del Sistema");

            for (int i = 0; i < _encabezadosLogSistema.Length; i++)
            {
                worksheet.Cell(1, i + 1).Value = _encabezadosLogSistema[i];
                worksheet.Cell(1, i + 1).Style.Font.Bold = true;
            }

            int fila = 2;
            foreach (var log in logs)
            {
                worksheet.Cell(fila, 1).Value = log.Id;
                worksheet.Cell(fila, 2).Value = log.UsuarioId;
                worksheet.Cell(fila, 3).Value = log.CorreoElectronico;
                worksheet.Cell(fila, 4).Value = log.TipoEvento;
                worksheet.Cell(fila, 5).Value = log.Mensaje;
                worksheet.Cell(fila, 6).Value = log.StackTrace;
                worksheet.Cell(fila, 7).Value = log.Fecha.ToString("yyyy-MM-dd HH:mm:ss");
                worksheet.Cell(fila, 8).Value = log.Origen;
                worksheet.Cell(fila, 9).Value = log.Estado;
                worksheet.Cell(fila, 10).Value = log.Ip;
                worksheet.Cell(fila, 11).Value = log.IdSession;
                fila++;
            }

            worksheet.Columns().AdjustToContents();

            var stream = new MemoryStream();
            workbook.SaveAs(stream);
            stream.Position = 0;
            return stream;
        }

        public Stream ExportarLogTrazabilidadExcel(List<LogTrazabilidadResult> logs)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Log Trazabilidad");

            for (int i = 0; i < _encabezadosLogTrazabilidad.Length; i++)
            {
                worksheet.Cell(1, i + 1).Value = _encabezadosLogTrazabilidad[i];
                worksheet.Cell(1, i + 1).Style.Font.Bold = true;
            }

            int fila = 2;
            foreach (var log in logs)
            {
                worksheet.Cell(fila, 1).Value = log.Id;
                worksheet.Cell(fila, 2).Value = log.UsuarioId;
                worksheet.Cell(fila, 3).Value = log.CorreoElectronico;
                worksheet.Cell(fila, 4).Value = log.Modulo;
                worksheet.Cell(fila, 5).Value = log.Entidad;
                worksheet.Cell(fila, 6).Value = log.Movimiento;
                worksheet.Cell(fila, 7).Value = log.Fecha.ToString("yyyy-MM-dd HH:mm:ss");
                worksheet.Cell(fila, 8).Value = log.IdSession;
                worksheet.Cell(fila, 9).Value = log.DatosAntes;
                worksheet.Cell(fila, 10).Value = log.DatosDespues;
                worksheet.Cell(fila, 11).Value = log.Detalles;
                fila++;
            }

            worksheet.Columns().AdjustToContents();

            var stream = new MemoryStream();
            workbook.SaveAs(stream);
            stream.Position = 0;
            return stream;
        }
    }
}
