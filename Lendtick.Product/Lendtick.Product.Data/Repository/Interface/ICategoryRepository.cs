using MongoDbGenericRepository;
using System.Collections.Generic;

namespace Lendtick.Product.Data.Repository
{
    public interface ICategoryRepository : IBaseMongoRepository
    {
        string ParentCategory { get; }

        IEnumerable<string> GetFirstCategory();
        IEnumerable<string> GetSecondCategory();
        IEnumerable<string> GetThirdCategory();
    }
}