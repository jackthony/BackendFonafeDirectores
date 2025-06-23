using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Auth.Services;
using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;
using Empresa.Domain.Ubigeo.Repositories;

namespace Empresa.Application.Ubigeo.UseCases
{
    public class CrearUbigeoUseCase : IUseCase<CrearUbigeoRequest, SpResultBase>
    {
        private readonly IUbigeoRepository _repository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IMapper<CrearUbigeoRequest, CrearUbigeoParameters> _mapper;

        public CrearUbigeoUseCase(IUbigeoRepository repository, IPasswordHasher passwordHasher, IMapper<CrearUbigeoRequest, CrearUbigeoParameters> mapper)
        {
            _repository = repository;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearUbigeoRequest request)
        {
            request.Password = _passwordHasher.Hash(request.Password);
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
