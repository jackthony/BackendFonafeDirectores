/*****
 * Nombre del archivo:  CrearEmpresaUseCase.cs
 * Descripción:         Lógica de negocio para crear una nueva empresa. Recibe un request con los datos de la empresa, lo mapea a parámetros 
 *                      y luego lo pasa al repositorio para realizar la creación en la base de datos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación de la lógica para crear una nueva empresa, con manejo de errores.
 *****/
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Empresa.Dtos;
using Empresa.Domain.Empresa.Parameters;
using Empresa.Domain.Empresa.Repositories;

namespace Empresa.Application.Empresa.UseCases
{
    public class CrearEmpresaUseCase : IUseCase<CrearEmpresaRequest, SpResultBase>
    {
        private readonly IEmpresaRepository _repository;
        private readonly IMapper<CrearEmpresaRequest, CrearEmpresaParameters> _mapper;

        public CrearEmpresaUseCase(IEmpresaRepository repository, IMapper<CrearEmpresaRequest, CrearEmpresaParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearEmpresaRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
