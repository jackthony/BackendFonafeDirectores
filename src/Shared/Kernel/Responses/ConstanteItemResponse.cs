/***********
 * Nombre del archivo:  ConstanteItemResponse.cs
 * Descripción:         Clase que representa un ítem constante utilizado comúnmente para listas desplegables
 *                      o configuraciones fijas, incluyendo código, valor y descripción.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.Kernel.Responses
{
    public class ConstanteItemResponse
    {
        public int nConCodigo { get; set; }
        public int nConValor { get; set; }
        public string sConDescripcion { get; set; } = string.Empty;
    }
}
