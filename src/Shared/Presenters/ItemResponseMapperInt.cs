using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Shared.Presenters
{
    public class ItemResponseMapperInt : IPresenterDelivery<SpResultBase, ItemResponse<int>>
    {
        public ItemResponse<int> Present(SpResultBase input)
        {
            return new ItemResponse<int>
            {
                IsSuccess = input.Success,
                Item = input.Data,
            };
        }
    }
}
