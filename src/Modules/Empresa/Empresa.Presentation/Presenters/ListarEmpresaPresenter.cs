using Empresa.Application.Dtos;
using Empresa.Presentation.Dtos.Request;
using Empresa.Presentation.Dtos.Responses;
using Empresa.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.Presenters
{
    public class ListarEmpresaPresenter : IPresenter<
        ListarEmpresaClientRequest,
        ListarEmpresaRequest,
        List<EmpresaDto>,
        LstItemResponse<EmpresaClientDto>>
    {
        public ListarEmpresaRequest ToRequest(ListarEmpresaClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<EmpresaClientDto> ToResponse(List<EmpresaDto> dto)
        {
            return new LstItemResponse<EmpresaClientDto>
            {
                LstItem = EmpresaClientMapper.ToClientDtos(dto),
                IsSuccess = true
            };
        }
    }
}
