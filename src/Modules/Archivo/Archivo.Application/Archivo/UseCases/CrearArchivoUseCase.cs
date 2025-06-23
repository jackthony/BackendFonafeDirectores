using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Archivo.Application.Auth.Services;
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Parameters;
using Archivo.Domain.Archivo.Repositories;

namespace Archivo.Application.Archivo.UseCases
{
    public class CrearArchivoUseCase : IUseCase<CrearArchivoRequest, SpResultBase>
    {
        private readonly IArchivoRepository _repository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IMapper<CrearArchivoRequest, CrearArchivoParameters> _mapper;

        public CrearArchivoUseCase(IArchivoRepository repository, IPasswordHasher passwordHasher, IMapper<CrearArchivoRequest, CrearArchivoParameters> mapper)
        {
            _repository = repository;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearArchivoRequest request)
        {
            request.Password = _passwordHasher.Hash(request.Password);
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
