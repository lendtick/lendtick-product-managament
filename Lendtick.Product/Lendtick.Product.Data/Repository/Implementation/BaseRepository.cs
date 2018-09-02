using System;
using System.Collections.Generic;
using System.Text;

namespace Lendtick.Product.Data.Repository
{
    public class BaseRepository
    {
        #region Property
        protected long? CurrentIdentity;
        protected string SearchBy;
        protected string SortBy;
        #endregion
    }
}
