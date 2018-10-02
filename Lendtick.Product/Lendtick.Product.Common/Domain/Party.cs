using System.Collections.Generic;

namespace Lendtick.Product.Common.Domain
{
    public class Party
    {
        public List<Desc> desc { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string category { get; set; }
        public Brand brand { get; set; }
        public Asset assets { get; set; }
        public Shipping shipping { get; set; }
        public List<Spec> specs { get; set; }
        public List<Attribute> attrs { get; set; }
        public Variant variants { get; set; }
        public long lastupdated { get; set; }
    }

    public class Desc
    {
        public string Lang { get; set; }
        public string Val { get; set; }
    }

    public class Brand
    {
        public string Id { get; set; }
        public BrandImage Img { get; set; }
        public string Name { get; set; }
    }

    public class BrandImage
    {
        public string Src { get; set; }
    }

    public class Asset
    {
        public List<Image> imgs { get; set; }
    }

    public class Image
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
        public Dimension Dimensions { get; set; }
        public string Weight { get; set; }
    }

    public class Dimension
    {
        public string Height { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
    }

    public class Spec
    {
        public string Name { get; set; }
        public string Val { get; set; }
    }

    public class Attribute
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class Variant
    {
        public int Cnt { get; set; }
        public List<Varian> attrs { get; set; }
    }

    public class Varian
    {
        public string DispType { get; set; }
        public string Name { get; set; }
    }
}
