using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Domain.User.Results;
using Usuario.Presentation.User.Mappers;
using Usuario.Presentation.User.Responses;

namespace Usuario.Presentation.User.Presenters
{
    public class ListUserPaginadoResponsePresenter : IPresenterDelivery<PagedResult<UserResult>, LstItemResponse<UserResponse>>
    {
        public LstItemResponse<UserResponse> Present(PagedResult<UserResult> input)
        {
            int startIndex = (input.Page - 1) * input.PageSize;

            var lista = UserResponseMapper.ToListResponse(input.Items);
            var listaItems = lista.ToList();
            for (int i = 0; i < listaItems.Count; i++)
            {
                listaItems[i].indice = startIndex + i + 1;
            }

            return new LstItemResponse<UserResponse>
            {
                LstItem = listaItems,
                Pagination = new Pagination
                {
                    PageIndex = input.Page,
                    PageSize = input.PageSize,
                    TotalRows = input.TotalItems
                },
                IsSuccess = true
            };
        }
    }
}
