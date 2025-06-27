<<<<<<< HEAD
﻿using Empresa.Application.EMP_Especialidad.Dtos;
using Empresa.Application.EMP_Especialidad.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.EMP_Especialidad.UseCases
{
    public class ObtenerEspecialidadPorIdUseCase : IUseCase<long, EspecialidadDto?>
    {
        private readonly IReadEspecialidadRepository _repository;

        public ObtenerEspecialidadPorIdUseCase(IReadEspecialidadRepository repository)
=======
﻿using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Especialidad.Repositories;
using Empresa.Domain.Especialidad.Results;

namespace Empresa.Application.Especialidad.UseCases
{
    public class ObtenerEspecialidadPorIdUseCase : IUseCase<int, EspecialidadResult?>
    {
        private readonly IEspecialidadRepository _repository;

        public ObtenerEspecialidadPorIdUseCase(IEspecialidadRepository repository)
>>>>>>> origin/masterboa
        {
            _repository = repository;
        }

<<<<<<< HEAD
        public async Task<OneOf<ErrorBase, EspecialidadDto?>> ExecuteAsync(long request)
=======
        public async Task<OneOf<ErrorBase, EspecialidadResult?>> ExecuteAsync(int request)
>>>>>>> origin/masterboa
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
