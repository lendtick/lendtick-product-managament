using Lendtick.Product.Business.Retriever;
using Lendtick.Product.Business.Validator;
using Lendtick.Product.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lendtick.Product.Business.Business
{
    public class ProductManager : BaseBusinessManager, IProductManager
    {
        #region Property
        public IEnumerable<Data.Entity.Mongo.Product> Products { get; private set; }
        #endregion

        #region CTOR
        public ProductManager() { }
        public ProductManager(string searchBy, string sortBy)
        {
            this.SearchBy = searchBy;
            this.SortBy = sortBy;
        }
        #endregion

        #region Implemented Method
        public async Task<IResultStatus> SearchProduct()
        {
            IResultStatus result = new ResultStatus();
            IProductRetriever retriever = new SearchProductRetriever();

            this.Products = await retriever.RetrieveListAsync();

            IBaseValidator validator = new ProductValidator(this.Products);
            result = validator.Validate();

            return result;
        }

        public async Task<IResultStatus> RetrieveAllProduct()
        {
            IResultStatus result = new ResultStatus();
            IProductRetriever retriever = new AllProductRetriever();

            this.Products = await retriever.RetrieveListAsync();

            IBaseValidator validator = new ProductValidator(this.Products);
            result = validator.Validate();

            return result;
        }
        #endregion
    }
}