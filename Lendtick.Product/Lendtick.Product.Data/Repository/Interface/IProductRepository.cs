using Lendtick.Product.Common.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lendtick.Product.Data.Repository
{
    public interface IProductRepository
    {
        //string Criteria { get; }
        SearchProduct Criteria { get; }

        Task<IEnumerable<Entity.Mongo.Product>> SearchProductAsync();

        Task<IEnumerable<Entity.Mongo.Product>> GetAllProductAsync();
    }
}