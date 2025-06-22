using Empresa.Application.EMP_TipoDirector.Dtos;
using Empresa.Presentation.EMP_TipoDirector.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_TipoDirector.Presenters
{
    public class EliminarTipoDirectorPresenter : IPresenter<
    EliminarTipoDirectorClientRequest,
    EliminarTipoDirectorRequest,
    SpResultBase,
    ItemResponse<bool>>
    {
        public EliminarTipoDirectorRequest ToRequest(EliminarTipoDirectorClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<bool> ToResponse(SpResultBase dto)
        {
            return new ItemResponse<bool>
            {
                IsSuccess = dto.Success,
                Item = dto.Success,
                LstError = dto.Success
            ? []
            : [dto.Message ?? "Ocurrió un error al procesar la solicitud"]
            };
        }
    }
}
