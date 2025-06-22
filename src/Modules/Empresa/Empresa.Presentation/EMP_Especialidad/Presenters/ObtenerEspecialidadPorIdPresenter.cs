using Empresa.Application.EMP_Especialidad.Dtos;
using Empresa.Presentation.EMP_Especialidad.Dtos.Responses;
using Empresa.Presentation.EMP_Especialidad.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_Especialidad.Presenters
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
