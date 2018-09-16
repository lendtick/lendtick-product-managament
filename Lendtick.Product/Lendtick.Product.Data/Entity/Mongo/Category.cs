using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Lendtick.Product.Data.Entity.Mongo
{
    [BsonIgnoreExtraElements]
    public class Category
    {
        [BsonId]
        public ObjectId id { get; set; }

        [BsonElement("id_categroy")]
        public string id_categroy { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("parents")]
        public IEnumerable<string> parents { get; set; }
    }
}