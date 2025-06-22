using Empresa.Application.EMP_Especialidad.Dtos;
using Empresa.Presentation.EMP_Especialidad.Dtos.Request;
using Empresa.Presentation.EMP_Especialidad.Dtos.Responses;
using Empresa.Presentation.EMP_Especialidad.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Especialidad.Presenters
{
    public class ListarEspecialidadPaginadoPresenter : IPresenter<
    ListarEspecialidadPaginadoClientRequest,
    ListarEspecialidadPaginadoRequest,
    PagedResult<EspecialidadDto>,
    LstItemResponse<EspecialidadClientDto>>
    {
        public ListarEspecialidadPaginadoRequest ToRequest(ListarEspecialidadPaginadoClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<EspecialidadClientDto> ToResponse(PagedResult<EspecialidadDto> dto)
        {
            return new LstItemResponse<EspecialidadClientDto>
            {
                LstItem = EspecialidadClientMapper.ToClientDtos(dto.Items),
                Pagination = new Pagination
                {
                    PageIndex = dto.Page,
                    PageSize = dto.PageSize,
                    TotalRows = dto.TotalItems
                },
                IsSuccess = true
            };
        }
    }
}
