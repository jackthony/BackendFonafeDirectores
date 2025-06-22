using Empresa.Application.EMP_Director.Dtos;
using Empresa.Presentation.EMP_Director.Dtos.Responses;
using Empresa.Presentation.EMP_Director.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_Director.Presenters
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
