using Especialidad.Application.Dtos;
using Especialidad.Presentation.Dtos.Responses;
using Especialidad.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Especialidad.Presentation.Presenters
{
    public class ObtenerEspecialidadPorIdPresenter : IPresenter<
        int,
        long,
        EspecialidadDto,
        ItemResponse<EspecialidadClientDto>>
    {
        public long ToRequest(int clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<EspecialidadClientDto> ToResponse(EspecialidadDto dto)
        {
            return new ItemResponse<EspecialidadClientDto>
            {
                IsSuccess = true,
                Item = EspecialidadClientMapper.ToClientDto(dto),
            };
        }
    }
}
