using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Lendtick.Product.Data.Entity.Mongo
{
    [BsonIgnoreExtraElements]
    public class Product
    {
        [BsonElement("_id")]
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
        public Int64 LastUpdated { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class Desc
    {
        [BsonElement("lang")]
        public string Lang { get; set; }

        [BsonElement("val")]
        public string Val { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class Brand
    {
        [BsonElement("id")]
        public string Id { get; set; }

        [BsonElement("img")]
        public BrandImg Img { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class BrandImg
    {
        [BsonElement("src")]
        public string Src { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class Assets
    {
        [BsonElement("imgs")]
        public IEnumerable<Imgs> imgs { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class Imgs
    {
        [BsonElement("img")]
        public Img Img { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class Img
    {
        [BsonElement("height")]
        public string Height { get; set; }

        [BsonElement("src")]
        public string Src { get; set; }

        [BsonElement("width")]
        public string Width { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class Shipping
    {
        [BsonElement("dimensions")]
        public Dimensions Dimensions { get; set; }

        [BsonElement("weight")]
        public string Weight { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class Dimensions
    {
        [BsonElement("height")]
        public string Height { get; set; }

        [BsonElement("length")]
        public string Length { get; set; }

        [BsonElement("width")]
        public string Width { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class Specs
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("val")]
        public string Val { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class Attrs
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("value")]
        public string Value { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class Variants
    {
        [BsonElement("cnt")]
        public Int32 Cnt { get; set; }

        [BsonElement("attrs")]
        public IEnumerable<VarianAttrs> attrs { get; set; }
    }

    [BsonIgnoreExtraElements]
    public class VarianAttrs
    {
        [BsonElement("dispType")]
        public string DispType { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }
    }
}