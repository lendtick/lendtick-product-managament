using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lendtick.Product.Business.Retriever
{
    internal interface IBaseAsyncListRetriever<T>
    {
        Task<IEnumerable<T>> Retrieve();
    }
}