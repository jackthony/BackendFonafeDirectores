using Modulo.Application.Dtos;
using Modulo.Presentation.Dtos.Request;
using Modulo.Presentation.Dtos.Responses;
using Modulo.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Modulo.Presentation.Presenters
{
    public class ListarModuloPresenter : IPresenter<
        ListarModuloClientRequest,
        ListarModuloRequest,
        List<ModuloDto>,
        LstItemResponse<ModuloClientDto>>
    {
        public ListarModuloRequest ToRequest(ListarModuloClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<ModuloClientDto> ToResponse(List<ModuloDto> dto)
        {
            return new LstItemResponse<ModuloClientDto>
            {
                LstItem = ModuloClientMapper.ToClientDtos(dto),
                IsSuccess = true
            };
        }
    }
}
