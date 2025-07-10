/***********
 * Nombre del archivo:  BaseRequest.cs
 * Descripción:         Clase base abstracta para solicitudes del cliente. Contiene propiedades comunes como
 *                      identificador de ticket, nombre del cliente, usuario, servidor y resultado general.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Shared.ClientV1
{
    public abstract class BaseRequest
    {
        public Guid Ticket { get; set; } = Guid.NewGuid();
        public string ClientName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string ServerName { get; set; } = string.Empty;
        public int Resultado { get; set; } = int.MaxValue;
    }
}
