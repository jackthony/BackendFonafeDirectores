/*****
 * Nombre del archivo:  ListarConstantesPaginadoRequestValidator.cs
 * Descripción:         Clase que extiende `PagedRequest` y se utiliza para validar solicitudes de listado paginado de constantes. 
 *                      Actualmente no contiene validaciones adicionales, pero está diseñada para ser extendida con reglas de validación en el futuro.
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
using Shared.Kernel.Requests;

namespace Empresa.Application.Constantes.Validators
{
    public class ListarConstantesPaginadoRequestValidator : PagedRequest {    }
}
