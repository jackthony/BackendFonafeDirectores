using TipoDirector.Application.Dtos;
using TipoDirector.Presentation.Dtos.Request;
using TipoDirector.Presentation.Dtos.Responses;
using TipoDirector.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace TipoDirector.Presentation.Presenters
{
    public class ListarTipoDirectorPresenter : IPresenter<
        ListarTipoDirectorClientRequest,
        ListarTipoDirectorRequest,
        List<TipoDirectorDto>,
        LstItemResponse<TipoDirectorClientDto>>
    {
        public ListarTipoDirectorRequest ToRequest(ListarTipoDirectorClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<TipoDirectorClientDto> ToResponse(List<TipoDirectorDto> dto)
        {
            return new LstItemResponse<TipoDirectorClientDto>
            {
                LstItem = TipoDirectorClientMapper.ToClientDtos(dto),
                IsSuccess = true
            };
        }
    }
}
