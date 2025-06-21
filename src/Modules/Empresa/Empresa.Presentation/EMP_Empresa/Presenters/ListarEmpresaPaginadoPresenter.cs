using Empresa.Application.EMP_Empresa.Dtos;
using Empresa.Presentation.EMP_Empresa.Dtos.Request;
using Empresa.Presentation.EMP_Empresa.Dtos.Responses;
using Empresa.Presentation.EMP_Empresa.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Empresa.Presenters
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
