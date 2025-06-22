using Empresa.Application.EMP_Ministerio.Dtos;
using Empresa.Presentation.EMP_Ministerio.Dtos.Responses;
using Empresa.Presentation.EMP_Ministerio.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_Ministerio.Presenters
{
    public class ObtenerMinisterioPorIdPresenter : IPresenter<
    int,
    long,
    MinisterioDto,
    ItemResponse<MinisterioClientDto>>
    {
        public long ToRequest(int clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<MinisterioClientDto> ToResponse(MinisterioDto dto)
        {
            return new ItemResponse<MinisterioClientDto>
            {
                IsSuccess = true,
                Item = MinisterioClientMapper.ToClientDto(dto),
            };
        }
    }
}
