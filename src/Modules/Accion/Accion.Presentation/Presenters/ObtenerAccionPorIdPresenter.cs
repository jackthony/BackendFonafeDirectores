using Accion.Application.Dtos;
using Accion.Presentation.Dtos.Responses;
using Accion.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Accion.Presentation.Presenters
{
    public class ObtenerAccionPorIdPresenter : IPresenter<
        int,
        long,
        AccionDto,
        ItemResponse<AccionClientDto>>
    {
        public long ToRequest(int clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<AccionClientDto> ToResponse(AccionDto dto)
        {
            return new ItemResponse<AccionClientDto>
            {
                IsSuccess = true,
                Item = AccionClientMapper.ToClientDto(dto),
            };
        }
    }
}
