﻿/*****
 * Nombre de clase:     CrearRubroUseCase
 * Descripción:         Caso de uso encargado de registrar un nuevo rubro en el sistema.
 *                      Realiza el mapeo del DTO recibido hacia los parámetros de dominio y ejecuta la operación de inserción.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para manejar la lógica de creación de rubros.
 *****/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;
using Empresa.Domain.Rubro.Repositories;

namespace Empresa.Application.Rubro.UseCases
{
    public class CrearRubroUseCase : IUseCase<CrearRubroRequest, SpResultBase>
    {
        private readonly IRubroRepository _repository;
        private readonly IMapper<CrearRubroRequest, CrearRubroParameters> _mapper;

        public CrearRubroUseCase(IRubroRepository repository, IMapper<CrearRubroRequest, CrearRubroParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearRubroRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
