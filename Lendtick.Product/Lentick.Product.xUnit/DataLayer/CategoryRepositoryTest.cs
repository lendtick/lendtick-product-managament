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
            IEnumerable<string> result = new List<string>();
            ICategoryRepository repo = new CategoryRepository();

            result = await repo.GetFirstCategory();
        }

        [Fact]
        private async Task GetSecondCategory()
        {
            IEnumerable<string> result = new List<string>();
            ICategoryRepository repo = new CategoryRepository("Automotive");

            result = await repo.GetSecondCategory();
        }

        [Fact]
        private async Task GetThirdategory()
        {
            IEnumerable<string> result = new List<string>();
            ICategoryRepository repo = new CategoryRepository("Computer DIY");

            result = await repo.GetThirdCategory();
        }
    }
}
