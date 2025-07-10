/***********
 * Nombre del archivo:  IPresenter.cs
 * Descripción:         Interfaz genérica para presentadores responsables de transformar solicitudes del cliente
 *                      en solicitudes internas del sistema, y DTOs internos en respuestas para el cliente.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz.
 ***********/

namespace Shared.Kernel.Interfaces
{
    public interface IPresenter<TClientRequest, TInternalRequest, TInternalDto, TClientResponse>
    {
        TInternalRequest ToRequest(TClientRequest clientRequest);
        TClientResponse ToResponse(TInternalDto dto);
    }
}
