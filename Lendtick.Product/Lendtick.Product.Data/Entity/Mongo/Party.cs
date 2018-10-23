using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
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
        public List<PartyDesc> desc { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("category")]
        public string category { get; set; }

        [BsonElement("brand")]
        public PartyBrand brand { get; set; }

        [BsonElement("price")]
        public PartyPrice price { get; set; }

        [BsonElement("assets")]
        public PartyAssets assets { get; set; }

        [BsonElement("shipping")]
        public PartyShipping shipping { get; set; }

        [BsonElement("channel")]
        public List<PartyChannel> channel { get; set; }

        [BsonElement("attrs")]
        public List<PartyAttr> attrs { get; set; }

        [BsonElement("lastUpdated")]
        public string lastUpdated { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class PartyDesc
    {
        [BsonElement("lang")]
        public string lang { get; set; }

        [BsonElement("val")]
        public string val { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class PartyImg
    {
        [BsonElement("src")]
        public string src { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class PartyBrand
    {
        [BsonElement("img")]
        public PartyImg img { get; set; }

        [BsonElement("name")]
        public string name { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class PartyPrice
    {
        [BsonElement("base_price")]
        public int base_price { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class PartyImg3
    {
        [BsonElement("height")]
        public string height { get; set; }

        [BsonElement("src")]
        public string src { get; set; }

        [BsonElement("width")]
        public string width { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class PartyImg2
    {
        [BsonElement("img")]
        public PartyImg3 img { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class PartyAssets
    {
        [BsonElement("imgs")]
        public List<PartyImg2> imgs { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class PartyDimensions
    {
        [BsonElement("height")]
        public string height { get; set; }

        [BsonElement("length")]
        public string length { get; set; }

        [BsonElement("width")]
        public string width { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class PartyShipping
    {
        [BsonElement("dimensions")]
        public PartyDimensions dimensions { get; set; }

        [BsonElement("weight")]
        public string weight { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class PartyChannel
    {
        [BsonElement("channel_id")]
        public string channel_id { get; set; }

        [BsonElement("channel_name")]
        public string channel_name { get; set; }

        [BsonElement("channel_image")]
        public string channel_image { get; set; }

        [BsonElement("channel_product_id")]
        public string channel_product_id { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class PartyAttr
    {
        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("value")]
        public string value { get; set; }
    }
}