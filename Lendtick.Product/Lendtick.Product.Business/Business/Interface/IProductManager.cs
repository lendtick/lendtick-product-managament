using Lendtick.Product.Common;
using Lendtick.Product.Common.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lendtick.Product.Business.Business
{
    public interface IProductManager : IBaseBusinessManager
    {
        #region Contract Property
        Party Party { get; }
        IEnumerable<Data.Entity.Mongo.Product> Products { get; }
        #endregion

        #region Contract Method
        Task<IResultStatus> SearchProduct();
        Task<IResultStatus> RetrieveAllProduct();
        Task<IResultStatus> AddToParty();
        #endregion
    }
}