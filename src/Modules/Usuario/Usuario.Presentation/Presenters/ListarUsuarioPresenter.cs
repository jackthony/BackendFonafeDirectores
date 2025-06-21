using Usuario.Application.Dtos;
using Usuario.Presentation.Dtos.Request;
using Usuario.Presentation.Dtos.Responses;
using Usuario.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Usuario.Presentation.Presenters
{
    public class ListarUsuarioPresenter : IPresenter<
        ListarUsuarioClientRequest,
        ListarUsuarioRequest,
        List<UsuarioDto>,
        LstItemResponse<UsuarioClientDto>>
    {
        public ListarUsuarioRequest ToRequest(ListarUsuarioClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<UsuarioClientDto> ToResponse(List<UsuarioDto> dto)
        {
            return new LstItemResponse<UsuarioClientDto>
            {
                LstItem = UsuarioClientMapper.ToClientDtos(dto),
                IsSuccess = true
            };
        }
    }
}
