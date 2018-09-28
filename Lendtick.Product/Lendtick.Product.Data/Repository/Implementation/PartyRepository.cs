using Lendtick.Product.Common;
using Lendtick.Product.Common.Resources;
using Lendtick.Product.Data.Entity.Mongo;
using Lendtick.Product.Data.MongoFactory;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Lendtick.Product.Data.Repository
{
    public class PartyRepository : IPartyRepository
    {
        public Party Data { get; private set; }

        public PartyRepository() { }

        public PartyRepository(Party data)
        {
            this.Data = data;
        }

        public async Task<IResultStatus> AddToParty()
        {
            IResultStatus result = new ResultStatus();

            IMongoCollection<Party> collection = DatabaseFactory.LendtickMongo.GetCollection<Party>("party");
            await collection.InsertOneAsync(this.Data);

            if (string.IsNullOrWhiteSpace(this.Data._id))
            {
                result.SetErrorStatus(string.Format(Message.ERROR_INSERT, "party"));
            }
            else
            {
                result.SetSuccessStatus(string.Format(Message.SUCCESS_INSERT, "party"));
            }

            return result;
        }
    }
}