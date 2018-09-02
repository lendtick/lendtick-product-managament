using Lendtick.Product.Data.MongoFactory;
using MongoDbGenericRepository;
using System;
using System.Collections.Generic;

namespace Lendtick.Product.Data.Repository
{
    public class CategoryRepository : BaseMongoRepository, ICategoryRepository
    {
        #region Property
        public string ParentCategory { get; private set; }
        #endregion

        #region CTOR
        public CategoryRepository() : base(DatabaseFactory.LendtickMongo) { }
        public CategoryRepository(string parentCategory) : base(DatabaseFactory.LendtickMongo)
        {
            this.ParentCategory = parentCategory;
        }
        #endregion

        #region Implemented Methods
        public IEnumerable<string> GetFirstCategory()
        {
            IEnumerable<Entity.Mongo.Category> categories = new List<Entity.Mongo.Category>();
            //categories = base.GetCollection<Entity.Mongo.Category>();
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetSecondCategory()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetThirdCategory()
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
