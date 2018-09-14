using Lendtick.Product.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lendtick.Product.Business.Business
{
    public interface ICategoryManager : IBaseBusinessManager
    {
        #region Contract Property
        string ParentCategory { get; }
        IEnumerable<string> Categories { get; }
        #endregion

        #region Contract Method
        Task<IResultStatus> GetFirstCategory();
        Task<IResultStatus> GetSecondCategory();
        Task<IResultStatus> GetThirdCategory();
        #endregion
    }
}