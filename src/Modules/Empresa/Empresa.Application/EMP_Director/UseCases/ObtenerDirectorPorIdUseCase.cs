<<<<<<< HEAD
﻿using Empresa.Application.EMP_Director.Dtos;
using Empresa.Application.EMP_Director.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_Director.UseCases
{
    public class ObtenerDirectorPorIdUseCase : IUseCase<long, DirectorDto?>
    {
        private readonly IReadDirectorRepository _repository;

        public ObtenerDirectorPorIdUseCase(IReadDirectorRepository repository)
=======
﻿using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Director.Repositories;
using Empresa.Domain.Director.Results;

namespace Empresa.Application.Director.UseCases
{
    public class ObtenerDirectorPorIdUseCase : IUseCase<int, DirectorResult?>
    {
        private readonly IDirectorRepository _repository;

        public ObtenerDirectorPorIdUseCase(IDirectorRepository repository)
>>>>>>> origin/masterboa
        {
            _repository = repository;
        }

<<<<<<< HEAD
        public async Task<OneOf<ErrorBase, DirectorDto?>> ExecuteAsync(long request)
=======
        public async Task<OneOf<ErrorBase, DirectorResult?>> ExecuteAsync(int request)
>>>>>>> origin/masterboa
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
