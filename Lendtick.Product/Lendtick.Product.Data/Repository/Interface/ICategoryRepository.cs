using Lendtick.Product.Data.Entity.Mongo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lendtick.Product.Data.Repository
{
    public interface ICategoryRepository
    {
        string ParentCategory { get; }

        Task<IEnumerable<Category>> GetFirstCategory();
        Task<IEnumerable<Category>> GetSecondCategory();
        Task<IEnumerable<Category>> GetThirdCategory();
    }
}