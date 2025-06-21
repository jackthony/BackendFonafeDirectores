using Empresa.Application.EMP_Empresa.Dtos;
using Empresa.Presentation.EMP_Empresa.Dtos.Request;
using Empresa.Presentation.EMP_Empresa.Dtos.Responses;
using Empresa.Presentation.EMP_Empresa.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_Empresa.Presenters
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
