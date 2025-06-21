using Director.Application.Dtos;
using Director.Presentation.Dtos.Request;
using Director.Presentation.Dtos.Responses;
using Director.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Director.Presentation.Presenters
{
    public class ListarDirectorPresenter : IPresenter<
        ListarDirectorClientRequest,
        ListarDirectorRequest,
        List<DirectorDto>,
        LstItemResponse<DirectorClientDto>>
    {
        public ListarDirectorRequest ToRequest(ListarDirectorClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<DirectorClientDto> ToResponse(List<DirectorDto> dto)
        {
            return new LstItemResponse<DirectorClientDto>
            {
                LstItem = DirectorClientMapper.ToClientDtos(dto),
                IsSuccess = true
            };
        }
    }
}
