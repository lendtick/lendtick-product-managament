using Lendtick.Product.Data.MongoFactory;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lendtick.Product.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        public string Criteria { get; private set; }

        public ProductRepository() { }
        public ProductRepository(string criteria)
        {
            this.Criteria = criteria;
        }

        public async Task<IEnumerable<Entity.Mongo.Product>> SearchProductAsync()
        {
            IEnumerable<Entity.Mongo.Product> products = new List<Entity.Mongo.Product>();
            IMongoCollection<Entity.Mongo.Product> collection = DatabaseFactory.LendtickMongo.GetCollection<Entity.Mongo.Product>("product");

            products = await collection.Find(Builders<Entity.Mongo.Product>.Filter.Empty).ToListAsync();

            return products;
        }

        public async Task<IEnumerable<Entity.Mongo.Product>> GetAllProductAsync()
        {
            IEnumerable<Entity.Mongo.Product> products = new List<Entity.Mongo.Product>();
            IMongoCollection<Entity.Mongo.Product> collection = DatabaseFactory.LendtickMongo.GetCollection<Entity.Mongo.Product>("product");

            products = await collection.Find(Builders<Entity.Mongo.Product>.Filter.Empty).ToListAsync();

            return products;
        }
    }
}