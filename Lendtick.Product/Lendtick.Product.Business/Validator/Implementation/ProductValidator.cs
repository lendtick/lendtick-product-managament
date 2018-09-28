using Lendtick.Product.Common;
using Lendtick.Product.Common.Resources;
using System.Collections.Generic;
using System.Linq;

namespace Lendtick.Product.Business.Validator
{
    internal class ProductValidator : IBaseValidator
    {
        #region Properties
        public IEnumerable<Data.Entity.Mongo.Product> Products { get; private set; }
        #endregion

        #region CTOR
        public ProductValidator(IEnumerable<Data.Entity.Mongo.Product> products)
        {
            this.Products = products;
        }
        #endregion

        #region Implemented Method
        public IResultStatus Validate()
        {
            IResultStatus result = new ResultStatus();

            if (this.Products == null || this.Products.ToList().Count <= 0)
            {
                result.SetErrorStatus(string.Format(Message.ERROR_DATA_NOT_FOUND, "produk"));
            }
            else
            {
                result.SetSuccessStatus(string.Format(Message.SUCCESS_DATA_FOUND, "produk"));
            }

            return result;
        }
        #endregion
    }
}