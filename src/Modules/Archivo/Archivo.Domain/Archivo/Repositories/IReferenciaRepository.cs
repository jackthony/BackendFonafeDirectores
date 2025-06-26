using Archivo.Domain.Archivo.Results;
using Empresa.Domain.Empresa.Results;
using Empresa.Domain.Especialidad.Results;
using Empresa.Domain.Ministerio.Results;
using Empresa.Domain.Rubro.Results;
using Empresa.Domain.Sector.Results;
using Empresa.Domain.Ubigeo.Results;
using Shared.Kernel.Responses;

namespace Archivo.Domain.Archivo.Repositories
{
    public interface IReferenciaRepository
    {
        Task<List<ReferenciaResult>> GetEmpresasAsync();
        Task<List<ReferenciaResult>> GetProvinciasAsync();
        Task<List<ReferenciaResult>> GetDepartamentosAsync();
        Task<List<ReferenciaResult>> GetDistritosAsync();
        Task<List<ReferenciaResult>> GetRubrosAsync();
        Task<List<ReferenciaResult>> GetMinisteriosAsync();
        Task<List<ReferenciaResult>> GetGenerosAsync();
        Task<List<ReferenciaResult>> GetTiposDocumentoAsync();
        Task<List<ReferenciaResult>> GetCargosDirectorAsync();
        Task<List<ReferenciaResult>> GetTiposPersonalAsync();
        Task<List<ReferenciaResult>> GetSectoresAsync();
        Task<List<ReferenciaResult>> GetEspecialidadesAsync();
        Task<List<ReferenciaResult>> GetCargosAsync();
    }
}
