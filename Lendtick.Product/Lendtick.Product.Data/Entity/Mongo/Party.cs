using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;

namespace Lendtick.Product.Data.Entity.Mongo
{
    [BsonIgnoreExtraElements]
    public class Party
    {
        [BsonElement("_id")]
        [BsonIgnoreIfDefault]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        public string _id { get; set; }

        [BsonElement("desc")]
        public IEnumerable<Desc> desc { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("lname")]
        public string Lname { get; set; }

        [BsonElement("category")]
        public string Category { get; set; }

        [BsonElement("brand")]
        public Brand Brand { get; set; }

        [BsonElement("assets")]
        public Assets Assets { get; set; }

        [BsonElement("shipping")]
        public Shipping Shipping { get; set; }

        [BsonElement("specs")]
        public IEnumerable<Specs> specs { get; set; }

        [BsonElement("attrs")]
        public IEnumerable<Attrs> attrs { get; set; }

        [BsonElement("variants")]
        public Variants Variants { get; set; }

        [BsonElement("lastUpdated")]
        public long LastUpdated { get; set; }
    }
}