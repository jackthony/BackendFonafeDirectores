using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivo.Infrastructure.Archivo.Helpers
{
    public class ValidacionResultado<T>
    {
        public List<T> RegistrosValidos { get; set; } = [];
        public List<string> Errores { get; set; } = [];
        public bool TieneErrores => Errores.Count != 0;
    }
}
