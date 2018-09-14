namespace Lendtick.Product.Business.Retriever
{
    internal interface IBaseRetriever<T>
    {
        T Retrieve();
    }
}
