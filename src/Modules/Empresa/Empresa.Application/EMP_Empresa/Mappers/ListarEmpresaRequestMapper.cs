﻿/*****
 * Nombre del archivo:  ListarEmpresaRequestMapper.cs
 * Descripción:         Mapea un objeto de tipo ListarEmpresaRequest a ListarEmpresaParameters.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación de un mapeo vacío que probablemente se completará más adelante según los requerimientos.
 *****/
using Shared.Kernel.Interfaces;
using Empresa.Application.Empresa.Dtos;
using Empresa.Domain.Empresa.Parameters;

namespace Empresa.Application.Empresa.Mappers
{
    public class ListarEmpresaRequestMapper : IMapper<ListarEmpresaRequest, ListarEmpresaParameters>
    {
        public ListarEmpresaParameters Map(ListarEmpresaRequest source)
        {
            return new ListarEmpresaParameters 
            {
            };
        }
    }
}
