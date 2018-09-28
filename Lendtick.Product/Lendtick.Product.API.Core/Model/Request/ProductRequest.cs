using System.Collections.Generic;

namespace Lendtick.Product.API.Core.Model.Request
{
    public class PartyRequest
    {
        public List<DescRequest> desc { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string category { get; set; }
        public BrandRequest brand { get; set; }
        public AssetRequest assets { get; set; }
        public ShippingRequest shipping { get; set; }
        public List<SpecRequest> specs { get; set; }
        public List<AttributeRequest> attrs { get; set; }
        public VariantRequest variants { get; set; }
        public long lastupdated { get; set; }
    }

    public class DescRequest
    {
        public string Lang { get; set; }
        public string Val { get; set; }
    }

    public class BrandRequest
    {
        public string Id { get; set; }
        public BrandImageRequest Img { get; set; }
        public string Name { get; set; }
    }

    public class BrandImageRequest
    {
        public string Src { get; set; }
    }

    public class AssetRequest
    {
        public List<ImageRequest> imgs { get; set; }
    }

    public class ImageRequest
    {
        public ImgRequest Img { get; set; }
    }

    public class ImgRequest
    {
        public string Height { get; set; }
        public string Src { get; set; }
        public string Width { get; set; }
    }

    public class ShippingRequest
    {
        public DimensionRequest Dimensions { get; set; }
        public string Weight { get; set; }
    }

    public class DimensionRequest
    {
        public string Height { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
    }

    public class SpecRequest
    {
        public string Name { get; set; }
        public string Val { get; set; }
    }

    public class AttributeRequest
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class VariantRequest
    {
        public int Cnt { get; set; }
        public List<VarianRequest> attrs { get; set; }
    }

    public class VarianRequest
    {
        public string DispType { get; set; }
        public string Name { get; set; }
    }
}