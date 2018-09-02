using System;
using System.Collections.Generic;
using System.Text;

namespace Lendtick.Product.Data.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        #region Exists Methods
        //bool Exists(string id);
        #endregion

        #region Create Methods
        //IResultStatus Insert(TDomain domain);
        //IResultStatus Insert(IEnumerable<TDomain> domains);
        #endregion

        #region Retrieve Methods
        //TEntity SelectById(object id);
        //IEnumerable<TEntity> SelectAll();
        //IEnumerable<TEntity> SelectWhere(string where);
        #endregion

        #region Update Methods
        //IResultStatus Update(TDomain domain);
        //IResultStatus Update(IEnumerable<TDomain> domains);
        #endregion

        #region Delete Methods
        //IResultStatus Delete(TDomain domain);
        //IResultStatus Delete(IEnumerable<TDomain> domains);
        #endregion

        #region Stored Procedure Methods
        #endregion
    }
}
