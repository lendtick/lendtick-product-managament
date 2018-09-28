using Lendtick.Product.Data.Entity.Mongo;
using Lendtick.Product.Data.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Lentick.Product.xUnit.DataLayer
{
    public class CategoryRepositoryTest
    {
        [Fact]
        private async Task GetFirstCategory()
        {
            IEnumerable<Category> result = new List<Category>();
            ICategoryRepository repo = new CategoryRepository();

            result = await repo.GetFirstCategoryAsync();
        }

        [Fact]
        private async Task GetSecondCategory()
        {
            IEnumerable<Category> result = new List<Category>();
            ICategoryRepository repo = new CategoryRepository("CAT10001");

            result = await repo.GetSecondCategoryAsync();
        }

        [Fact]
        private async Task GetThirdategory()
        {
            IEnumerable<Category> result = new List<Category>();
            ICategoryRepository repo = new CategoryRepository("CAT20001");

            result = await repo.GetThirdCategoryAsync();
        }
    }
}
