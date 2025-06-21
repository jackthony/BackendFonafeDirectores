using Empresa.Application.EMP_Empresa.Dtos;
using Empresa.Presentation.Dtos.Request;
using Empresa.Presentation.Dtos.Responses;
using Empresa.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.Presenters
{
    public class ListarEmpresaPaginadoPresenter : IPresenter<
        ListarEmpresaPaginadoClientRequest,
        ListarEmpresaPaginadoRequest,
        PagedResult<EmpresaDto>,
        LstItemResponse<EmpresaClientDto>>
    {
        public ListarEmpresaPaginadoRequest ToRequest(ListarEmpresaPaginadoClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<EmpresaClientDto> ToResponse(PagedResult<EmpresaDto> dto)
        {
            return new LstItemResponse<EmpresaClientDto>
            {
                LstItem = EmpresaClientMapper.ToClientDtos(dto.Items),
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
