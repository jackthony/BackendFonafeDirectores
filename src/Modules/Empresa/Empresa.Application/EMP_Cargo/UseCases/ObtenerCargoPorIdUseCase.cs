<<<<<<< HEAD
﻿using Empresa.Application.EMP_Cargo.Dtos;
using Empresa.Application.EMP_Cargo.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_Cargo.UseCases
{
    public class ObtenerCargoPorIdUseCase : IUseCase<long, CargoDto?>
    {
        private readonly IReadCargoRepository _repository;

        public ObtenerCargoPorIdUseCase(IReadCargoRepository repository)
=======
﻿using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Cargo.Repositories;
using Empresa.Domain.Cargo.Results;

namespace Empresa.Application.Cargo.UseCases
{
    public class ObtenerCargoPorIdUseCase : IUseCase<int, CargoResult?>
    {
        private readonly ICargoRepository _repository;

        public ObtenerCargoPorIdUseCase(ICargoRepository repository)
>>>>>>> origin/masterboa
        {
            _repository = repository;
        }

<<<<<<< HEAD
        public async Task<OneOf<ErrorBase, CargoDto?>> ExecuteAsync(long request)
=======
        public async Task<OneOf<ErrorBase, CargoResult?>> ExecuteAsync(int request)
>>>>>>> origin/masterboa
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
