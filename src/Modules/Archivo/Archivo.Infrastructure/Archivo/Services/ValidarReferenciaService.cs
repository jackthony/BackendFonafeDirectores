using Archivo.Application.Archivo.Services;
using Archivo.Domain.Archivo.Repositories;
using Archivo.Domain.Archivo.Results;
using Archivo.Infrastructure.Archivo.Helpers;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Empresa.Parameters;
using Shared.Time;
using System.Globalization;
using System.Text;

namespace Archivo.Infrastructure.Archivo.Services
{
    public class ValidarReferenciaService(IReferenciaRepository referenciaRepository, ITimeProvider timeProvider) : IValidarReferenciaService
    {
        private readonly IReferenciaRepository _referenciaRepository = referenciaRepository;
        private readonly ITimeProvider _timeProvider = timeProvider;

        private List<ReferenciaResult> _departamentos = [];
        private List<ReferenciaResult> _provincias = [];
        private List<ReferenciaResult> _distritos = [];
        private List<ReferenciaResult> _rubros = [];
        private List<ReferenciaResult> _ministerios = [];
        private List<ReferenciaResult> _tiposDocumento = [];
        private List<ReferenciaResult> _generos = [];
        private List<ReferenciaResult> _cargosDirector = [];
        private List<ReferenciaResult> _cargos = [];
        private List<ReferenciaResult> _sectores = [];
        private List<ReferenciaResult> _especialidades = [];
        private List<ReferenciaResult> _empresas = [];
        private List<ReferenciaResult> _tiposDirector = [];
        private List<ReferenciaResult> _directores = [];

        public async Task CargarReferenciasAsync()
        {
            _departamentos = await _referenciaRepository.GetDepartamentosAsync();
            _provincias = await _referenciaRepository.GetProvinciasAsync();
            _distritos = await _referenciaRepository.GetDistritosAsync();
            _rubros = await _referenciaRepository.GetRubrosAsync();
            _ministerios = await _referenciaRepository.GetMinisteriosAsync();
            _tiposDocumento = await _referenciaRepository.GetTiposDocumentoAsync();
            _generos = await _referenciaRepository.GetGenerosAsync();
            _cargosDirector = await _referenciaRepository.GetCargosDirectorAsync();
            _cargos = await _referenciaRepository.GetCargosAsync();
            _sectores = await _referenciaRepository.GetSectoresAsync();
            _especialidades = await _referenciaRepository.GetEspecialidadesAsync();
            _empresas = await _referenciaRepository.GetEmpresasAsync();
            _tiposDirector = await _referenciaRepository.GetTiposDirectorAsync();
            _directores = await _referenciaRepository.GetDirectoresAsync();
        }

        public async Task CargarEmpresasAsync()
        {
            _empresas = await _referenciaRepository.GetEmpresasAsync();
        }


        public ValidacionResultado<CrearDirectorParameters> ValidarDirectores(List<DirectorDocResult> directores, int usuarioId)
        {
            var resultado = new ValidacionResultado<CrearDirectorParameters>();
            int departamentoId, provinciaId, distritoId;
            foreach (var e in directores)
            {
                try
                {
                    var empresa = _empresas.FirstOrDefault(x => Normalizar(x.Nombre) == Normalizar(e.Ruc));

                    if (empresa == null)
                    {
                        resultado.Errores.Add($"No se encontró empresa con RUC '{e.Ruc}' para el director '{e.Nombres} {e.Apellidos}' (ID Registro: {e.IdRegistro})");
                        continue;
                    }

                    var errores = new List<string>();

                    if (!Existe(e.TipoDocumento, _tiposDocumento))
                        errores.Add($"Tipo de documento inválido: '{e.TipoDocumento}'");


                    if (!TryObtenerId(e.Departamento, _departamentos, out departamentoId))
                        errores.Add($"Departamento inválido: '{e.Departamento}'");

                    if (!TryObtenerId(e.Provincia, [.. _provincias.Where(p => p.ReferenceId == departamentoId)], out provinciaId))
                        errores.Add($"Provincia inválida: '{e.Provincia}'");

                    if (!TryObtenerId(e.Distrito, [.. _distritos.Where(d => d.ReferenceId == provinciaId)], out distritoId))
                        errores.Add($"Distrito inválido: '{e.Distrito}'");

                    if (!Existe(e.Genero, _generos))
                        errores.Add($"Género inválido: '{e.Genero}'");

                    if (!Existe(e.Cargo, _cargosDirector))
                        errores.Add($"Cargo inválido: '{e.Cargo}'");

                    if (!Existe(e.TipoDirector, _tiposDirector))
                        errores.Add($"Tipo director inválido: '{e.TipoDirector}'");

                    if (!Existe(e.Sector, _sectores))
                        errores.Add($"Sector inválido: '{e.Sector}'");

                    if (!Existe(e.Especialidad, _especialidades))
                        errores.Add($"Especialidad inválida: '{e.Especialidad}'");

                    if (errores.Count != 0)
                    {
                        resultado.Errores.Add($"Director '{e.Nombres} {e.Apellidos}': " + string.Join(", ", errores));
                        continue;
                    }

                    var item = new CrearDirectorParameters
                    {
                        IdEmpresa = empresa.Id,
                        TipoDocumento = ObtenerId(e.TipoDocumento, _tiposDocumento),
                        NumeroDocumento = e.Documento,
                        Nombres = e.Nombres,
                        Apellidos = e.Apellidos,
                        FechaNacimiento = e.FechaNacimiento ?? throw new Exception("FechaNacimiento es requerida"),
                        Genero = ObtenerId(e.Genero, _generos),
                        Departamento = departamentoId,
                        Provincia = provinciaId,
                        Distrito = distritoId,
                        Direccion = e.Direccion,
                        Telefono = e.Telefono,
                        Correo = e.Correo,
                        TelefonoSecundario = null,
                        TelefonoTerciario = null,
                        CorreoSecundario = null,
                        CorreoTerciario = null,
                        Cargo = ObtenerId(e.Cargo, _cargosDirector),
                        TipoDirector = ObtenerId(e.TipoDirector, _tiposDirector),
                        nSectorId = ObtenerId(e.Sector, _sectores),
                        Profesion = e.Profesion,
                        Dieta = e.Dieta ?? 0,
                        Especialidad = ObtenerId(e.Especialidad, _especialidades),
                        FechaNombramiento = e.FechaNombramiento ?? throw new Exception("FechaNombramiento es requerida"),
                        FechaDesignacion = e.FechaDesignacion ?? throw new Exception("FechaDesignacion es requerida"),
                        Comentario = e.Comentarios,
                        FechaRegistro = _timeProvider.NowPeru,
                        UsuarioRegistro = usuarioId
                    };

                    if (_directores.Any(d => d.Nombre == e.Documento))
                        resultado.RegistrosUpdate.Add(item);
                    else
                        resultado.RegistrosValidos.Add(item);
                }
                catch (Exception ex)
                {
                    resultado.Errores.Add($"Error en registro {e.IdRegistro} - {ex.Message}");
                }
            }

            return resultado;
        }


        public ValidacionResultado<CrearEmpresaParameters> ValidarEmpresas(List<EmpresaDocResult> empresas, int usuarioId)
        {
            var resultado = new ValidacionResultado<CrearEmpresaParameters>();
            int departamentoId, provinciaId, distritoId;
            foreach (var e in empresas)
            {
                var errores = new List<string>();
                var esDuplicado = false;

                if (Existe(e.Ruc, _empresas) || Existe(e.RazonSocial, _empresas))
                {
                    esDuplicado = true;
                }

                if (!TryObtenerId(e.Departamento, _departamentos, out departamentoId))
                    errores.Add($"Departamento inválido: '{e.Departamento}'");

                if (!TryObtenerId(e.Provincia, [.. _provincias.Where(p => p.ReferenceId == departamentoId)], out provinciaId))
                    errores.Add($"Provincia inválida: '{e.Provincia}'");

                if (!TryObtenerId(e.Distrito, [.. _distritos.Where(d => d.ReferenceId == provinciaId)], out distritoId))
                    errores.Add($"Distrito inválido: '{e.Distrito}'");

                if (!Existe(e.Rubro, _rubros))
                    errores.Add($"Rubro inválido: '{e.Rubro}'");

                if (!Existe(e.Sector, _ministerios))
                    errores.Add($"Sector inválido: '{e.Sector}'");

                if (errores.Count != 0)
                {
                    resultado.Errores.Add($"Empresa '{e.RazonSocial}': " + string.Join(", ", errores));
                    continue;
                }

                var item = new CrearEmpresaParameters
                {
                    Ruc = e.Ruc,
                    RazonSocial = e.RazonSocial,
                    IdDepartamento = departamentoId,
                    IdProvincia = provinciaId,
                    IdDistrito = distritoId,
                    Direccion = e.Direccion,
                    IdRubroNegocio = ObtenerId(e.Rubro, _rubros),
                    IdSector = ObtenerId(e.Sector, _ministerios),
                    IngresosUltimoAnio = e.Ingresos,
                    UtilidadUltimoAnio = e.Utilidades,
                    ConformacionCapitalSocial = e.CapitalSocial,
                    NumeroMiembros = e.CantidadMiembros,
                    RegistradoMercadoValores = EsVerdadero(e.RegistroEnMercado),
                    Activo = EsVerdadero(e.Activo),
                    Comentario = e.Comentario,
                    UsuarioRegistro = usuarioId,
                    FechaRegistro = _timeProvider.NowPeru
                };

                if (esDuplicado)
                    resultado.RegistrosUpdate.Add(item);
                else
                    resultado.RegistrosValidos.Add(item);
            }

            return resultado;
        }

        private static bool TryObtenerId(string? valor, List<ReferenciaResult> lista, out int id)
        {
            var normalizado = Normalizar(valor);
            var item = lista.FirstOrDefault(x => Normalizar(x.Nombre) == normalizado);

            if (item != null)
            {
                id = item.Id;
                return true;
            }

            id = 0;
            return false;
        }

        private static string Normalizar(string? texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return string.Empty;
            var normalized = texto.Trim().ToUpperInvariant().Normalize(NormalizationForm.FormD);

            var sb = new StringBuilder();
            foreach (var c in normalized)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }

            return sb.ToString();
        }

        private static bool Existe(string? valor, List<ReferenciaResult> lista)
        {
            return lista.Any(x => Normalizar(x.Nombre) == Normalizar(valor));
        }

        private static int ObtenerId(string? valor, List<ReferenciaResult> lista)
        {
            return lista.First(x => Normalizar(x.Nombre) == Normalizar(valor)).Id;
        }

        private static bool EsVerdadero(string? valor)
        {
            if (string.IsNullOrWhiteSpace(valor)) return false;

            var normalizado = Normalizar(valor);

            return normalizado == "SI";
        }
    }
}
