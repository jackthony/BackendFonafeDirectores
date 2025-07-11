﻿/*****
 * Nombre del archivo:  ListarCargoPaginadoRequest.cs
 * Descripción:         Clase que representa una solicitud de listado paginado de cargos en el sistema. 
 *                      Hereda de `PagedRequest` y agrega propiedades opcionales como `Nombre` y `Estado` para filtrar los resultados de los cargos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Requests;

namespace Empresa.Application.Cargo.Dtos
{
    public class ListarCargoPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
