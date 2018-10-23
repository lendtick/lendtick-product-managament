using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System.Collections.Generic;

namespace Lendtick.Product.Data.Entity.Mongo
{
    [BsonIgnoreExtraElements]
    public class Product
    {
        [BsonElement("_id")]
        [BsonIgnoreIfDefault]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        public string id_product { get; set; }

        [BsonElement("desc")]
        public List<ProductDesc> desc { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("lname")]
        public string lname { get; set; }

        [BsonElement("category")]
        public string category { get; set; }

        [BsonElement("brand")]
        public ProductBrand brand { get; set; }

        [BsonElement("price")]
        public ProductPrice price { get; set; }

        [BsonElement("assets")]
        public ProductAssets assets { get; set; }

        [BsonElement("shipping")]
        public ProductShipping shipping { get; set; }

        [BsonElement("channel")]
        public List<ProductChannel> channel { get; set; }

        [BsonElement("attrs")]
        public List<ProductAttr> attrs { get; set; }

        [BsonElement("lastUpdated")]
        public string lastUpdated { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class ProductDesc
    {
        [BsonElement("lang")]
        public string lang { get; set; }
        [BsonElement("val")]
        public string val { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class ProductImg
    {
        [BsonElement("src")]
        public string src { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class ProductBrand
    {
        [BsonElement("img")]
        public ProductImg img { get; set; }
        [BsonElement("name")]
        public string name { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class ProductPromo2
    {
        [BsonElement("id_promo")]
        public string id_promo { get; set; }
        [BsonElement("promo_name")]
        public string promo_name { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class ProductPromo
    {
        [BsonElement("promo")]
        public List<ProductPromo2> promo { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class ProductPrice
    {
        [BsonElement("base_price")]
        public decimal base_price { get; set; }
        [BsonElement("margin_type")]
        public string margin_type { get; set; }
        [BsonElement("margin_amount")]
        public decimal margin_amount { get; set; }
        [BsonElement("sell_price")]
        public decimal sell_price { get; set; }
        [BsonElement("promos")]
        public List<ProductPromo> promos { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class ProductAssets
    {
        [BsonElement("imgs")]
        public List<ProductImg2> imgs { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class ProductImg2
    {
        [BsonElement("img")]
        public ProductImg3 img { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class ProductImg3
    {
        [BsonElement("height")]
        public string height { get; set; }
        [BsonElement("src")]
        public string src { get; set; }
        [BsonElement("width")]
        public string width { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class ProductShipping
    {
        [BsonElement("dimensions")]
        public ProductDimensions dimensions { get; set; }
        [BsonElement("weight")]
        public string weight { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class ProductDimensions
    {
        [BsonElement("height")]
        public string height { get; set; }
        [BsonElement("length")]
        public string length { get; set; }
        [BsonElement("width")]
        public string width { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class ProductChannel
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
    public class ProductAttr
    {
        [BsonElement("name")]
        public string name { get; set; }
        [BsonElement("value")]
        public string value { get; set; }
    }
}