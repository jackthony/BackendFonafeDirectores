using Empresa.Application.EMP_Director.Dtos;
using Empresa.Presentation.EMP_Director.Dtos.Request;
using Empresa.Presentation.EMP_Director.Dtos.Responses;
using Empresa.Presentation.EMP_Director.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_Director.Presenters
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
