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
            "Nombres"
        ];

        private readonly string[] _encabezadosPorTipoUsuario =
        [
            "Username",
            "Correo Electrónico",
            "Rol",
            "Apellido Paterno",
            "Apellido Materno",
            "Nombres"
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
