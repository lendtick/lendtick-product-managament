using System.Collections.Generic;

namespace Lendtick.Product.API.Core.Model.Response
{
    public class ProductResponse : BaseListResponse<Product>
    { }

    public class Product
    {
        public string id_product { get; set; }
        public List<ProductDesc> desc { get; set; }
        public string name { get; set; }
        public string lname { get; set; }
        public string category { get; set; }
        public ProductBrand brand { get; set; }
        public ProductPrice price { get; set; }
        public ProductAssets assets { get; set; }
        public ProductShipping shipping { get; set; }
        public List<ProductChannel> channel { get; set; }
        public List<ProductAttr> attrs { get; set; }
        public string lastUpdated { get; set; }
    }

    public class ProductDesc
    {
        public string lang { get; set; }
        public string val { get; set; }
    }

    public class ProductImg
    {
        public string src { get; set; }
    }

    public class ProductBrand
    {
        public ProductImg img { get; set; }
        public string name { get; set; }
    }

    public class ProductPromo2
    {
        public string id_promo { get; set; }
        public string promo_name { get; set; }
    }

    public class ProductPromo
    {
        public List<ProductPromo2> promo { get; set; }
    }

    public class ProductPrice
    {
        public decimal base_price { get; set; }
        public string margin_type { get; set; }
        public decimal margin_amount { get; set; }
        public decimal sell_price { get; set; }
        public List<ProductPromo> promos { get; set; }
    }

    public class ProductAssets
    {
        public List<ProductImg2> imgs { get; set; }
    }

    public class ProductImg2
    {
        public ProductImg3 img { get; set; }
    }

    public class ProductImg3
    {
        public string height { get; set; }
        public string src { get; set; }
        public string width { get; set; }
    }

    public class ProductShipping
    {
        public ProductDimensions dimensions { get; set; }
        public string weight { get; set; }
    }

    public class ProductDimensions
    {
        public string height { get; set; }
        public string length { get; set; }
        public string width { get; set; }
    }

    public class ProductChannel
    {
        public string channel_id { get; set; }
        public string channel_name { get; set; }
        public string channel_image { get; set; }
        public string channel_product_id { get; set; }
    }

    public class ProductAttr
    {
        public string name { get; set; }
        public string value { get; set; }
    }
}