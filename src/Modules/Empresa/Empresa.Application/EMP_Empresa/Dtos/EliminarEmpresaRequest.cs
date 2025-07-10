/*****
 * Nombre del archivo:  EliminarEmpresaRequest.cs
 * Descripción:         Define el DTO para eliminar una empresa existente.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Se ha configurado el DTO para la eliminación de una empresa, incluyendo los campos necesarios para la operación.
 *****/
using Shared.Kernel.Interfaces;

namespace Empresa.Application.Empresa.Dtos
{
    public class EliminarEmpresaRequest : ITrackableRequest
    {
        public int nIdEmpresa { get; set; }
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Empresa";
        public string CampoId => "nEmpresaId";
        public int? ValorId => nIdEmpresa;
        public string Movimiento => "Delete";
    }
}
