using Empresa.Application.EMP_TipoDirector.Dtos;
using Empresa.Presentation.EMP_TipoDirector.Dtos.Responses;
using Empresa.Presentation.EMP_TipoDirector.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_TipoDirector.Presenters
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
