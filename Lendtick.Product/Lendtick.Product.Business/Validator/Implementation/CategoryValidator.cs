using Lendtick.Product.Common;
using Lendtick.Product.Common.Resources;
using Lendtick.Product.Data.Entity.Mongo;
using System.Collections.Generic;
using System.Linq;

namespace Lendtick.Product.Business.Validator
{
    internal class CategoryValidator : IBaseValidator
    {
        #region Properties
        public IEnumerable<Category> Categories { get; private set; }
        #endregion

        #region CTOR
        public CategoryValidator(IEnumerable<Category> categories)
        {
            this.Categories = categories;
        }
        #endregion

        #region Implemented Method
        public IResultStatus Validate()
        {
            IResultStatus result = new ResultStatus();

            if (this.Categories == null || this.Categories.ToList().Count <= 0)
            {
                result.SetErrorStatus(string.Format(Message.ERROR_DATA_NOT_FOUND, "kategori"));
            }
            else
            {
                result.SetSuccessStatus(string.Format(Message.SUCCESS_DATA_FOUND, "kategori"));
            }

            return result;
        } 
        #endregion
    }
}