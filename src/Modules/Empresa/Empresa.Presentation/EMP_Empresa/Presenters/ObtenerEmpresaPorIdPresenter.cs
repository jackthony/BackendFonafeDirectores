using Empresa.Application.EMP_Empresa.Dtos;
using Empresa.Presentation.EMP_Empresa.Dtos.Responses;
using Empresa.Presentation.EMP_Empresa.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_Empresa.Presenters
{
    public class ObtenerEmpresaPorIdPresenter : IPresenter<
        int,
        long,
        EmpresaDto,
        ItemResponse<EmpresaClientDto>>
    {
        public long ToRequest(int clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<EmpresaClientDto> ToResponse(EmpresaDto dto)
        {
            return new ItemResponse<EmpresaClientDto>
            {
                IsSuccess = true,
                Item = EmpresaClientMapper.ToClientDto(dto),
            };
        }
    }
}
