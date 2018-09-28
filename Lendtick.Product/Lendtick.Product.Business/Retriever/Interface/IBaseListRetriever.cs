using System.Collections.Generic;

namespace Lendtick.Product.Business.Retriever
{
    internal interface IBaseListRetriever<T>
    {
        IEnumerable<T> RetrieveList();
    }
}