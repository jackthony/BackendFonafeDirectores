using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Results;

namespace Archivo.Application.Archivo.Helpers
{
    public static class ArchivoResultExtensions
    {
        public static List<ArchivoParaZip> GenerarArchivosParaZip(List<ArchivoResult> archivos)
        {
            var index = archivos.ToDictionary(x => x.ElementoId);

            return archivos
                .Where(x => x.EsDocumento && !string.IsNullOrWhiteSpace(x.UrlStorage))
                .Select(x => new ArchivoParaZip
                {
                    Url = x.UrlStorage!,
                    RutaEnZip = ConstruirRutaRelativa(x, index)
                })
                .ToList();
        }

        private static string ConstruirRutaRelativa(ArchivoResult archivo, Dictionary<int, ArchivoResult> index)
        {
            var segmentos = new Stack<string>();
            var actual = archivo;

            while (actual != null)
            {
                segmentos.Push(actual.Nombre);

                if (actual.CarpetaPadreId == null || !index.TryGetValue(actual.CarpetaPadreId.Value, out actual))
                    break;
            }

            return string.Join("/", segmentos);
        }
    }
}
