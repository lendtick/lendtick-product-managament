using System.Threading.Tasks;

namespace Lendtick.Product.Business.Retriever
{
    internal interface IBaseAsyncRetriever<T>
    {
        Task<T> RetrieveAsync();
    }
}