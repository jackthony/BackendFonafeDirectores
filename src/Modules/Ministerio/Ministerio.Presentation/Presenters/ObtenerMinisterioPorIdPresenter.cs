using Ministerio.Application.Dtos;
using Ministerio.Presentation.Dtos.Responses;
using Ministerio.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Ministerio.Presentation.Presenters
{
    public class ObtenerMinisterioPorIdPresenter : IPresenter<
        int,
        long,
        MinisterioDto,
        ItemResponse<MinisterioClientDto>>
    {
        public long ToRequest(int clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<MinisterioClientDto> ToResponse(MinisterioDto dto)
        {
            return new ItemResponse<MinisterioClientDto>
            {
                IsSuccess = true,
                Item = MinisterioClientMapper.ToClientDto(dto),
            };
        }
    }
}
