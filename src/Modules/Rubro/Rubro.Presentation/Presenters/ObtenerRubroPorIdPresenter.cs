using Rubro.Application.Dtos;
using Rubro.Presentation.Dtos.Responses;
using Rubro.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Rubro.Presentation.Presenters
{
    public class ObtenerRubroPorIdPresenter : IPresenter<
        int,
        long,
        RubroDto,
        ItemResponse<RubroClientDto>>
    {
        public long ToRequest(int clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<RubroClientDto> ToResponse(RubroDto dto)
        {
            return new ItemResponse<RubroClientDto>
            {
                IsSuccess = true,
                Item = RubroClientMapper.ToClientDto(dto),
            };
        }
    }
}
