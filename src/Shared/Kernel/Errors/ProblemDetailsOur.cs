/***********
 * Nombre del archivo:  ProblemDetailsOur.cs
 * Descripción:         Clase personalizada que extiende `ProblemDetails` de ASP.NET Core para incluir
 *                      una propiedad adicional (`showToast`) que indica si el error debe mostrarse como notificación.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

using Microsoft.AspNetCore.Mvc;

namespace Shared.Kernel.Errors
{
    public class ProblemDetailsOur : ProblemDetails
    {
        public bool showToast { get; set; }
    }
}
