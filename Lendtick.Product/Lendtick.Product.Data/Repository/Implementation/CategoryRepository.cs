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
        public async Task<IEnumerable<Category>> GetFirstCategoryAsync()
        {
            IEnumerable<Category> categories = new List<Category>();
            IMongoCollection<Category> collection = DatabaseFactory.LendtickMongo.GetCollection<Category>("category");

            FilterDefinition<Category> filter = new FilterDefinitionBuilder<Category>().Size(x => x.parents, 0);
            //ProjectionDefinition<Category> project = Builders<Category>.Projection.Include(x => x.id_categroy).Include(x => x.name).Exclude(x => x.id);
            categories = await collection.Find(filter).ToListAsync();
            return categories;
        }

        public async Task<IEnumerable<Category>> GetSecondCategoryAsync()
        {
            IEnumerable<Category> categories = new List<Category>();
            IMongoCollection<Category> collection = DatabaseFactory.LendtickMongo.GetCollection<Category>("category");

            FilterDefinitionBuilder<Category> builder = Builders<Category>.Filter;
            FilterDefinition<Category> filter = builder.And(builder.Size(x => x.parents, 1), builder.Eq("parents", this.ParentCategory));

            categories = await collection.Find(filter).ToListAsync();

            return categories;
        }

        public async Task<IEnumerable<Category>> GetThirdCategoryAsync()
        {
            IEnumerable<Category> categories = new List<Category>();
            IMongoCollection<Category> collection = DatabaseFactory.LendtickMongo.GetCollection<Category>("category");

            FilterDefinitionBuilder<Category> builder = Builders<Category>.Filter;
            FilterDefinition<Category> filter = builder.And(builder.Size(x => x.parents, 2), builder.Eq("parents.1", this.ParentCategory));

            categories = await collection.Find(filter).ToListAsync();

            return categories;
        }
        #endregion
    }
}