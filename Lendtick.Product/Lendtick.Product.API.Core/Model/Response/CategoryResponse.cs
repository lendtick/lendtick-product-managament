namespace Lendtick.Product.API.Core.Model.Response
{
    public class CategoryResponse : BaseListResponse<Category>
    { }

    public class Category
    {
        public string id_categroy { get; set; }
        public string name { get; set; }
    }
}