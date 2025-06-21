using Director.Application.Dtos;
using Director.Presentation.Dtos.Responses;
using Director.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Director.Presentation.Presenters
{
    public class ObtenerDirectorPorIdPresenter : IPresenter<
        int,
        long,
        DirectorDto,
        ItemResponse<DirectorClientDto>>
    {
        public long ToRequest(int clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<DirectorClientDto> ToResponse(DirectorDto dto)
        {
            return new ItemResponse<DirectorClientDto>
            {
                IsSuccess = true,
                Item = DirectorClientMapper.ToClientDto(dto),
            };
        }
    }
}
