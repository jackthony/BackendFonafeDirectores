using Modulo.Application.Dtos;
using Modulo.Presentation.Dtos.Responses;
using Modulo.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Modulo.Presentation.Presenters
{
    public class ObtenerModuloPorIdPresenter : IPresenter<
        int,
        long,
        ModuloDto,
        ItemResponse<ModuloClientDto>>
    {
        public long ToRequest(int clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<ModuloClientDto> ToResponse(ModuloDto dto)
        {
            return new ItemResponse<ModuloClientDto>
            {
                IsSuccess = true,
                Item = ModuloClientMapper.ToClientDto(dto),
            };
        }
    }
}
