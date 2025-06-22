using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Shared.Kernel.Mappers
{
    public class SpResultMapper<T> : IMapper<SpResultBase, ResponseBase<T>>
    {
        public ResponseBase<T> Map(SpResultBase source)
        {
            return new ResponseBase<T>
            {
                Success = source.Success,
                Message = source.Message,
                Data = (T)Convert.ChangeType(source.Data, typeof(T))
            };
        }
    }
}
