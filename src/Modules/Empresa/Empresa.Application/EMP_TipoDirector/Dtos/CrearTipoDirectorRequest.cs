/*****
 * Nombre del archivo:  CrearTipoDirectorRequest.cs
 * Descripción:         DTO que representa la solicitud para crear un nuevo tipo de director.
 *                      Implementa la interfaz ITrackableRequest para registrar información
 *                      de auditoría asociada al módulo EMPRESA y la tabla EMP_TipoDirector.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Shared.Kernel.Interfaces;

namespace Empresa.Application.TipoDirector.Dtos
{
    public class CrearTipoDirectorRequest : ITrackableRequest
    {
        public string sNombreTipoDirector { get; set; } = default!;
        public int nUsuarioRegistro { get; set; }

        public int UsuarioId => nUsuarioRegistro;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_TipoDirector";
        public string CampoId => "nTipoDirectorId";
        public int? ValorId => 0;
        public string Movimiento => "Create";
    }
}
