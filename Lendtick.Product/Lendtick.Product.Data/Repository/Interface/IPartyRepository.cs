using Lendtick.Product.Common;
using Lendtick.Product.Data.Entity.Mongo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lendtick.Product.Data.Repository
{
    public interface IPartyRepository
    {
        Party Data { get; }

        Task<IResultStatus> AddToParty();
    }
}