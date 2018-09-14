using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lendtick.Product.Data.Repository
{
    public interface ICategoryRepository
    {
        string ParentCategory { get; }

        Task<IEnumerable<string>> GetFirstCategory();
        Task<IEnumerable<string>> GetSecondCategory();
        Task<IEnumerable<string>> GetThirdCategory();
    }
}