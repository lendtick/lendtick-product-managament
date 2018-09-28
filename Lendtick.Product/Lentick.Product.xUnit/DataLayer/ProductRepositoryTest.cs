using Lendtick.Product.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Lentick.Product.xUnit.DataLayer
{
    public class CategoryRepoProductRepositoryTestsitoryTest
    {
        [Fact]
        private async Task SearchProduct()
        {
            IEnumerable<Lendtick.Product.Data.Entity.Mongo.Product> result =
                new List<Lendtick.Product.Data.Entity.Mongo.Product>();
            IProductRepository repo = new ProductRepository();

            result = await repo.SearchProductAsync();
        }
    }
}
