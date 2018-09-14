using Lendtick.Product.Business.Business;
using Lendtick.Product.Common;
using System.Threading.Tasks;
using Xunit;

namespace Lentick.Product.xUnit.BusinessLayer
{
    public class CategoryManagerTest
    {
        [Fact]
        public async Task GetFirstCategory()
        {
            IResultStatus result = new ResultStatus();
            ICategoryManager manager = new CategoryManager();

            result = await manager.GetFirstCategory();
        }

        [Fact]
        public async Task GetSecondCategory()
        {
            IResultStatus result = new ResultStatus();
            ICategoryManager manager = new CategoryManager("Automotive");

            result = await manager.GetSecondCategory();
        }

        [Fact]
        public async Task GetThirdCategory()
        {
            IResultStatus result = new ResultStatus();
            ICategoryManager manager = new CategoryManager("Computer DIY");

            result = await manager.GetThirdCategory();
        }
    }
}
