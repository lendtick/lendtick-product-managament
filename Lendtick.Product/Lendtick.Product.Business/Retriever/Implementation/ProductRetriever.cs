using Lendtick.Product.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lendtick.Product.Business.Retriever
{
    internal class SearchProductRetriever : BaseRetriever, IProductRetriever
    {
        public SearchProductRetriever() { }
        public SearchProductRetriever(string searchBy, string sortBy)
        {
            this.SearchBy = searchBy;
            this.SortBy = sortBy;
        }

        public async Task<IEnumerable<Data.Entity.Mongo.Product>> RetrieveListAsync()
        {
            IEnumerable<Data.Entity.Mongo.Product> products = new List<Data.Entity.Mongo.Product>();
            ProductRepository repo = new ProductRepository(this.SearchBy);

            products = await repo.SearchProductAsync();

            return products;
        }
    }

    internal class AllProductRetriever : BaseRetriever, IProductRetriever
    {
        public AllProductRetriever() { }

        public async Task<IEnumerable<Data.Entity.Mongo.Product>> RetrieveListAsync()
        {
            IEnumerable<Data.Entity.Mongo.Product> products = new List<Data.Entity.Mongo.Product>();
            ProductRepository repo = new ProductRepository();

            products = await repo.GetAllProductAsync();

            return products;
        }
    }
}