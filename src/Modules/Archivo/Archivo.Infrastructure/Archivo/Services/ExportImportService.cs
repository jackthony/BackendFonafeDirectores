using Archivo.Application.Archivo.Dtos;
using Archivo.Application.Archivo.Services;
using Archivo.Domain.Archivo.Results;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.ComponentModel;
using Colors = QuestPDF.Helpers.Colors;
using IContainer = QuestPDF.Infrastructure.IContainer;

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
            "Especialidad",
            "Fec.Nombramiento",
            "Fec. de designación",
            "Fec. de renuncia",
            "Comentarios"
        ];

        public Stream ObtenerDatosExportAsync(List<EmpresaDocResult> empresas, List<DirectorDocResult> directores, int tipo)
        {
            if (tipo == 1)
            {
                return GenerarExcel(empresas, directores);
            }
            else
            {
                return GenerarPdf(empresas, directores);
            }
        }

        public ImportFileResult ImportAsync(ImportFileRequest request)
        {
            using var stream = request.Archivo.OpenReadStream();
            using var workbook = new XLWorkbook(stream);
            var worksheet = workbook.Worksheet(1);

            var empresas = new List<EmpresaDocResult>();

            foreach (var row in worksheet.RowsUsed().Skip(1))
            {
                var empresa = new EmpresaDocResult
                {
                    Ruc = row.Cell(1).GetValue<string>(),
                    RazonSocial = row.Cell(2).GetValue<string>(),
                    Departamento = row.Cell(3).GetValue<string>(),
                    Provincia = row.Cell(4).GetValue<string>(),
                    Distrito = row.Cell(5).GetValue<string>(),
                    Direccion = row.Cell(6).GetValue<string>(),
                    Rubro = row.Cell(7).GetValue<string>(),
                    Sector = row.Cell(8).GetValue<string>(),
                    Ingresos = row.Cell(9).GetValue<decimal>(),
                    Utilidades = row.Cell(10).GetValue<decimal>(),
                    CapitalSocial = row.Cell(11).GetValue<decimal>(),
                    CantidadMiembros = row.Cell(12).GetValue<int>(),
                    RegistroEnMercado = row.Cell(13).GetValue<string>(),
                    Activo = row.Cell(14).GetValue<string>(),
                    Comentario = row.Cell(15).GetValue<string>()
                };

                empresas.Add(empresa);
            }

            worksheet = workbook.Worksheet(2);

            var directores = new List<DirectorDocResult>();

            foreach (var row in worksheet.RowsUsed().Skip(1))
            {
                string? fechaNacimientoTexto = row.Cell(11).GetFormattedString()?.Trim();
                string? fechaNombramientoTexto = row.Cell(21).GetFormattedString()?.Trim();
                string? fechaDesignacionTexto = row.Cell(22).GetFormattedString()?.Trim();

                DateTime? fechaNacimiento = null;
                DateTime? fechaNombramiento = null;
                DateTime? fechaDesignacion = null;

                if (DateTime.TryParse(fechaNacimientoTexto, out var fn))
                    fechaNacimiento = fn;

                if (DateTime.TryParse(fechaNombramientoTexto, out var fno))
                    fechaNombramiento = fno;

                if (DateTime.TryParse(fechaDesignacionTexto, out var fd))
                    fechaDesignacion = fd;

                var director = new DirectorDocResult
                {
                    Ruc = row.Cell(1).GetValue<string>(),
                    Empresa = row.Cell(2).GetValue<string>(),
                    TipoDocumento = row.Cell(3).GetValue<string>(),
                    Documento = row.Cell(4).GetValue<string>(),
                    Departamento = row.Cell(5).GetValue<string>(),
                    Provincia = row.Cell(6).GetValue<string>(),
                    Distrito = row.Cell(7).GetValue<string>(),
                    Direccion = row.Cell(8).GetValue<string>(),
                    Nombres = row.Cell(9).GetValue<string>(),
                    Apellidos = row.Cell(10).GetValue<string>(),
                    FechaNacimiento = fechaNacimiento,
                    Genero = row.Cell(12).GetValue<string>(),
                    Telefono = row.Cell(13).GetValue<string>(),
                    Correo = row.Cell(14).GetValue<string>(),
                    Cargo = row.Cell(15).GetValue<string>(),
                    TipoDirector = row.Cell(16).GetValue<string>(),
                    Sector = row.Cell(17).GetValue<string>(),
                    Profesion = row.Cell(18).GetValue<string>(),
                    Dieta = row.Cell(19).GetValue<decimal?>(),
                    Especialidad = row.Cell(20).GetValue<string>(),
                    FechaNombramiento = fechaNombramiento,
                    FechaDesignacion = fechaDesignacion,
                    FechaRenuncia = row.Cell(23).GetValue<string>(),
                    Comentarios = row.Cell(24).GetValue<string>()
                };

                directores.Add(director);
            }

            var result = new ImportFileResult { Directores = directores , Empresas = empresas };

            return result;
        }

        private Stream GenerarExcel(List<EmpresaDocResult> empresas, List<DirectorDocResult> directores)
        {
            var workbook = new XLWorkbook();
            var hojaEmpresas = workbook.AddWorksheet("Empresas");

            for (int i = 0; i < encabezadosEmpresas.Length; i++)
            {
                hojaEmpresas.Cell(1, i + 1).Value = encabezadosEmpresas[i];
            }

            int fila = 2;

            foreach (var item in empresas)
            {
                var propiedades = item.GetType().GetProperties();
                for (int col = 0; col < propiedades.Length - 1; col++)
                {
                    var valor = propiedades[col].GetValue(item);
                    hojaEmpresas.Cell(fila, col + 1).Value = valor?.ToString() ?? "";
                }
                fila++;
            }

            var hojaDirectores = workbook.AddWorksheet("Directores");

            for (int i = 0; i < encabezadosDirectores.Length; i++)
            {
                hojaDirectores.Cell(1, i + 1).Value = encabezadosDirectores[i];
            }

            fila = 2;

            foreach (var item in directores)
            {
                var empresa = empresas.FirstOrDefault(e => e.Id == item.IdEmpresa);

                hojaDirectores.Cell(fila, 1).Value = empresa?.Ruc ?? "";
                hojaDirectores.Cell(fila, 2).Value = empresa?.RazonSocial ?? "";

                var propiedades = item.GetType().GetProperties();
                for (int col = 0; col < propiedades.Length - 4; col++)
                {
                    var prop = propiedades[col];
                    var valor = prop.GetValue(item);

                    if (valor is DateTime fecha)
                    {
                        hojaDirectores.Cell(fila, col + 3).Value = fecha;
                        hojaDirectores.Cell(fila, col + 3).Style.DateFormat.Format = "dd/MM/yyyy";
                    }
                    else if (valor != null && prop.PropertyType == typeof(DateTime?))
                    {
                        var fechaHere = (DateTime?)valor;
                        if (fechaHere.HasValue)
                        {
                            hojaDirectores.Cell(fila, col + 3).Value = fechaHere.Value;
                            hojaDirectores.Cell(fila, col + 3).Style.DateFormat.Format = "dd/MM/yyyy";
                        }
                        else
                        {
                            hojaDirectores.Cell(fila, col + 3).Value = "";
                        }
                    }
                    else
                    {
                        hojaDirectores.Cell(fila, col + 3).Value = valor?.ToString() ?? "";
                    }
                }

                fila++;
            }

            var stream = new MemoryStream();
            workbook.SaveAs(stream);
            stream.Position = 0;
            return stream;
        }

        private Stream GenerarPdf(List<EmpresaDocResult> empresas, List<DirectorDocResult> directores)
        {
            var listaEmpresas = empresas.ToList();
            var listaDirectores = directores.ToList();

            QuestPDF.Settings.License = LicenseType.Community;

            var documento = Document.Create(container =>
            {
                container.Page(page =>
                {
                    var propiedadesEmpresas = typeof(EmpresaDocResult)
                        .GetProperties()
                        .Where(p => p.Name != "Id")
                        .ToArray();

                    page.Size(PageSizes.A4.Landscape());
                    page.Margin(20);
                    page.DefaultTextStyle(x => x.FontSize(7));
                    page.Header().Text("Lista de Empresas").SemiBold().FontSize(14).AlignCenter();

                    page.Content().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            for (int i = 0; i < encabezadosEmpresas.Length; i++)
                                columns.RelativeColumn(1);
                        });

                        table.Header(header =>
                        {
                            foreach (var h in encabezadosEmpresas)
                                header.Cell().Element(CellStyle).Text(h);
                        });

                        foreach (var item in listaEmpresas)
                        {
                            foreach (var propiedad in propiedadesEmpresas)
                            {
                                var valor = propiedad.GetValue(item);
                                var texto = valor is decimal d ? d.ToString("N2") : valor?.ToString() ?? "";
                                table.Cell().Element(CellStyle).Text(texto);
                            }
                        }
                    });
                });

                container.Page(page =>
                {

                    var propiedadesDirectores = typeof(DirectorDocResult)
                        .GetProperties()
                        .Where(p => p.Name != "IdEmpresa" && p.Name != "IdRegistro")
                        .ToArray();

                    page.Size(PageSizes.A4.Landscape());
                    page.Margin(20);
                    page.DefaultTextStyle(x => x.FontSize(6));
                    page.Header().Text("Lista de Directores").SemiBold().FontSize(14).AlignCenter();

                    page.Content().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            for (int i = 0; i < encabezadosDirectores.Length; i++)
                                columns.RelativeColumn(1);
                        });

                        table.Header(header =>
                        {
                            foreach (var h in encabezadosDirectores)
                                header.Cell().Element(CellStyle).Text(h);
                        });

                        foreach (var director in listaDirectores)
                        {
                            var empresa = listaEmpresas.FirstOrDefault(e => e.Id == director.IdEmpresa);
                            table.Cell().Element(CellStyle).Text(empresa?.Ruc ?? "");
                            table.Cell().Element(CellStyle).Text(empresa?.RazonSocial ?? "");

                            foreach (var propiedad in propiedadesDirectores)
                            {
                                var valor = propiedad.GetValue(director);
                                string texto = valor switch
                                {
                                    DateTime dt => dt.ToString("yyyy-MM-dd"),
                                    decimal d => d.ToString("N2"),
                                    _ => valor?.ToString() ?? ""
                                };
                                table.Cell().Element(CellStyle).Text(texto);
                            }
                        }
                    });
                });
            });

            var stream = new MemoryStream();
            documento.GeneratePdf(stream);
            stream.Position = 0;
            return stream;
        }

        static IContainer CellStyle(IContainer container)
        {
            return container
                .Padding(0)
                .Border(1)
                .BorderColor(Colors.Grey.Lighten2)
                .AlignMiddle();
        }
    }
}
