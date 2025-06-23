using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Shared.Presenters
{
    public class ItemResponseMapperBool : IPresenterDelivery<SpResultBase, ItemResponse<bool>>
    {
        public ItemResponse<bool> Present(SpResultBase input)
        {
            return new ItemResponse<bool>
            {
                IsSuccess = input.Success,
                Item = input.Data > 0
            };
        }
    }
}
