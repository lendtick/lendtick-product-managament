namespace Lendtick.Product.API.Core.Model.Request
{
    public class BaseSearchRequest
    {
        public int page { get; set; }
        public int row { get; set; }
        public string sort_by { get; set; }
        public string search { get; set; }
    }
}
