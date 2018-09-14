using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Lendtick.Product.Data.Entity.Mongo
{
    public class Category
    {
        [BsonId]
        public ObjectId id { get; set; }
        [BsonElement("firstcategory")]
        public string firstcategory { get; set; }
        [BsonElement("secondcategory")]
        public string secondcategory { get; set; }
        [BsonElement("thirdcategory")]
        public string thirdcategory { get; set; }
    }
}