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
        Task<List<EmpresaResult>> GetEmpresasAsync();
        Task<List<ProvinciaResult>> GetProvinciasAsync();
        Task<List<DepartamentoResult>> GetDepartamentosAsync();
        Task<List<DistritoResult>> GetDistritosAsync();
        Task<List<RubroResult>> GetRubrosAsync();
        Task<List<MinisterioResult>> GetMinisteriosAsync();
        Task<List<ConstanteItemResponse>> GetGenerosAsync();
        Task<List<ConstanteItemResponse>> GetTiposDocumentoAsync();
        Task<List<ConstanteItemResponse>> GetCargosDirectorAsync();
        Task<List<ConstanteItemResponse>> GetTiposPersonalAsync();
        Task<List<SectorResult>> GetSectoresAsync();
        Task<List<EspecialidadResult>> GetEspecialidadesAsync();
    }
}
