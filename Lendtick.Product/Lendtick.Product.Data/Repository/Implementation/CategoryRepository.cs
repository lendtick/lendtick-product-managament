using Lendtick.Product.Data.Entity.Mongo;
using Lendtick.Product.Data.MongoFactory;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lendtick.Product.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        #region Property
        public string ParentCategory { get; private set; }
        #endregion

        #region CTOR
        public CategoryRepository() { }
        public CategoryRepository(string parentCategory)
        {
            this.ParentCategory = parentCategory;
        }
        #endregion

        #region Implemented Methods
        public async Task<IEnumerable<string>> GetFirstCategory()
        {
            IEnumerable<string> categories = new List<string>();
            IMongoCollection<Category> collection = DatabaseFactory.LendtickMongo.GetCollection<Category>("category");
            FieldDefinition<Category, string> field = "firstcategory";

            categories = await collection.Distinct(field, Builders<Category>.Filter.Empty).ToListAsync();

            return categories;
        }

        public async Task<IEnumerable<string>> GetSecondCategory()
        {
            IEnumerable<string> categories = new List<string>();
            IMongoCollection<Category> collection = DatabaseFactory.LendtickMongo.GetCollection<Category>("category");
            FieldDefinition<Category, string> field = "secondcategory";
            FilterDefinition<Category> filter = new FilterDefinitionBuilder<Category>().Where(x => x.firstcategory == this.ParentCategory);

            categories = await collection.Distinct(field, filter).ToListAsync();

            return categories;
        }

        public async Task<IEnumerable<string>> GetThirdCategory()
        {
            IEnumerable<string> categories = new List<string>();
            IMongoCollection<Category> collection = DatabaseFactory.LendtickMongo.GetCollection<Category>("category");
            FieldDefinition<Category, string> field = "thirdcategory";
            FilterDefinition<Category> filter = new FilterDefinitionBuilder<Category>().Where(x => x.secondcategory == this.ParentCategory);

            categories = await collection.Distinct(field, filter).ToListAsync();

            return categories;
        }
        #endregion
    }
}
