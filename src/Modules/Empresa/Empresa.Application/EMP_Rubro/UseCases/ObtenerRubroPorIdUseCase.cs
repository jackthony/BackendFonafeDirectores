<<<<<<< HEAD
﻿using Empresa.Application.EMP_Rubro.Dtos;
using Empresa.Application.EMP_Rubro.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_Rubro.UseCases
{
    public class ObtenerRubroPorIdUseCase : IUseCase<long, RubroDto?>
    {
        private readonly IReadRubroRepository _repository;

        public ObtenerRubroPorIdUseCase(IReadRubroRepository repository)
=======
﻿using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Rubro.Repositories;
using Empresa.Domain.Rubro.Results;

namespace Empresa.Application.Rubro.UseCases
{
    public class ObtenerRubroPorIdUseCase : IUseCase<int, RubroResult?>
    {
        private readonly IRubroRepository _repository;

        public ObtenerRubroPorIdUseCase(IRubroRepository repository)
>>>>>>> origin/masterboa
        {
            _repository = repository;
        }

<<<<<<< HEAD
        public async Task<OneOf<ErrorBase, RubroDto?>> ExecuteAsync(long request)
=======
        public async Task<OneOf<ErrorBase, RubroResult?>> ExecuteAsync(int request)
>>>>>>> origin/masterboa
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
