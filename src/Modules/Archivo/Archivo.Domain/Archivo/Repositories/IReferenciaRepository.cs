/*****
 * Nombre del archivo:  IReferenciaRepository.cs
 * Descripción:         Interfaz que define los métodos para obtener referencias de diversos tipos de datos relacionados con empresas y entidades gubernamentales. 
 *                      Incluye operaciones para obtener listas de empresas, provincias, departamentos, distritos, rubros, ministerios, y otros datos relevantes.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz.
 *****/
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
        Task<List<ReferenciaResult>> GetTiposDirectorAsync();
        Task<List<ReferenciaResult>> GetDirectoresAsync();

    }
}
