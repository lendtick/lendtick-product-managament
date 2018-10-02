using Lendtick.Product.Business.Retriever;
using Lendtick.Product.Business.Validator;
using Lendtick.Product.Common;
using Lendtick.Product.Common.Domain;
using Lendtick.Product.Data.Repository;
using Mapster;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lendtick.Product.Business.Business
{
    public class ProductManager : BaseBusinessManager, IProductManager
    {
        #region Property
        public IEnumerable<Data.Entity.Mongo.Product> Products { get; private set; }
        public Party Party { get; private set; }
        #endregion

        #region CTOR
        public ProductManager() { }
        public ProductManager(Party party)
        {
            this.Party = party;
        }
        public ProductManager(string searchBy, string sortBy)
        {
            this.SearchBy = searchBy;
            this.SortBy = sortBy;
        }
        #endregion

        #region Implemented Method
        public async Task<IResultStatus> AddToParty()
        {
            Data.Entity.Mongo.Party entity = new Data.Entity.Mongo.Party();
            entity = this.Party.Adapt<Data.Entity.Mongo.Party>();

            IResultStatus result = new ResultStatus();
            PartyRepository repo = new PartyRepository(entity);

            result = await repo.AddToParty();

            return result;
        }

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