/*****
 * Nombre del archivo:  ValidacionResultado.cs
 * Descripción:         Clase genérica utilizada para almacenar el resultado de la validación de registros. 
 *                      Contiene listas de registros válidos, registros a actualizar y errores encontrados durante el proceso de validación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
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
        public List<T> RegistrosUpdate { get; set; } = [];
        public List<string> Errores { get; set; } = [];
        public bool TieneErrores => Errores.Count != 0;
    }
}
