using Empresa.Application.EMP_Rubro.Dtos;
using Empresa.Presentation.EMP_Rubro.Dtos.Responses;
using Empresa.Presentation.EMP_Rubro.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_Rubro.Presenters
{
    public class ObtenerRubroPorIdPresenter : IPresenter<
    int,
    long,
    RubroDto,
    ItemResponse<RubroClientDto>>
    {
        public long ToRequest(int clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<RubroClientDto> ToResponse(RubroDto dto)
        {
            return new ItemResponse<RubroClientDto>
            {
                IsSuccess = true,
                Item = RubroClientMapper.ToClientDto(dto),
            };
        }
    }
}
