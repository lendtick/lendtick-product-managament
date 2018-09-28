using Lendtick.Product.Common;
using Lendtick.Product.Data.Entity.Mongo;
using Lendtick.Product.Data.Repository;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Lentick.Product.xUnit.DataLayer
{
    public class PartyRepositoryTest
    {
        [Fact]
        private async Task AddToParty()
        {
            Party party = new Party();
            IResultStatus result = new ResultStatus();
            IPartyRepository repo = new PartyRepository(party);

            result = await repo.AddToParty();
        }
    }
}
