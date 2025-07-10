/***********
 * Nombre del archivo:  IUbigeoRepository.cs
 * Descripción:         Interfaz del repositorio del módulo Ubigeo. Define los contratos para listar
 *                      departamentos, provincias y distritos, utilizando parámetros específicos por nivel.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz IUbigeoRepository.
 ***********/

using Empresa.Domain.Ubigeo.Parameters;
using Empresa.Domain.Ubigeo.Results;

namespace Empresa.Domain.Ubigeo.Repositories
{
    public interface IUbigeoRepository
    {
        public Task<List<DepartamentoResult>> ListDepartamentos(ListarDepartamentoParameters request);
        public Task<List<ProvinciaResult>> ListProvincias(ListarProvinciaParameters request);
        public Task<List<DistritoResult>> ListDistritos(ListarDistritoParameters request);

    }
}
