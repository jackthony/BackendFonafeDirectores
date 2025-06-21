using Especialidad.Application.Dtos;
using Especialidad.Presentation.Dtos.Request;
using Especialidad.Presentation.Dtos.Responses;
using Especialidad.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Especialidad.Presentation.Presenters
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
