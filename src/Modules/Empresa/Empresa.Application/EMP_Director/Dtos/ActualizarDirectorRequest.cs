﻿/*****
 * Nombre del archivo:  ActualizarDirectorRequest.cs
 * Descripción:         Clase que representa una solicitud para actualizar la información de un director en el sistema. 
 *                      Incluye propiedades como `nIdRegistro`, `nIdEmpresa`, `sDepartamento`, `sTelefono`, entre otras, que permiten actualizar los datos relacionados con un director específico.
 *                      Implementa la interfaz `ITrackableRequest` para realizar un seguimiento de los cambios.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;

namespace Empresa.Application.Director.Dtos
{
    public class ActualizarDirectorRequest : ITrackableRequest
    {
        public int nIdRegistro { get; set; }
        public int nIdEmpresa { get; set; }
        public string sDepartamento { get; set; } = string.Empty;
        public string sProvincia { get; set; } = string.Empty;
        public string sDistrito { get; set; } = string.Empty;
        public string sDireccion { get; set; } = string.Empty;
        public string sTelefono { get; set; } = string.Empty;
        public string sTelefonoSecundario { get; set; } = string.Empty;
        public string sTelefonoTerciario { get; set; } = string.Empty;
        public string sCorreo { get; set; } = string.Empty;
        public string sCorreoSecundario { get; set; } = string.Empty;
        public string sCorreoTerciario { get; set; } = string.Empty;
        public int nCargo { get; set; }
        public int nTipoDirector { get; set; }
        public string sProfesion { get; set; } = string.Empty;
        public int nIdSector { get; set; }
        public decimal mDieta { get; set; }
        public int nEspecialidad { get; set; }
        public DateTime dFechaNombramiento { get; set; }
        public DateTime dFechaDesignacion { get; set; }
        public DateTime? dFechaRenuncia { get; set; }
        public string sComentario { get; set; } = string.Empty;
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Director";
        public string CampoId => "nDirectorId";
        public int? ValorId => nIdRegistro;
        public string Movimiento => "Update";
    }
}
