using Cargo.Application.Dtos;
using Cargo.Presentation.Dtos.Request;
using Cargo.Presentation.Dtos.Responses;
using Cargo.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Cargo.Presentation.Presenters
{
    public class ListarCargoPaginadoPresenter : IPresenter<
        ListarCargoPaginadoClientRequest,
        ListarCargoPaginadoRequest,
        PagedResult<CargoDto>,
        LstItemResponse<CargoClientDto>>
    {
        public ListarCargoPaginadoRequest ToRequest(ListarCargoPaginadoClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<CargoClientDto> ToResponse(PagedResult<CargoDto> dto)
        {
            return new LstItemResponse<CargoClientDto>
            {
                LstItem = CargoClientMapper.ToClientDtos(dto.Items),
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
