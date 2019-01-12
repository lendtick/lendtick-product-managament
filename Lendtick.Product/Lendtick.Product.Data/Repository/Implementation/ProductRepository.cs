using Lendtick.Product.Common.Domain;
using Lendtick.Product.Data.MongoFactory;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lendtick.Product.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        public SearchProduct Criteria { get; private set; }

        public ProductRepository() { }
        public ProductRepository(SearchProduct criteria)
        {
            this.Criteria = criteria;
        }

        public async Task<IEnumerable<Entity.Mongo.Product>> SearchProductAsync()
        {
            IEnumerable<Entity.Mongo.Product> products = new List<Entity.Mongo.Product>();
            IMongoCollection<Entity.Mongo.Product> collection = DatabaseFactory.LendtickMongo.GetCollection<Entity.Mongo.Product>("product");

            var builders = Builders<Entity.Mongo.Product>.Filter;

            //if (Criteria.price > 0)
            //{
            //    builders.Lte(x => x.price.sell_price, Criteria.price);
            //}

            //var filter = builders.And(Criteria.category);
            //var filter = builders.And(builders.Eq(x => x.BusinessUnitId, item.Item1),
            //                          builders.Eq(x => x.BranchId, item.Item2),
            //                          builders.Eq(x => x.VehicleTypeId, item.Item3),
            //                          builders.Eq(x => x.IsTransmissionManual, item.Item4));

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