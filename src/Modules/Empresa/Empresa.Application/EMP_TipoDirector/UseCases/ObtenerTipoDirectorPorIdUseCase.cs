<<<<<<< HEAD
﻿using Empresa.Application.EMP_TipoDirector.Dtos;
using Empresa.Application.EMP_TipoDirector.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_TipoDirector.UseCases
{
    public class ObtenerTipoDirectorPorIdUseCase : IUseCase<long, TipoDirectorDto?>
    {
        private readonly IReadTipoDirectorRepository _repository;

        public ObtenerTipoDirectorPorIdUseCase(IReadTipoDirectorRepository repository)
=======
﻿using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.TipoDirector.Repositories;
using Empresa.Domain.TipoDirector.Results;

namespace Empresa.Application.TipoDirector.UseCases
{
    public class ObtenerTipoDirectorPorIdUseCase : IUseCase<int, TipoDirectorResult?>
    {
        private readonly ITipoDirectorRepository _repository;

        public ObtenerTipoDirectorPorIdUseCase(ITipoDirectorRepository repository)
>>>>>>> origin/masterboa
        {
            _repository = repository;
        }

<<<<<<< HEAD
        public async Task<OneOf<ErrorBase, TipoDirectorDto?>> ExecuteAsync(long request)
=======
        public async Task<OneOf<ErrorBase, TipoDirectorResult?>> ExecuteAsync(int request)
>>>>>>> origin/masterboa
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
