<<<<<<< HEAD
﻿using Empresa.Application.EMP_Ministerio.Dtos;
using Empresa.Application.EMP_Ministerio.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_Ministerio.UseCases
{
    public class ObtenerMinisterioPorIdUseCase : IUseCase<long, MinisterioDto?>
    {
        private readonly IReadMinisterioRepository _repository;

        public ObtenerMinisterioPorIdUseCase(IReadMinisterioRepository repository)
=======
﻿using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Ministerio.Repositories;
using Empresa.Domain.Ministerio.Results;

namespace Empresa.Application.Ministerio.UseCases
{
    public class ObtenerMinisterioPorIdUseCase : IUseCase<int, MinisterioResult?>
    {
        private readonly IMinisterioRepository _repository;

        public ObtenerMinisterioPorIdUseCase(IMinisterioRepository repository)
>>>>>>> origin/masterboa
        {
            _repository = repository;
        }

<<<<<<< HEAD
        public async Task<OneOf<ErrorBase, MinisterioDto?>> ExecuteAsync(long request)
=======
        public async Task<OneOf<ErrorBase, MinisterioResult?>> ExecuteAsync(int request)
>>>>>>> origin/masterboa
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
