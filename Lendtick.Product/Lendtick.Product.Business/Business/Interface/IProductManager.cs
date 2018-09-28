using Lendtick.Product.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lendtick.Product.Business.Business
{
    public interface IProductManager : IBaseBusinessManager
    {
        #region Contract Property
        IEnumerable<Data.Entity.Mongo.Product> Products { get; }
        #endregion

        #region Contract Method
        Task<IResultStatus> SearchProduct();
        Task<IResultStatus> RetrieveAllProduct();
        #endregion
    }
}