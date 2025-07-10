/*****
 * Nombre del archivo:  CrearCargoRequest.cs
 * Descripción:         Clase que representa una solicitud para crear un nuevo cargo en el sistema. 
 *                      Implementa `ITrackableRequest` para rastrear las operaciones de creación, con propiedades como `sNombreCargo` y `nUsuarioRegistro`.
 *                      Incluye metadatos sobre el módulo, tabla y campo de la base de datos correspondientes al cargo que se va a crear.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;

namespace Empresa.Application.Cargo.Dtos
{
    public class CrearCargoRequest : ITrackableRequest
    {
        public string sNombreCargo { get; set; } = default!;
        public int nUsuarioRegistro { get; set; }

        public int UsuarioId => nUsuarioRegistro;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Cargo";
        public string CampoId => "nCargoId";
        public int? ValorId => null;
        public string Movimiento => "Create";
    }
}
