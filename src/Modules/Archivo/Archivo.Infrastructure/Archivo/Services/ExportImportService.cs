using Archivo.Application.Archivo.Dtos;
using Archivo.Application.Archivo.Services;
using Archivo.Domain.Archivo.Results;
using ClosedXML.Excel;

namespace Archivo.Infrastructure.Archivo.Services
{
    public class ExportImportService : IExportImportService
    {
        private readonly string[] encabezadosEmpresas =
        [
            "RUC",
            "Razón Social",
            "Departamento",
            "Provincia",
            "Distrito",
            "Dirección",
            "Rubro",
            "Proponente",
            "Ingreso de la empresa en el último año",
            "Utilidad de la empresa en el último año",
            "Capital Social",
            "Número de miembros",
            "Registro en mercado de valores",
            "Activo",
            "Comentario"
        ];

        private readonly string[] encabezadosDirectores =
        [
            "RUC",
            "Empresa",
            "Tipo de documento",
            "Nro. Documento",
            "Departamento",
            "Provincia",
            "Distrito",
            "Dirección",
            "Nombres",
            "Apellidos",
            "Fecha Nacimiento",
            "Género",
            "Telefono",
            "Correo",
            "Cargo",
            "Tipo de director",
            "Sector",
            "Profesión",
            "Dieta",
            "Fec.Nombramiento",
            "Fec. de designación",
            "Fec. de renuncia",
            "Comentarios"
        ];


        public Stream ExportAsync(List<EmpresaDocResult> empresas, List<DirectorDocResult> directores)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.AddWorksheet("Empresas");

            for (int i = 0; i < encabezadosEmpresas.Length; i++)
            {
                worksheet.Cell(1, i + 1).Value = encabezadosEmpresas[i];
            }

            int fila = 2;

            foreach (var item in empresas)
            {
                var propiedades = item.GetType().GetProperties();
                for (int col = 0; col < propiedades.Length; col++)
                {
                    var valor = propiedades[col].GetValue(item);
                    worksheet.Cell(fila, col + 1).Value = valor?.ToString() ?? "";
                }
                fila++;
            }

            worksheet = workbook.AddWorksheet("Directores");

            for (int i = 0; i < encabezadosDirectores.Length; i++)
            {
                worksheet.Cell(1, i + 1).Value = encabezadosDirectores[i];
            }

            fila = 2;

            foreach (var item in directores)
            {
                var propiedades = item.GetType().GetProperties();
                for (int col = 0; col < propiedades.Length; col++)
                {
                    var valor = propiedades[col].GetValue(item);
                    worksheet.Cell(fila, col + 1).Value = valor?.ToString() ?? "";
                }
                fila++;
            }

            var stream = new MemoryStream();
            workbook.SaveAs(stream);
            stream.Position = 0;
            return stream;
        }

        public bool ImportAsync(ImportFileRequest request)
        {
            using var stream = request.Archivo.OpenReadStream();
            using var workbook = new XLWorkbook(stream);
            var worksheet = workbook.Worksheet(1);

            var empresas = new List<EmpresaDocResult>();

            foreach (var row in worksheet.RowsUsed().Skip(1))
            {
                var empresa = new EmpresaDocResult
                {
                    Id = row.Cell(1).GetValue<int>(),
                    Ruc = row.Cell(2).GetValue<string>(),
                    RazonSocial = row.Cell(3).GetValue<string>(),
                    Departamento = row.Cell(4).GetValue<string>(),
                    Provincia = row.Cell(5).GetValue<string>(),
                    Distrito = row.Cell(6).GetValue<string>(),
                    Direccion = row.Cell(7).GetValue<string>(),
                    Rubro = row.Cell(8).GetValue<string>(),
                    Ministerio = row.Cell(9).GetValue<string>(),
                    Ingresos = row.Cell(10).GetValue<decimal>(),
                    Utilidades = row.Cell(11).GetValue<decimal>(),
                    CapitalSocial = row.Cell(12).GetValue<decimal>(),
                    CantidadMiembros = row.Cell(13).GetValue<int>(),
                    RegistroEnMercado = row.Cell(14).GetValue<string>(),
                    Activo = row.Cell(15).GetValue<string>(),
                    Comentario = row.Cell(16).GetValue<string>()
                };

                empresas.Add(empresa);
            }

            worksheet = workbook.Worksheet(2);

            var directores = new List<DirectorDocResult>();

            foreach (var row in worksheet.RowsUsed().Skip(1))
            {
                var director = new DirectorDocResult
                {
                    IdRegistro = row.Cell(1).GetValue<int>(),
                    IdEmpresa = row.Cell(2).GetValue<int>(),
                    TipoDocumento = row.Cell(3).GetValue<string>(),
                    Documento = row.Cell(4).GetValue<string>(),
                    Departamento = row.Cell(5).GetValue<string>(),
                    Provincia = row.Cell(6).GetValue<string>(),
                    Distrito = row.Cell(7).GetValue<string>(),
                    Direccion = row.Cell(8).GetValue<string>(),
                    Nombres = row.Cell(9).GetValue<string>(),
                    Apellidos = row.Cell(10).GetValue<string>(),
                    FechaNacimiento = row.Cell(11).GetDateTime(),
                    Genero = row.Cell(12).GetValue<string>(),
                    Telefono = row.Cell(13).GetValue<string>(),
                    Correo = row.Cell(14).GetValue<string>(),
                    Cargo = row.Cell(15).GetValue<string>(),
                    TipoDirector = row.Cell(16).GetValue<string>(),
                    Sector = row.Cell(17).GetValue<string>(),
                    Profesion = row.Cell(18).GetValue<string>(),
                    Dieta = row.Cell(19).GetValue<decimal?>(),
                    Especialidad = row.Cell(20).GetValue<string>(),
                    FechaNombramiento = row.Cell(21).GetDateTime(),
                    FechaDesignacion = row.Cell(22).GetDateTime(),
                    FechaRenuncia = row.Cell(23).GetValue<string>(),
                    Comentarios = row.Cell(24).GetValue<string>()
                };

                directores.Add(director);
            }

            return true;
        }
    }
}
