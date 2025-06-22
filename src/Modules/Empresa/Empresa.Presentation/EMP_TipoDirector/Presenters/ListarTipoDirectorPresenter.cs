using Empresa.Application.EMP_TipoDirector.Dtos;
using Empresa.Presentation.EMP_TipoDirector.Dtos.Request;
using Empresa.Presentation.EMP_TipoDirector.Dtos.Responses;
using Empresa.Presentation.EMP_TipoDirector.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_TipoDirector.Presenters
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
