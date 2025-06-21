using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Application.EMP_Director.Dtos;
using Shared.Kernel.Responses;

namespace Empresa.Application.EMP_Director.Repositories
{
    public interface IReadDirectorRepository
    {
        Task<List<DirectorDto>> ListAsync(ListarDirectorRequest request);
        Task<DirectorDto?> GetByIdAsync(long id);
        Task<PagedResult<DirectorDto>> ListByPaginationAsync(ListarDirectorPaginadoRequest request);
    }
}
