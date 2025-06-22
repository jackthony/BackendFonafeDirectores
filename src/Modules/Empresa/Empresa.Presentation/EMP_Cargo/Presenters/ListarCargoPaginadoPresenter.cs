using Empresa.Application.EMP_Cargo.Dtos;
using Empresa.Presentation.EMP_Cargo.Dtos.Request;
using Empresa.Presentation.EMP_Cargo.Dtos.Responses;
using Empresa.Presentation.EMP_Cargo.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Cargo.Presenters
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
