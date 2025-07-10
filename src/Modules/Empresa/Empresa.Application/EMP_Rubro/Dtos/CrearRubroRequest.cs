/*****
 * Nombre de clase:     CrearRubroRequest
 * Descripción:         DTO utilizado para enviar los datos necesarios para registrar un nuevo rubro.
 *                      Implementa ITrackableRequest para permitir la trazabilidad del movimiento en auditorías.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para representar la solicitud de creación de rubros con trazabilidad.
 *****/

using Shared.Kernel.Interfaces;

namespace Empresa.Application.Rubro.Dtos
{
    public class CrearRubroRequest : ITrackableRequest
    {
        public string sNombreRubro { get; set; } = default!;
        public int nUsuarioRegistro { get; set; }

        public int UsuarioId => nUsuarioRegistro;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Rubro";
        public string CampoId => "nRubroId";
        public int? ValorId => null;
        public string Movimiento => "Create";
    }
}
