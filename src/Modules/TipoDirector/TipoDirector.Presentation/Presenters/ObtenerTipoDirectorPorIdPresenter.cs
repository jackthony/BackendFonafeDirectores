using TipoDirector.Application.Dtos;
using TipoDirector.Presentation.Dtos.Responses;
using TipoDirector.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace TipoDirector.Presentation.Presenters
{
    public class ObtenerTipoDirectorPorIdPresenter : IPresenter<
        int,
        long,
        TipoDirectorDto,
        ItemResponse<TipoDirectorClientDto>>
    {
        public long ToRequest(int clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<TipoDirectorClientDto> ToResponse(TipoDirectorDto dto)
        {
            return new ItemResponse<TipoDirectorClientDto>
            {
                IsSuccess = true,
                Item = TipoDirectorClientMapper.ToClientDto(dto),
            };
        }
    }
}
