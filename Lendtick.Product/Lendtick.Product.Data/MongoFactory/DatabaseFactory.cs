using Lendtick.Product.Common;
using MongoDB.Driver;

namespace Lendtick.Product.Data.MongoFactory
{
    internal static class DatabaseFactory
    {
        private static IMongoDatabase lendtickMongo;
        internal static IMongoDatabase LendtickMongo
        {
            get
            {
                if (lendtickMongo == null)
                {
                    MongoClient client = new MongoClient(AppConst.LENDTICK_MONGODB_CONN_STRING);
                    lendtickMongo = client.GetDatabase(AppConst.LENDTICK_MONGO_DATABASE_NAME);
                }

                return lendtickMongo;
            }
        }
    }
}