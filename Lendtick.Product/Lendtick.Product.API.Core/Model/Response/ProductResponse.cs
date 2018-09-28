using System.Collections.Generic;

namespace Lendtick.Product.API.Core.Model.Response
{
    public class ProductResponse : BaseListResponse<Product>
    { }

    public class Product
    {
        public string _id { get; set; }
        public IEnumerable<Desc> desc { get; set; }
        public string Name { get; set; }
        public string Lname { get; set; }
        public string Category { get; set; }
        public Brand Brand { get; set; }
        public Assets Assets { get; set; }
        public Shipping Shipping { get; set; }
        public IEnumerable<Specs> specs { get; set; }
        public IEnumerable<Attrs> attrs { get; set; }
        public Variants Variants { get; set; }
        public long LastUpdated { get; set; }
    }

    public class Desc
    {
        public string Lang { get; set; }
        public string Val { get; set; }
    }

    public class Brand
    {
        public string Id { get; set; }
        public BrandImg Img { get; set; }
        public string Name { get; set; }
    }

    public class BrandImg
    {
        public string Src { get; set; }
    }

    public class Assets
    {
        public IEnumerable<Imgs> imgs { get; set; }
    }

    public class Imgs
    {
        public Img Img { get; set; }
    }

    public class Img
    {
        public string Height { get; set; }
        public string Src { get; set; }
        public string Width { get; set; }
    }

    public class Shipping
    {
        public Dimensions Dimensions { get; set; }
        public string Weight { get; set; }
    }

    public class Dimensions
    {
        public string Height { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
    }

    public class Specs
    {
        public string Name { get; set; }
        public string Val { get; set; }
    }

    public class Attrs
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class Variants
    {
        public int Cnt { get; set; }
        public IEnumerable<VarianAttrs> attrs { get; set; }
    }

    public class VarianAttrs
    {
        public string DispType { get; set; }
        public string Name { get; set; }
    }
}