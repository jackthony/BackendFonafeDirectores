using Empresa.Application.EMP_Sector.Dtos;
using Empresa.Presentation.EMP_Sector.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Sector.Presenters
{
    public class CrearSectorPresenter : IPresenter<
    CrearSectorClientRequest,
    CrearSectorRequest,
    SpResultBase,
    ItemResponse<int>>
    {
        public CrearSectorRequest ToRequest(CrearSectorClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<int> ToResponse(SpResultBase dto)
        {
            return new ItemResponse<int>
            {
                IsSuccess = dto.Success,
                Item = (int)dto.Data,
                LstError = dto.Success
            ? []
            : [dto.Message ?? "Ocurrió un error al procesar la solicitud"]
            };
        }
    }
}
