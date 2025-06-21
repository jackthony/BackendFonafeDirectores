using Usuario.Application.Dtos;
using Usuario.Presentation.Dtos.Responses;
using Usuario.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Usuario.Presentation.Presenters
{
    public class ObtenerUsuarioPorIdPresenter : IPresenter<
        int,
        long,
        UsuarioDto,
        ItemResponse<UsuarioClientDto>>
    {
        public long ToRequest(int clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<UsuarioClientDto> ToResponse(UsuarioDto dto)
        {
            return new ItemResponse<UsuarioClientDto>
            {
                IsSuccess = true,
                Item = UsuarioClientMapper.ToClientDto(dto),
            };
        }
    }
}
